
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
            this.pnlBrowserTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBrowserTop.Name = "pnlBrowserTop";
            this.pnlBrowserTop.Size = new System.Drawing.Size(1803, 43);
            this.pnlBrowserTop.TabIndex = 0;
            // 
            // pnlFlowLayoutBrowserWindowButtons
            // 
            this.pnlFlowLayoutBrowserWindowButtons.Controls.Add(this.btnClose);
            this.pnlFlowLayoutBrowserWindowButtons.Controls.Add(this.btnMaximize);
            this.pnlFlowLayoutBrowserWindowButtons.Controls.Add(this.btnMinimize);
            this.pnlFlowLayoutBrowserWindowButtons.Controls.Add(this.btnAbout);
            this.pnlFlowLayoutBrowserWindowButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFlowLayoutBrowserWindowButtons.Location = new System.Drawing.Point(1589, 0);
            this.pnlFlowLayoutBrowserWindowButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFlowLayoutBrowserWindowButtons.Name = "pnlFlowLayoutBrowserWindowButtons";
            this.pnlFlowLayoutBrowserWindowButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlFlowLayoutBrowserWindowButtons.Size = new System.Drawing.Size(214, 43);
            this.pnlFlowLayoutBrowserWindowButtons.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.Location = new System.Drawing.Point(177, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 34);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMaximize.Location = new System.Drawing.Point(136, 5);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(33, 34);
            this.btnMaximize.TabIndex = 6;
            this.btnMaximize.Text = "M";
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMinimize.Location = new System.Drawing.Point(95, 5);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(33, 34);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(9, 5);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(78, 34);
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
            this.pnlFlowLayoutBrowserNav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFlowLayoutBrowserNav.Name = "pnlFlowLayoutBrowserNav";
            this.pnlFlowLayoutBrowserNav.Size = new System.Drawing.Size(1311, 43);
            this.pnlFlowLayoutBrowserNav.TabIndex = 1;
            // 
            // lblSearchEngine
            // 
            this.lblSearchEngine.AutoSize = true;
            this.lblSearchEngine.Location = new System.Drawing.Point(4, 0);
            this.lblSearchEngine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchEngine.Name = "lblSearchEngine";
            this.lblSearchEngine.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.lblSearchEngine.Size = new System.Drawing.Size(125, 29);
            this.lblSearchEngine.TabIndex = 0;
            this.lblSearchEngine.Text = "Search Engine :";
            // 
            // cmbSearchEngine
            // 
            this.cmbSearchEngine.FormattingEnabled = true;
            this.cmbSearchEngine.ItemHeight = 20;
            this.cmbSearchEngine.Items.AddRange(new object[] {
            "Google",
            "Bing",
            "Yahoo",
            "DuckDuckGo"});
            this.cmbSearchEngine.Location = new System.Drawing.Point(137, 5);
            this.cmbSearchEngine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSearchEngine.Name = "cmbSearchEngine";
            this.cmbSearchEngine.Size = new System.Drawing.Size(130, 28);
            this.cmbSearchEngine.TabIndex = 1;
            this.cmbSearchEngine.Text = "DuckDuckGo";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(275, 5);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(52, 34);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(335, 5);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(52, 34);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchBox.Location = new System.Drawing.Point(395, 6);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 5);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(591, 26);
            this.txtSearchBox.TabIndex = 0;
            this.txtSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchBox_KeyDown);
            // 
            // btnSeach
            // 
            this.btnSeach.Location = new System.Drawing.Point(994, 5);
            this.btnSeach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(78, 34);
            this.btnSeach.TabIndex = 4;
            this.btnSeach.Text = "Search";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // pnlBrowser
            // 
            this.pnlBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBrowser.Location = new System.Drawing.Point(0, 43);
            this.pnlBrowser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBrowser.Name = "pnlBrowser";
            this.pnlBrowser.Size = new System.Drawing.Size(1803, 855);
            this.pnlBrowser.TabIndex = 1;
            // 
            // WinBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1803, 898);
            this.Controls.Add(this.pnlBrowser);
            this.Controls.Add(this.pnlBrowserTop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WinBrowser";
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

