
namespace WinBrowser
{
    partial class WinBrowser
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
            this.pnlBrowserTop = new System.Windows.Forms.Panel();
            this.pnlFlowLayoutBrowserWindowButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pnlFlowLayoutBrowserNav = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSearchEngine = new System.Windows.Forms.Label();
            this.cmbSearchEngine = new System.Windows.Forms.ComboBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btnSeach = new System.Windows.Forms.Button();
            this.pnlBrowser = new System.Windows.Forms.Panel();
            this.pnlBrowserTop.SuspendLayout();
            this.pnlFlowLayoutBrowserWindowButtons.SuspendLayout();
            this.pnlFlowLayoutBrowserNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBrowserTop
            // 
            this.pnlBrowserTop.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlBrowserTop.Controls.Add(this.pnlFlowLayoutBrowserWindowButtons);
            this.pnlBrowserTop.Controls.Add(this.pnlFlowLayoutBrowserNav);
            this.pnlBrowserTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBrowserTop.Location = new System.Drawing.Point(0, 0);
            this.pnlBrowserTop.Name = "pnlBrowserTop";
            this.pnlBrowserTop.Size = new System.Drawing.Size(1202, 28);
            this.pnlBrowserTop.TabIndex = 0;
            // 
            // pnlFlowLayoutBrowserWindowButtons
            // 
            this.pnlFlowLayoutBrowserWindowButtons.Controls.Add(this.btnClose);
            this.pnlFlowLayoutBrowserWindowButtons.Controls.Add(this.btnMaximize);
            this.pnlFlowLayoutBrowserWindowButtons.Controls.Add(this.btnMinimize);
            this.pnlFlowLayoutBrowserWindowButtons.Controls.Add(this.btnAbout);
            this.pnlFlowLayoutBrowserWindowButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFlowLayoutBrowserWindowButtons.Location = new System.Drawing.Point(1059, 0);
            this.pnlFlowLayoutBrowserWindowButtons.Name = "pnlFlowLayoutBrowserWindowButtons";
            this.pnlFlowLayoutBrowserWindowButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlFlowLayoutBrowserWindowButtons.Size = new System.Drawing.Size(143, 28);
            this.pnlFlowLayoutBrowserWindowButtons.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.Location = new System.Drawing.Point(118, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 22);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMaximize.Location = new System.Drawing.Point(90, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(22, 22);
            this.btnMaximize.TabIndex = 6;
            this.btnMaximize.Text = "M";
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMinimize.Location = new System.Drawing.Point(62, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 22);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(4, 3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(52, 22);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Visible = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pnlFlowLayoutBrowserNav
            // 
            this.pnlFlowLayoutBrowserNav.Controls.Add(this.lblSearchEngine);
            this.pnlFlowLayoutBrowserNav.Controls.Add(this.cmbSearchEngine);
            this.pnlFlowLayoutBrowserNav.Controls.Add(this.btnPrevious);
            this.pnlFlowLayoutBrowserNav.Controls.Add(this.btnNext);
            this.pnlFlowLayoutBrowserNav.Controls.Add(this.txtSearchBox);
            this.pnlFlowLayoutBrowserNav.Controls.Add(this.btnSeach);
            this.pnlFlowLayoutBrowserNav.Location = new System.Drawing.Point(0, 0);
            this.pnlFlowLayoutBrowserNav.Name = "pnlFlowLayoutBrowserNav";
            this.pnlFlowLayoutBrowserNav.Size = new System.Drawing.Size(874, 28);
            this.pnlFlowLayoutBrowserNav.TabIndex = 1;
            // 
            // lblSearchEngine
            // 
            this.lblSearchEngine.AutoSize = true;
            this.lblSearchEngine.Location = new System.Drawing.Point(3, 0);
            this.lblSearchEngine.Name = "lblSearchEngine";
            this.lblSearchEngine.Padding = new System.Windows.Forms.Padding(2, 6, 0, 0);
            this.lblSearchEngine.Size = new System.Drawing.Size(85, 19);
            this.lblSearchEngine.TabIndex = 0;
            this.lblSearchEngine.Text = "Search Engine :";
            // 
            // cmbSearchEngine
            // 
            this.cmbSearchEngine.FormattingEnabled = true;
            this.cmbSearchEngine.ItemHeight = 13;
            this.cmbSearchEngine.Items.AddRange(new object[] {
            "Google",
            "Bing",
            "Yahoo",
            "DuckDuckGo"});
            this.cmbSearchEngine.Location = new System.Drawing.Point(94, 3);
            this.cmbSearchEngine.Name = "cmbSearchEngine";
            this.cmbSearchEngine.Size = new System.Drawing.Size(88, 21);
            this.cmbSearchEngine.TabIndex = 1;
            this.cmbSearchEngine.Text = "DuckDuckGo";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(188, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(35, 22);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(229, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 22);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchBox.Location = new System.Drawing.Point(270, 4);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(540, 20);
            this.txtSearchBox.TabIndex = 0;
            this.txtSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchBox_KeyDown);
            // 
            // btnSeach
            // 
            this.btnSeach.Location = new System.Drawing.Point(816, 3);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(52, 22);
            this.btnSeach.TabIndex = 4;
            this.btnSeach.Text = "Search";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // pnlBrowser
            // 
            this.pnlBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBrowser.Location = new System.Drawing.Point(0, 28);
            this.pnlBrowser.Name = "pnlBrowser";
            this.pnlBrowser.Size = new System.Drawing.Size(1202, 556);
            this.pnlBrowser.TabIndex = 1;
            // 
            // WinBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1202, 584);
            this.Controls.Add(this.pnlBrowser);
            this.Controls.Add(this.pnlBrowserTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "WinBrowser";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinBrowser";
            this.pnlBrowserTop.ResumeLayout(false);
            this.pnlFlowLayoutBrowserWindowButtons.ResumeLayout(false);
            this.pnlFlowLayoutBrowserNav.ResumeLayout(false);
            this.pnlFlowLayoutBrowserNav.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBrowserTop;
        private System.Windows.Forms.Panel pnlBrowser;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.FlowLayoutPanel pnlFlowLayoutBrowserNav;
        private System.Windows.Forms.Label lblSearchEngine;
        private System.Windows.Forms.ComboBox cmbSearchEngine;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.FlowLayoutPanel pnlFlowLayoutBrowserWindowButtons;
        private System.Windows.Forms.Button btnAbout;
    }
}

