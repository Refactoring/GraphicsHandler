using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Threading;

namespace GraphicsHandler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private string m_OldRootPath;
        private string m_NewRootPath;
        private int m_Width;
        private int m_Height;
        private int m_QualityNumber;
        private List<String> m_ConvertErrorData = new List<string>();

        private GraphicsProcess gp;
        public Thread thread;

        #region 相关按钮事件处理函数
        void GHButtonSourcePathClick(object sender, EventArgs e)
        {
        	if(this.GHFolderBrowserDialog.ShowDialog() == DialogResult.OK)
        	{
        		this.GHTextBoxSourcePath.Text = this.GHFolderBrowserDialog.SelectedPath;
        	}
        }
        
        void GHButtonOutPutPathClick(object sender, EventArgs e)
        {
        	if(this.GHFolderBrowserDialog.ShowDialog() == DialogResult.OK)
        	{
        		this.GHTextBoxOutPutPath.Text = this.GHFolderBrowserDialog.SelectedPath;
        	}
        }
        
        void GHbuttonActionConvertClick(object sender, EventArgs e)
        {
            //this.groupBox1.Enabled = false;
            //this.gProcess = new GraphicsProcess(this.m_OldRootPath, this.m_NewRootPath,
            //    this.m_Width, this.m_Height, this.m_QualityNumber, ref this.m_ConvertErrorData);
            //this.GHTimer.Enabled = true;
            //this.thread = new Thread(new ThreadStart(this.gProcess.ActionGraphicsProcess));
            //thread.Start();

            this.groupBox1.Enabled = false;
            this.gp = new GraphicsProcess(this.m_OldRootPath, this.m_NewRootPath,
                this.m_Width, this.m_Height, this.m_QualityNumber, ref this.m_ConvertErrorData);
            this.GHTimer.Enabled = true;
            this.thread = new Thread(new ThreadStart(this.gp.ConvertProcess));
            thread.Start();
        }

        void ConvertEnd()
        {
            this.groupBox1.Enabled = true;
            this.GHToolStripProgressBar.Value = 0;
            this.GHToolStripStatusLabel.Text = "%";
            StringBuilder sb = new StringBuilder();
            sb.Append("转换完成.");
            if (this.m_ConvertErrorData.Count != 0)
            {
                sb.Append(Environment.NewLine);
                sb.Append("未成功转换的文件:"+this.m_ConvertErrorData.Count);
                sb.Append(Environment.NewLine);
                foreach (string str in this.m_ConvertErrorData)
                {
                    sb.Append(str.ToString());
                    sb.Append(Environment.NewLine);
                }
            }
            else
                sb.Append("全部转换成功.");
            this.GHTextBoxErrorData.Text = sb.ToString();
        }
        
        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
						if(this.thread != null && this.thread.ThreadState != ThreadState.Stopped )
							this.thread.Abort();
            Application.Exit();
        }
        
        void GHTextBoxSourcePathTextChanged(object sender, EventArgs e)
        {
        	this.m_OldRootPath = this.GHTextBoxSourcePath.Text;
        }
        
        void GHTextBoxOutPutPathTextChanged(object sender, EventArgs e)
        {
        	this.m_NewRootPath = this.GHTextBoxOutPutPath.Text;
        }
        
        void GHTrackBarQualityNumberScroll(object sender, EventArgs e)
        {
        	this.GHTextBoxQualityNumber.Text = this.GHTrackBarQualityNumber.Value.ToString();
        }
        
        void GHTextBoxQualityNumberTextChanged(object sender, EventArgs e)
        {
        	this.m_QualityNumber = Int32.Parse(this.GHTextBoxQualityNumber.Text);
        }
        
        void GHComboBoxWidthAndHeightSelectedIndexChanged(object sender, EventArgs e)
        {
        	this.GHTextBoxWidthAndHeight.Text = this.GHComboBoxWidthAndHeight.Items[this.GHComboBoxWidthAndHeight.SelectedIndex].ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox frmAbout = new AboutBox();
            frmAbout.ShowDialog(this);
        }

        private void GHTimer_Tick(object sender, EventArgs e)
        {
            if (GHTimer.Enabled == true)
            {
                //this.GHToolStripProgressBar.Value = this.gProcess.ConvertedPercent ;
                //this.GHToolStripStatusLabel.Text = this.gProcess.ConvertedPercent.ToString() + "%";
                this.GHToolStripStatusLabelProcessNum.Text = this.gp.Status + this.gp.ConvertedNumber.ToString();
                //this.GHToolStripStatusLabelFilesSum.Text = "/"+this.gProcess.ConvertFilesSum.ToString();

            }
            //if (this.gProcess.ConvertedNumber == this.gProcess.ConvertFilesSum && this.gProcess.ConvertedNumber != 0)
            //{
            //    this.ConvertEnd();
            //    this.GHTimer.Enabled = false;
            //}
        }

        private void GHTextBoxWidthAndHeight_Leave(object sender, EventArgs e)
        {
            if (this.GHTextBoxWidthAndHeight.Text.Length < 3)
                return;
            string[] strs = this.GHTextBoxWidthAndHeight.Text.Trim().Split(new char[] { '×', '*', ' ', ',' });
            this.m_Width = Int32.Parse(strs[0]);
            this.m_Height = Int32.Parse(strs[1]);
        }
        #endregion

    }
}
