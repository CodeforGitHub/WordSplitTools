﻿namespace WordSplitTools
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.radioWordCount = new System.Windows.Forms.RadioButton();
            this.radioWordSplit = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxCutMode = new System.Windows.Forms.ComboBox();
            this.btStart = new System.Windows.Forms.Button();
            this.btDefaultDictsFilePath = new System.Windows.Forms.Button();
            this.btStopWordsFilePath = new System.Windows.Forms.Button();
            this.defaultDictsFilePath = new System.Windows.Forms.TextBox();
            this.stopWordsFilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlInputType = new System.Windows.Forms.TabControl();
            this.tabPage_Text = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.tabPage_File = new System.Windows.Forms.TabPage();
            this.resultFilePathForFile = new System.Windows.Forms.LinkLabel();
            this.btInputFile = new System.Windows.Forms.Button();
            this.inputFilePath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage_Sql = new System.Windows.Forms.TabPage();
            this.UseConfiguration = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.queryText = new System.Windows.Forms.TextBox();
            this.warehouse = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.IPAddressPort = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.IPAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.resultFilePathForSQL = new System.Windows.Forms.LinkLabel();
            this.comboBoxSQLType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.timeTips = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.tabControlInputType.SuspendLayout();
            this.tabPage_Text.SuspendLayout();
            this.tabPage_File.SuspendLayout();
            this.tabPage_Sql.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioWordCount
            // 
            this.radioWordCount.AutoSize = true;
            this.radioWordCount.Checked = true;
            this.radioWordCount.Location = new System.Drawing.Point(95, 22);
            this.radioWordCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioWordCount.Name = "radioWordCount";
            this.radioWordCount.Size = new System.Drawing.Size(71, 16);
            this.radioWordCount.TabIndex = 0;
            this.radioWordCount.TabStop = true;
            this.radioWordCount.Text = "分词统计";
            this.radioWordCount.UseVisualStyleBackColor = true;
            // 
            // radioWordSplit
            // 
            this.radioWordSplit.AutoSize = true;
            this.radioWordSplit.Location = new System.Drawing.Point(179, 22);
            this.radioWordSplit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioWordSplit.Name = "radioWordSplit";
            this.radioWordSplit.Size = new System.Drawing.Size(47, 16);
            this.radioWordSplit.TabIndex = 1;
            this.radioWordSplit.Text = "分词";
            this.radioWordSplit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.comboBoxCutMode);
            this.groupBox1.Controls.Add(this.btStart);
            this.groupBox1.Controls.Add(this.btDefaultDictsFilePath);
            this.groupBox1.Controls.Add(this.btStopWordsFilePath);
            this.groupBox1.Controls.Add(this.defaultDictsFilePath);
            this.groupBox1.Controls.Add(this.stopWordsFilePath);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioWordSplit);
            this.groupBox1.Controls.Add(this.radioWordCount);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(694, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(386, 22);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 17;
            this.label16.Text = "分词模式:";
            // 
            // comboBoxCutMode
            // 
            this.comboBoxCutMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCutMode.FormattingEnabled = true;
            this.comboBoxCutMode.Items.AddRange(new object[] {
            "简单分词模式",
            "搜索分词模式",
            "TF-IDF关键词提取",
            "TextRank关键词提取"});
            this.comboBoxCutMode.Location = new System.Drawing.Point(461, 19);
            this.comboBoxCutMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCutMode.Name = "comboBoxCutMode";
            this.comboBoxCutMode.Size = new System.Drawing.Size(123, 20);
            this.comboBoxCutMode.TabIndex = 9;
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btStart.Location = new System.Drawing.Point(601, 44);
            this.btStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(78, 45);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "开始处理";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // btDefaultDictsFilePath
            // 
            this.btDefaultDictsFilePath.Location = new System.Drawing.Point(533, 75);
            this.btDefaultDictsFilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDefaultDictsFilePath.Name = "btDefaultDictsFilePath";
            this.btDefaultDictsFilePath.Size = new System.Drawing.Size(50, 20);
            this.btDefaultDictsFilePath.TabIndex = 8;
            this.btDefaultDictsFilePath.Text = "浏览";
            this.btDefaultDictsFilePath.UseVisualStyleBackColor = true;
            this.btDefaultDictsFilePath.Click += new System.EventHandler(this.BtOpenFileDialog_Click);
            // 
            // btStopWordsFilePath
            // 
            this.btStopWordsFilePath.Location = new System.Drawing.Point(533, 49);
            this.btStopWordsFilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btStopWordsFilePath.Name = "btStopWordsFilePath";
            this.btStopWordsFilePath.Size = new System.Drawing.Size(50, 20);
            this.btStopWordsFilePath.TabIndex = 7;
            this.btStopWordsFilePath.Text = "浏览";
            this.btStopWordsFilePath.UseVisualStyleBackColor = true;
            this.btStopWordsFilePath.Click += new System.EventHandler(this.BtOpenFileDialog_Click);
            // 
            // defaultDictsFilePath
            // 
            this.defaultDictsFilePath.BackColor = System.Drawing.SystemColors.MenuBar;
            this.defaultDictsFilePath.Enabled = false;
            this.defaultDictsFilePath.Location = new System.Drawing.Point(95, 75);
            this.defaultDictsFilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.defaultDictsFilePath.Name = "defaultDictsFilePath";
            this.defaultDictsFilePath.Size = new System.Drawing.Size(435, 21);
            this.defaultDictsFilePath.TabIndex = 6;
            // 
            // stopWordsFilePath
            // 
            this.stopWordsFilePath.BackColor = System.Drawing.SystemColors.MenuBar;
            this.stopWordsFilePath.Enabled = false;
            this.stopWordsFilePath.Location = new System.Drawing.Point(95, 49);
            this.stopWordsFilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopWordsFilePath.Name = "stopWordsFilePath";
            this.stopWordsFilePath.Size = new System.Drawing.Size(435, 21);
            this.stopWordsFilePath.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "自定义词典:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "默认停用词:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "功      能:";
            // 
            // tabControlInputType
            // 
            this.tabControlInputType.Controls.Add(this.tabPage_Text);
            this.tabControlInputType.Controls.Add(this.tabPage_File);
            this.tabControlInputType.Controls.Add(this.tabPage_Sql);
            this.tabControlInputType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlInputType.Location = new System.Drawing.Point(0, 105);
            this.tabControlInputType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlInputType.Name = "tabControlInputType";
            this.tabControlInputType.SelectedIndex = 0;
            this.tabControlInputType.Size = new System.Drawing.Size(709, 449);
            this.tabControlInputType.TabIndex = 3;
            // 
            // tabPage_Text
            // 
            this.tabPage_Text.Controls.Add(this.label5);
            this.tabPage_Text.Controls.Add(this.label4);
            this.tabPage_Text.Controls.Add(this.outputTextBox);
            this.tabPage_Text.Controls.Add(this.inputTextBox);
            this.tabPage_Text.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Text.Name = "tabPage_Text";
            this.tabPage_Text.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Text.Size = new System.Drawing.Size(701, 423);
            this.tabPage_Text.TabIndex = 0;
            this.tabPage_Text.Text = "文本框";
            this.tabPage_Text.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(6, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 14);
            this.label5.TabIndex = 3;
            this.label5.Text = "输出";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "输入";
            // 
            // outputTextBox
            // 
            this.outputTextBox.AcceptsReturn = true;
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outputTextBox.Location = new System.Drawing.Point(2, 236);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTextBox.Size = new System.Drawing.Size(697, 185);
            this.outputTextBox.TabIndex = 1;
            this.outputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
            // 
            // inputTextBox
            // 
            this.inputTextBox.AcceptsReturn = true;
            this.inputTextBox.Location = new System.Drawing.Point(2, 25);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.inputTextBox.Size = new System.Drawing.Size(701, 185);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
            // 
            // tabPage_File
            // 
            this.tabPage_File.Controls.Add(this.resultFilePathForFile);
            this.tabPage_File.Controls.Add(this.btInputFile);
            this.tabPage_File.Controls.Add(this.inputFilePath);
            this.tabPage_File.Controls.Add(this.label7);
            this.tabPage_File.Controls.Add(this.label8);
            this.tabPage_File.Location = new System.Drawing.Point(4, 22);
            this.tabPage_File.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_File.Name = "tabPage_File";
            this.tabPage_File.Size = new System.Drawing.Size(701, 423);
            this.tabPage_File.TabIndex = 3;
            this.tabPage_File.Text = "文件";
            this.tabPage_File.UseVisualStyleBackColor = true;
            // 
            // resultFilePathForFile
            // 
            this.resultFilePathForFile.AutoSize = true;
            this.resultFilePathForFile.Location = new System.Drawing.Point(101, 59);
            this.resultFilePathForFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultFilePathForFile.Name = "resultFilePathForFile";
            this.resultFilePathForFile.Size = new System.Drawing.Size(53, 12);
            this.resultFilePathForFile.TabIndex = 16;
            this.resultFilePathForFile.TabStop = true;
            this.resultFilePathForFile.Text = "结果路径";
            this.resultFilePathForFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelOpenFile_LinkClicked);
            // 
            // btInputFile
            // 
            this.btInputFile.Location = new System.Drawing.Point(539, 20);
            this.btInputFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btInputFile.Name = "btInputFile";
            this.btInputFile.Size = new System.Drawing.Size(50, 20);
            this.btInputFile.TabIndex = 15;
            this.btInputFile.Text = "浏览";
            this.btInputFile.UseVisualStyleBackColor = true;
            this.btInputFile.Click += new System.EventHandler(this.BtOpenFileDialog_Click);
            // 
            // inputFilePath
            // 
            this.inputFilePath.BackColor = System.Drawing.SystemColors.MenuBar;
            this.inputFilePath.Enabled = false;
            this.inputFilePath.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputFilePath.Location = new System.Drawing.Point(101, 21);
            this.inputFilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputFilePath.Name = "inputFilePath";
            this.inputFilePath.Size = new System.Drawing.Size(435, 21);
            this.inputFilePath.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "待处理文件:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "结果路径:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage_Sql
            // 
            this.tabPage_Sql.Controls.Add(this.UseConfiguration);
            this.tabPage_Sql.Controls.Add(this.label15);
            this.tabPage_Sql.Controls.Add(this.queryText);
            this.tabPage_Sql.Controls.Add(this.warehouse);
            this.tabPage_Sql.Controls.Add(this.label14);
            this.tabPage_Sql.Controls.Add(this.password);
            this.tabPage_Sql.Controls.Add(this.IPAddressPort);
            this.tabPage_Sql.Controls.Add(this.label12);
            this.tabPage_Sql.Controls.Add(this.userName);
            this.tabPage_Sql.Controls.Add(this.label13);
            this.tabPage_Sql.Controls.Add(this.label11);
            this.tabPage_Sql.Controls.Add(this.IPAddress);
            this.tabPage_Sql.Controls.Add(this.label10);
            this.tabPage_Sql.Controls.Add(this.label9);
            this.tabPage_Sql.Controls.Add(this.resultFilePathForSQL);
            this.tabPage_Sql.Controls.Add(this.comboBoxSQLType);
            this.tabPage_Sql.Controls.Add(this.label6);
            this.tabPage_Sql.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Sql.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Sql.Name = "tabPage_Sql";
            this.tabPage_Sql.Size = new System.Drawing.Size(701, 423);
            this.tabPage_Sql.TabIndex = 2;
            this.tabPage_Sql.Text = "数据库";
            this.tabPage_Sql.UseVisualStyleBackColor = true;
            // 
            // UseConfiguration
            // 
            this.UseConfiguration.AutoSize = true;
            this.UseConfiguration.Checked = true;
            this.UseConfiguration.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseConfiguration.Location = new System.Drawing.Point(405, 16);
            this.UseConfiguration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UseConfiguration.Name = "UseConfiguration";
            this.UseConfiguration.Size = new System.Drawing.Size(276, 16);
            this.UseConfiguration.TabIndex = 27;
            this.UseConfiguration.Text = "使用配置信息登录(文本输入登录时需取消勾选)";
            this.UseConfiguration.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 145);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 12);
            this.label15.TabIndex = 26;
            this.label15.Text = "查询语句:";
            // 
            // queryText
            // 
            this.queryText.AcceptsReturn = true;
            this.queryText.Location = new System.Drawing.Point(101, 143);
            this.queryText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.queryText.Multiline = true;
            this.queryText.Name = "queryText";
            this.queryText.Size = new System.Drawing.Size(585, 194);
            this.queryText.TabIndex = 25;
            this.queryText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
            // 
            // warehouse
            // 
            this.warehouse.Location = new System.Drawing.Point(101, 107);
            this.warehouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.warehouse.Name = "warehouse";
            this.warehouse.Size = new System.Drawing.Size(262, 21);
            this.warehouse.TabIndex = 24;
            this.warehouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 108);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 12);
            this.label14.TabIndex = 23;
            this.label14.Text = "数据库名称:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(467, 76);
            this.password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(219, 21);
            this.password.TabIndex = 22;
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
            // 
            // IPAddressPort
            // 
            this.IPAddressPort.Location = new System.Drawing.Point(467, 45);
            this.IPAddressPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IPAddressPort.Name = "IPAddressPort";
            this.IPAddressPort.Size = new System.Drawing.Size(219, 21);
            this.IPAddressPort.TabIndex = 21;
            this.IPAddressPort.Text = "3306";
            this.IPAddressPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(403, 77);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 20;
            this.label12.Text = "密  码:";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(101, 76);
            this.userName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(262, 21);
            this.userName.TabIndex = 19;
            this.userName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 77);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 18;
            this.label13.Text = "用户名:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(403, 47);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "端  口:";
            // 
            // IPAddress
            // 
            this.IPAddress.Location = new System.Drawing.Point(101, 45);
            this.IPAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(262, 21);
            this.IPAddress.TabIndex = 15;
            this.IPAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 47);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "IP地址:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "数据库类型:";
            // 
            // resultFilePathForSQL
            // 
            this.resultFilePathForSQL.AutoSize = true;
            this.resultFilePathForSQL.Location = new System.Drawing.Point(99, 355);
            this.resultFilePathForSQL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultFilePathForSQL.Name = "resultFilePathForSQL";
            this.resultFilePathForSQL.Size = new System.Drawing.Size(53, 12);
            this.resultFilePathForSQL.TabIndex = 12;
            this.resultFilePathForSQL.TabStop = true;
            this.resultFilePathForSQL.Text = "结果路径";
            this.resultFilePathForSQL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelOpenFile_LinkClicked);
            // 
            // comboBoxSQLType
            // 
            this.comboBoxSQLType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSQLType.FormattingEnabled = true;
            this.comboBoxSQLType.Items.AddRange(new object[] {
            "MySQL",
            "PostgreSQL"});
            this.comboBoxSQLType.Location = new System.Drawing.Point(101, 15);
            this.comboBoxSQLType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSQLType.Name = "comboBoxSQLType";
            this.comboBoxSQLType.Size = new System.Drawing.Size(262, 20);
            this.comboBoxSQLType.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 355);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "结果路径:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pProgressBar,
            this.timeTips});
            this.statusStrip1.Location = new System.Drawing.Point(0, 554);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(709, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pProgressBar
            // 
            this.pProgressBar.Name = "pProgressBar";
            this.pProgressBar.Size = new System.Drawing.Size(333, 16);
            this.pProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // timeTips
            // 
            this.timeTips.Name = "timeTips";
            this.timeTips.Size = new System.Drawing.Size(0, 17);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "\"文本文件|*.txt;*.csv\"";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "文本文件|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(709, 576);
            this.Controls.Add(this.tabControlInputType);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "分词统计工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControlInputType.ResumeLayout(false);
            this.tabPage_Text.ResumeLayout(false);
            this.tabPage_Text.PerformLayout();
            this.tabPage_File.ResumeLayout(false);
            this.tabPage_File.PerformLayout();
            this.tabPage_Sql.ResumeLayout(false);
            this.tabPage_Sql.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioWordCount;
        private System.Windows.Forms.RadioButton radioWordSplit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btDefaultDictsFilePath;
        private System.Windows.Forms.Button btStopWordsFilePath;
        private System.Windows.Forms.TextBox defaultDictsFilePath;
        private System.Windows.Forms.TextBox stopWordsFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlInputType;
        private System.Windows.Forms.TabPage tabPage_Text;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TabPage tabPage_Sql;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage_File;
        private System.Windows.Forms.Button btInputFile;
        private System.Windows.Forms.TextBox inputFilePath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxSQLType;
        private System.Windows.Forms.LinkLabel resultFilePathForSQL;
        private System.Windows.Forms.LinkLabel resultFilePathForFile;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox queryText;
        private System.Windows.Forms.TextBox warehouse;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox IPAddressPort;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox IPAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.CheckBox UseConfiguration;
        private System.Windows.Forms.ToolStripProgressBar pProgressBar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBoxCutMode;
        private System.Windows.Forms.ToolStripStatusLabel timeTips;
    }
}

