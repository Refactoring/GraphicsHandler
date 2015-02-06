namespace GraphicsHandler
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GHStatusStrip = new System.Windows.Forms.StatusStrip();
            this.GHToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.GHToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.GHToolStripStatusLabelProcessNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.GHToolStripStatusLabelFilesSum = new System.Windows.Forms.ToolStripStatusLabel();
            this.GHMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GHSplitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GHTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GHButtonSourcePath = new System.Windows.Forms.Button();
            this.GHbuttonActionConvert = new System.Windows.Forms.Button();
            this.GHButtonOutPutPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GHTextBoxOutPutPath = new System.Windows.Forms.TextBox();
            this.GHTextBoxSourcePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GHTrackBarQualityNumber = new System.Windows.Forms.TrackBar();
            this.GHComboBoxWidthAndHeight = new System.Windows.Forms.ComboBox();
            this.GHTextBoxQualityNumber = new System.Windows.Forms.TextBox();
            this.GHTextBoxWidthAndHeight = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GHTextBoxErrorData = new System.Windows.Forms.TextBox();
            this.GHFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.GHTimer = new System.Windows.Forms.Timer(this.components);
            this.GHStatusStrip.SuspendLayout();
            this.GHMenuStrip.SuspendLayout();
            this.GHSplitContainer.Panel1.SuspendLayout();
            this.GHSplitContainer.Panel2.SuspendLayout();
            this.GHSplitContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GHTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GHTrackBarQualityNumber)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GHStatusStrip
            // 
            this.GHStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            //this.GHToolStripProgressBar,
            this.GHToolStripStatusLabel,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.GHToolStripStatusLabelProcessNum,
            this.GHToolStripStatusLabelFilesSum});
            this.GHStatusStrip.Location = new System.Drawing.Point(0, 251);
            this.GHStatusStrip.Name = "GHStatusStrip";
            this.GHStatusStrip.Size = new System.Drawing.Size(481, 22);
            this.GHStatusStrip.TabIndex = 0;
            this.GHStatusStrip.Text = "GHStatusStrip";
            // 
            // GHToolStripProgressBar
            // 
            this.GHToolStripProgressBar.Name = "GHToolStripProgressBar";
            this.GHToolStripProgressBar.Size = new System.Drawing.Size(200, 16);
            this.GHToolStripProgressBar.Step = 1;
            // 
            // GHToolStripStatusLabel
            // 
            this.GHToolStripStatusLabel.Name = "GHToolStripStatusLabel";
            this.GHToolStripStatusLabel.Size = new System.Drawing.Size(11, 17);
            this.GHToolStripStatusLabel.Text = "";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel2.Text = "";
            // 
            // GHToolStripStatusLabelProcessNum
            // 
            this.GHToolStripStatusLabelProcessNum.Name = "GHToolStripStatusLabelProcessNum";
            this.GHToolStripStatusLabelProcessNum.Size = new System.Drawing.Size(11, 17);
            this.GHToolStripStatusLabelProcessNum.Text = ".";
            // 
            // GHToolStripStatusLabelFilesSum
            // 
            this.GHToolStripStatusLabelFilesSum.Name = "GHToolStripStatusLabelFilesSum";
            this.GHToolStripStatusLabelFilesSum.Size = new System.Drawing.Size(11, 17);
            this.GHToolStripStatusLabelFilesSum.Text = ".";
            // 
            // GHMenuStrip
            // 
            this.GHMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.GHMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.GHMenuStrip.Name = "GHMenuStrip";
            this.GHMenuStrip.Size = new System.Drawing.Size(481, 24);
            this.GHMenuStrip.TabIndex = 1;
            this.GHMenuStrip.Text = "GHMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // GHSplitContainer
            // 
            this.GHSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GHSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.GHSplitContainer.Name = "GHSplitContainer";
            this.GHSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // GHSplitContainer.Panel1
            // 
            this.GHSplitContainer.Panel1.Controls.Add(this.groupBox1);
            // 
            // GHSplitContainer.Panel2
            // 
            this.GHSplitContainer.Panel2.AutoScroll = true;
            this.GHSplitContainer.Panel2.Controls.Add(this.groupBox2);
            this.GHSplitContainer.Size = new System.Drawing.Size(481, 227);
            this.GHSplitContainer.SplitterDistance = 147;
            this.GHSplitContainer.SplitterIncrement = 2;
            this.GHSplitContainer.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.GHTableLayoutPanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // GHTableLayoutPanel
            // 
            this.GHTableLayoutPanel.AutoSize = true;
            this.GHTableLayoutPanel.ColumnCount = 3;
            this.GHTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.79292F));
            this.GHTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.20708F));
            this.GHTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.GHTableLayoutPanel.Controls.Add(this.GHButtonSourcePath, 2, 0);
            this.GHTableLayoutPanel.Controls.Add(this.GHbuttonActionConvert, 2, 4);
            this.GHTableLayoutPanel.Controls.Add(this.GHButtonOutPutPath, 2, 1);
            this.GHTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.GHTableLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.GHTableLayoutPanel.Controls.Add(this.GHTextBoxOutPutPath, 1, 1);
            this.GHTableLayoutPanel.Controls.Add(this.GHTextBoxSourcePath, 1, 0);
            this.GHTableLayoutPanel.Controls.Add(this.label3, 0, 2);
            this.GHTableLayoutPanel.Controls.Add(this.label4, 0, 3);
            this.GHTableLayoutPanel.Controls.Add(this.GHTrackBarQualityNumber, 1, 2);
            this.GHTableLayoutPanel.Controls.Add(this.GHComboBoxWidthAndHeight, 1, 3);
            this.GHTableLayoutPanel.Controls.Add(this.GHTextBoxQualityNumber, 2, 2);
            this.GHTableLayoutPanel.Controls.Add(this.GHTextBoxWidthAndHeight, 2, 3);
            this.GHTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GHTableLayoutPanel.Location = new System.Drawing.Point(3, 17);
            this.GHTableLayoutPanel.Name = "GHTableLayoutPanel";
            this.GHTableLayoutPanel.RowCount = 5;
            this.GHTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.GHTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.GHTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.GHTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.GHTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.GHTableLayoutPanel.Size = new System.Drawing.Size(475, 127);
            this.GHTableLayoutPanel.TabIndex = 5;
            // 
            // GHButtonSourcePath
            // 
            this.GHButtonSourcePath.Location = new System.Drawing.Point(361, 3);
            this.GHButtonSourcePath.Name = "GHButtonSourcePath";
            this.GHButtonSourcePath.Size = new System.Drawing.Size(19, 19);
            this.GHButtonSourcePath.TabIndex = 0;
            this.GHButtonSourcePath.Text = "..";
            this.GHButtonSourcePath.UseVisualStyleBackColor = true;
            this.GHButtonSourcePath.Click += new System.EventHandler(this.GHButtonSourcePathClick);
            // 
            // GHbuttonActionConvert
            // 
            this.GHbuttonActionConvert.Location = new System.Drawing.Point(361, 103);
            this.GHbuttonActionConvert.Name = "GHbuttonActionConvert";
            this.GHbuttonActionConvert.Size = new System.Drawing.Size(66, 21);
            this.GHbuttonActionConvert.TabIndex = 12;
            this.GHbuttonActionConvert.Text = "开始转换";
            this.GHbuttonActionConvert.UseVisualStyleBackColor = true;
            this.GHbuttonActionConvert.Click += new System.EventHandler(this.GHbuttonActionConvertClick);
            // 
            // GHButtonOutPutPath
            // 
            this.GHButtonOutPutPath.Location = new System.Drawing.Point(361, 28);
            this.GHButtonOutPutPath.Name = "GHButtonOutPutPath";
            this.GHButtonOutPutPath.Size = new System.Drawing.Size(19, 19);
            this.GHButtonOutPutPath.TabIndex = 1;
            this.GHButtonOutPutPath.Text = ".";
            this.GHButtonOutPutPath.UseVisualStyleBackColor = true;
            this.GHButtonOutPutPath.Click += new System.EventHandler(this.GHButtonOutPutPathClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(25, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "图片源目录:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "图片输出目录:";
            // 
            // GHTextBoxOutPutPath
            // 
            this.GHTextBoxOutPutPath.Location = new System.Drawing.Point(102, 28);
            this.GHTextBoxOutPutPath.Name = "GHTextBoxOutPutPath";
            this.GHTextBoxOutPutPath.Size = new System.Drawing.Size(253, 21);
            this.GHTextBoxOutPutPath.TabIndex = 5;
            this.GHTextBoxOutPutPath.TextChanged += new System.EventHandler(this.GHTextBoxOutPutPathTextChanged);
            // 
            // GHTextBoxSourcePath
            // 
            this.GHTextBoxSourcePath.Location = new System.Drawing.Point(102, 3);
            this.GHTextBoxSourcePath.Name = "GHTextBoxSourcePath";
            this.GHTextBoxSourcePath.Size = new System.Drawing.Size(253, 21);
            this.GHTextBoxSourcePath.TabIndex = 4;
            this.GHTextBoxSourcePath.TextChanged += new System.EventHandler(this.GHTextBoxSourcePathTextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(13, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "JPEG压缩质量:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(25, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "输出宽高比:";
            // 
            // GHTrackBarQualityNumber
            // 
            this.GHTrackBarQualityNumber.LargeChange = 1;
            this.GHTrackBarQualityNumber.Location = new System.Drawing.Point(102, 53);
            this.GHTrackBarQualityNumber.Maximum = 100;
            this.GHTrackBarQualityNumber.Name = "GHTrackBarQualityNumber";
            this.GHTrackBarQualityNumber.Size = new System.Drawing.Size(253, 19);
            this.GHTrackBarQualityNumber.TabIndex = 8;
            this.GHTrackBarQualityNumber.Scroll += new System.EventHandler(this.GHTrackBarQualityNumberScroll);
            // 
            // GHComboBoxWidthAndHeight
            // 
            this.GHComboBoxWidthAndHeight.FormattingEnabled = true;
            this.GHComboBoxWidthAndHeight.Items.AddRange(new object[] {
            "80×100",
            "200×300"});
            this.GHComboBoxWidthAndHeight.Location = new System.Drawing.Point(102, 78);
            this.GHComboBoxWidthAndHeight.Name = "GHComboBoxWidthAndHeight";
            this.GHComboBoxWidthAndHeight.Size = new System.Drawing.Size(107, 20);
            this.GHComboBoxWidthAndHeight.TabIndex = 10;
            this.GHComboBoxWidthAndHeight.SelectedIndexChanged += new System.EventHandler(this.GHComboBoxWidthAndHeightSelectedIndexChanged);
            // 
            // GHTextBoxQualityNumber
            // 
            this.GHTextBoxQualityNumber.Location = new System.Drawing.Point(361, 53);
            this.GHTextBoxQualityNumber.Name = "GHTextBoxQualityNumber";
            this.GHTextBoxQualityNumber.Size = new System.Drawing.Size(97, 21);
            this.GHTextBoxQualityNumber.TabIndex = 9;
            this.GHTextBoxQualityNumber.TextChanged += new System.EventHandler(this.GHTextBoxQualityNumberTextChanged);
            // 
            // GHTextBoxWidthAndHeight
            // 
            this.GHTextBoxWidthAndHeight.Location = new System.Drawing.Point(361, 78);
            this.GHTextBoxWidthAndHeight.Name = "GHTextBoxWidthAndHeight";
            this.GHTextBoxWidthAndHeight.Size = new System.Drawing.Size(97, 21);
            this.GHTextBoxWidthAndHeight.TabIndex = 11;
            this.GHTextBoxWidthAndHeight.TextChanged += new System.EventHandler(this.GHTextBoxWidthAndHeight_Leave);
            this.GHTextBoxWidthAndHeight.Leave += new System.EventHandler(this.GHTextBoxWidthAndHeight_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GHTextBoxErrorData);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 76);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "转换信息";
            // 
            // GHTextBoxErrorData
            // 
            this.GHTextBoxErrorData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GHTextBoxErrorData.Location = new System.Drawing.Point(3, 17);
            this.GHTextBoxErrorData.Multiline = true;
            this.GHTextBoxErrorData.Name = "GHTextBoxErrorData";
            this.GHTextBoxErrorData.ReadOnly = true;
            this.GHTextBoxErrorData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GHTextBoxErrorData.Size = new System.Drawing.Size(475, 56);
            this.GHTextBoxErrorData.TabIndex = 1;
            // 
            // GHTimer
            // 
            this.GHTimer.Interval = 1000;
            this.GHTimer.Tick += new System.EventHandler(this.GHTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 273);
            this.Controls.Add(this.GHSplitContainer);
            this.Controls.Add(this.GHStatusStrip);
            this.Controls.Add(this.GHMenuStrip);
            this.MainMenuStrip = this.GHMenuStrip;
            this.Name = "MainForm1";
            this.Text = "GraphicsHandler";
            this.TextChanged += new System.EventHandler(this.GHTextBoxWidthAndHeight_Leave);
            this.GHStatusStrip.ResumeLayout(false);
            this.GHStatusStrip.PerformLayout();
            this.GHMenuStrip.ResumeLayout(false);
            this.GHMenuStrip.PerformLayout();
            this.GHSplitContainer.Panel1.ResumeLayout(false);
            this.GHSplitContainer.Panel1.PerformLayout();
            this.GHSplitContainer.Panel2.ResumeLayout(false);
            this.GHSplitContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GHTableLayoutPanel.ResumeLayout(false);
            this.GHTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GHTrackBarQualityNumber)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.FolderBrowserDialog GHFolderBrowserDialog;
        private System.Windows.Forms.TextBox GHTextBoxOutPutPath;
        private System.Windows.Forms.TextBox GHTextBoxSourcePath;
        private System.Windows.Forms.TrackBar GHTrackBarQualityNumber;
        private System.Windows.Forms.ComboBox GHComboBoxWidthAndHeight;
        private System.Windows.Forms.TextBox GHTextBoxQualityNumber;
        private System.Windows.Forms.TextBox GHTextBoxWidthAndHeight;
        private System.Windows.Forms.Button GHButtonOutPutPath;
        private System.Windows.Forms.Button GHButtonSourcePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel GHTableLayoutPanel;
        private System.Windows.Forms.SplitContainer GHSplitContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip GHMenuStrip;
        private System.Windows.Forms.ToolStripStatusLabel GHToolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar GHToolStripProgressBar;
        private System.Windows.Forms.StatusStrip GHStatusStrip;

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox GHTextBoxErrorData;
        private System.Windows.Forms.ToolStripStatusLabel GHToolStripStatusLabelProcessNum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer GHTimer;
        private System.Windows.Forms.ToolStripStatusLabel GHToolStripStatusLabelFilesSum;
        private System.Windows.Forms.Button GHbuttonActionConvert;

    }
}

