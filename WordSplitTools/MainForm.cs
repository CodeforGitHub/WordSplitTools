using JiebaNet.Segmenter;
using JiebaNet.Analyser;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace WordSplitTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            comboBoxSQLType.SelectedIndex = 0;
            comboBoxCutMode.SelectedIndex = 0;
            stopWordsFilePath.Text = Path.Combine(System.Environment.CurrentDirectory, "Resources", "stopwords.txt");
            defaultDictsFilePath.Text = Path.Combine(System.Environment.CurrentDirectory, "Resources", "dict.txt");
            openFileDialog.InitialDirectory = System.Environment.CurrentDirectory;
            InitialJiebaSegmenter();
            InitialStopWords();
        }

        List<string> stopwordsList = new List<string>();
        JiebaSegmenter segmenter;

        private void InitialJiebaSegmenter()
        {
            segmenter = new JiebaSegmenter();
            segmenter.LoadUserDict(defaultDictsFilePath.Text);
        }

        private void InitialStopWords()
        {
            stopwordsList = File.ReadAllLines(stopWordsFilePath.Text).ToList<string>();
        }

        private List<string> WordSplitResult(string strWords)
        {
            List<string> result = new List<string>();
            IEnumerable<string> segments;
            switch (comboBoxCutMode.SelectedIndex)
            {
                case 0:
                    segments = segmenter.Cut(strWords);
                    break;
                case 1:
                    segments = segmenter.CutForSearch(strWords);
                    break;
                case 2:
                    var idf = new TfidfExtractor();
                    segments = idf.ExtractTags(strWords, 20, Constants.NounAndVerbPos);
                    break;
                default:
                    var textRank = new TextRankExtractor();
                    segments = textRank.ExtractTags(strWords, 20, Constants.NounAndVerbPos);
                    break;
            }
            foreach(string str in string.Join(" ", segments).Split(' '))
            {
                if (!stopwordsList.Contains(str))
                    result.Add(str);
            }
            return result;
        }

        private string StringList2String(List<string> strs)
        {
            bool isFirst = true;
            string result = "";
            foreach(string str in strs)
            {
                if (isFirst)
                {
                    isFirst = false;
                    result = str;
                }
                else
                    result += "\t" + str;
            }
            return result;
        }

        private string Dict2String(Dictionary<string, int> dict)
        {
            dict = dict.OrderByDescending(o => o.Value).ToDictionary(p => p.Key, o => o.Value);
            bool isFirst = true;
            string result = "";
            foreach (string str in dict.Keys)
            {
                if (isFirst)
                {
                    isFirst = false;
                    result = str + "\t" + dict[str].ToString();
                }
                else
                    result += "\r\n" + str + "\t" + dict[str].ToString();
            }
            return result;
        }

        private MySqlConnection MySQLConnect()
        {
            MySqlConnection myConnnect = null;
            if (UseConfiguration.Checked)
            {
                IPAddressPort.Text = ConfigurationManager.AppSettings["mysql_Port"];
                warehouse.Text = ConfigurationManager.AppSettings["mysql_Warehouse"];
                IPAddress.Text = ConfigurationManager.AppSettings["mysql_IP"];
                password.Text = ConfigurationManager.AppSettings["mysql_Password"];
                userName.Text = ConfigurationManager.AppSettings["mysql_Username"];
            }
            string strConn = string.Format("database = {0}; server = {1}; password = {2}; user id = {3};port={4};SslMode=0;", warehouse.Text,IPAddress.Text,password.Text,userName.Text, IPAddressPort.Text);
            try
            {
                myConnnect = new MySqlConnection(strConn);
                myConnnect.Open();
                //MessageBox.Show("连接成功");
                Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                cfa.AppSettings.Settings["mysql_Warehouse"].Value = warehouse.Text;
                cfa.AppSettings.Settings["mysql_IP"].Value = IPAddress.Text;
                cfa.AppSettings.Settings["mysql_Password"].Value = password.Text;
                cfa.AppSettings.Settings["mysql_Username"].Value = userName.Text;
                cfa.AppSettings.Settings["mysql_Port"].Value = IPAddressPort.Text;
                cfa.Save();
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch(Exception)
            {
                MessageBox.Show("数据库连接失败，请检查连接配置", "提示");
                return null;
            }
            return myConnnect;
        }

        private NpgsqlConnection PostgreSQLConnect()
        {
            NpgsqlConnection myConnnect = null;
            if (UseConfiguration.Checked)
            {
                IPAddressPort.Text = ConfigurationManager.AppSettings["postgre_Port"];
                warehouse.Text = ConfigurationManager.AppSettings["postgre_Warehouse"];
                IPAddress.Text = ConfigurationManager.AppSettings["postgre_IP"];
                password.Text = ConfigurationManager.AppSettings["postgre_Password"];
                userName.Text = ConfigurationManager.AppSettings["postgre_Username"];
            }
            string strConn = string.Format("PORT={4};DATABASE={0};HOST={1};PASSWORD={2};USER ID={3}", warehouse.Text, IPAddress.Text, password.Text, userName.Text, IPAddressPort.Text);
            try
            {
                myConnnect = new NpgsqlConnection(strConn);
                myConnnect.Open();
                //MessageBox.Show("连接成功");
                Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                cfa.AppSettings.Settings["postgre_Warehouse"].Value = warehouse.Text;
                cfa.AppSettings.Settings["postgre_IP"].Value = IPAddress.Text;
                cfa.AppSettings.Settings["postgre_Password"].Value = password.Text;
                cfa.AppSettings.Settings["postgre_Username"].Value = userName.Text;
                cfa.AppSettings.Settings["postgre_Port"].Value = IPAddressPort.Text;
                cfa.Save();
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception)
            {
                MessageBox.Show("数据库连接失败，请检查连接配置", "提示");
                return null;
            }
            return myConnnect;
        }

        private string[] QuerySQL(string queryStr)
        {
            List<string> result = new List<string>();
            if(comboBoxSQLType.SelectedItem.Equals("MySQL"))
            {
                MySqlConnection conn = MySQLConnect();
                if (conn == null)
                    return null;
                try
                {
                    MySqlCommand myCmd = new MySqlCommand(queryStr, conn);
                    MySqlDataReader dr = myCmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dr.Read())
                    {
                        result.Add(dr[0].ToString());
                    }
                    dr.Close();
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("数据库查询失败，请检查查询语句","提示");
                    return null;
                }
            }
            else if(comboBoxSQLType.SelectedItem.Equals("PostgreSQL"))
            {
                NpgsqlConnection conn = PostgreSQLConnect();
                if (conn == null)
                    return null;
                try
                {
                    NpgsqlCommand mycmd = new NpgsqlCommand();
                    NpgsqlDataReader dr = mycmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dr.Read())
                    {
                        result.Add(dr[0].ToString());
                    }
                    dr.Close();
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("数据库查询失败，请检查查询语句", "提示");
                    return null;
                }
            }
            return result.ToArray();
        }

        private Dictionary<string, int> statisticsResultForWords1;
        private Dictionary<string, int> statisticsResultForWords2;
        private Dictionary<string, int> statisticsResultForWords3;
        private string exportResult2 = null;
        private string exportResult3 = null;

        private void StatisticsForWords(List<string> strs,int tabIndex)
        {
            switch (tabIndex)
            {
                case 0:
                    foreach (string str in strs)
                    {
                        if (statisticsResultForWords1.Keys.Contains(str))
                            statisticsResultForWords1[str] += 1;
                        else
                            statisticsResultForWords1[str] = 1;
                    }
                    break;
                case 1:
                    foreach (string str in strs)
                    {
                        if (statisticsResultForWords2.Keys.Contains(str))
                            statisticsResultForWords2[str] += 1;
                        else
                            statisticsResultForWords2[str] = 1;
                    }
                    break;
                case 2:
                    foreach (string str in strs)
                    {
                        if (statisticsResultForWords3.Keys.Contains(str))
                            statisticsResultForWords3[str] += 1;
                        else
                            statisticsResultForWords3[str] = 1;
                    }
                    break;
            }
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            Stopwatch timecount = new Stopwatch();
            timecount.Start();
            string[] inputStr;
            pProgressBar.Minimum = 0;
            pProgressBar.Value = 0;
            timeTips.Text = "";
            switch (tabControlInputType.SelectedIndex)
            {
                case 0:
                    inputStr = inputTextBox.Lines;
                    pProgressBar.Maximum = inputStr.Length;
                    statisticsResultForWords1 = new Dictionary<string, int>();
                    outputTextBox.Text = "";
                    foreach (string str in inputStr)
                    {
                        if(radioWordCount.Checked)
                        {
                            StatisticsForWords(WordSplitResult(str), tabControlInputType.SelectedIndex);
                            outputTextBox.Text=Dict2String(statisticsResultForWords1);
                        }
                        else if(radioWordSplit.Checked)
                        {
                            outputTextBox.Text += StringList2String(WordSplitResult(str)) + "\r\n";
                        }
                        pProgressBar.Value += 1;
                        outputTextBox.Refresh();
                    }
                    timecount.Stop();
                    timeTips.Text = string.Format("总耗时:{0}s", timecount.Elapsed);
                    break;
                case 1:
                    if (!File.Exists(inputFilePath.Text))
                        return;
                    inputStr = File.ReadAllLines(inputFilePath.Text, System.Text.Encoding.GetEncoding("GBK"));
                    pProgressBar.Maximum = inputStr.Length;
                    statisticsResultForWords2 = new Dictionary<string, int>();
                    exportResult2 = "";
                    foreach (string str in inputStr)
                    {
                        if (radioWordCount.Checked)
                            StatisticsForWords(WordSplitResult(str), tabControlInputType.SelectedIndex);
                        else if (radioWordSplit.Checked)
                            exportResult2 += StringList2String(WordSplitResult(str)) + "\r\n";
                        pProgressBar.Value += 1;
                    }
                    if (radioWordCount.Checked)
                        exportResult2 = Dict2String(statisticsResultForWords2);
                    timecount.Stop();
                    timeTips.Text = string.Format("总耗时:{0}s", timecount.Elapsed);
                    if (saveFileDialog.ShowDialog()==DialogResult.OK)
                    {
                        resultFilePathForFile.Text = saveFileDialog.FileName.ToString();
                        StreamWriter sw = new StreamWriter(resultFilePathForFile.Text,false, System.Text.Encoding.UTF8);
                        sw.Write(exportResult2);
                        sw.Flush();
                        sw.Close();
                    }
                    break;
                case 2:
                    inputStr=QuerySQL(queryText.Text);
                    if (inputStr == null)
                        return;
                    pProgressBar.Maximum = inputStr.Length;
                    statisticsResultForWords3 = new Dictionary<string, int>();
                    exportResult3 = "";
                    foreach (string str in inputStr)
                    {
                        if (radioWordCount.Checked)
                            StatisticsForWords(WordSplitResult(str), tabControlInputType.SelectedIndex);
                        else if (radioWordSplit.Checked)
                            exportResult3 += StringList2String(WordSplitResult(str)) + "\r\n";
                        pProgressBar.Value += 1;
                    }
                    if (radioWordCount.Checked)
                        exportResult3 = Dict2String(statisticsResultForWords3);
                    timecount.Stop();
                    timeTips.Text = string.Format("总耗时:{0}s", timecount.Elapsed);
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        resultFilePathForSQL.Text = saveFileDialog.FileName.ToString();
                        StreamWriter sw = new StreamWriter(resultFilePathForSQL.Text, false, System.Text.Encoding.UTF8);
                        sw.Write(exportResult3);
                        sw.Flush();
                        sw.Close();
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 全选设定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\x1')
            {
                ((TextBox)sender).SelectAll();
                e.Handled = true;
            }
        }

        private void BtOpenFileDialog_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog()== DialogResult.OK)
            {
                if (sender == btStopWordsFilePath)
                {
                    stopWordsFilePath.Text = openFileDialog.FileName;
                    InitialStopWords();
                }
                else if (sender == btDefaultDictsFilePath)
                {
                    defaultDictsFilePath.Text = openFileDialog.FileName;
                    InitialJiebaSegmenter();
                }
                else if (sender == btInputFile)
                    inputFilePath.Text = openFileDialog.FileName;
            }
        }

        private void LinkLabelOpenFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(((LinkLabel)sender).Text);
            }
            catch
            {
                return;
            }
        }


        /*
         * 词性标注
         * var posSeg = new PosSegmenter();
         * var s = "一团硕大无朋的高能离子云，在遥远而神秘的太空中迅疾地飘移";
         * var tokens = posSeg.Cut(s);
         * string=string.Join(" ", tokens.Select(token => string.Format("{0}/{1}", token.Word, token.Flag)));
         */
    }
}
