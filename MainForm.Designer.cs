
namespace Emgu_Test
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.videoPictureBox = new System.Windows.Forms.PictureBox();
			this.logListBox = new System.Windows.Forms.ListBox();
			this.processVideoButton = new System.Windows.Forms.Button();
			this.videoPropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.processFrameButton = new System.Windows.Forms.Button();
			this.frameTrackBar = new System.Windows.Forms.TrackBar();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.videoPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.frameTrackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1043, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "mp4 files (*.mp4)|*.mp4|All files (*.*)|*.*";
			// 
			// videoPictureBox
			// 
			this.videoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.videoPictureBox.Location = new System.Drawing.Point(10, 23);
			this.videoPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.videoPictureBox.Name = "videoPictureBox";
			this.videoPictureBox.Size = new System.Drawing.Size(789, 557);
			this.videoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.videoPictureBox.TabIndex = 1;
			this.videoPictureBox.TabStop = false;
			// 
			// logListBox
			// 
			this.logListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.logListBox.FormattingEnabled = true;
			this.logListBox.ItemHeight = 15;
			this.logListBox.Location = new System.Drawing.Point(12, 623);
			this.logListBox.Name = "logListBox";
			this.logListBox.Size = new System.Drawing.Size(1019, 94);
			this.logListBox.TabIndex = 2;
			// 
			// processVideoButton
			// 
			this.processVideoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.processVideoButton.Location = new System.Drawing.Point(10, 585);
			this.processVideoButton.Name = "processVideoButton";
			this.processVideoButton.Size = new System.Drawing.Size(97, 23);
			this.processVideoButton.TabIndex = 3;
			this.processVideoButton.Text = "Process Video";
			this.processVideoButton.UseVisualStyleBackColor = true;
			this.processVideoButton.Click += new System.EventHandler(this.processVideoButton_Click);
			// 
			// videoPropertyGrid
			// 
			this.videoPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.videoPropertyGrid.Location = new System.Drawing.Point(805, 27);
			this.videoPropertyGrid.Name = "videoPropertyGrid";
			this.videoPropertyGrid.Size = new System.Drawing.Size(226, 590);
			this.videoPropertyGrid.TabIndex = 4;
			this.videoPropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.videoPropertyGrid_PropertyValueChanged);
			// 
			// processFrameButton
			// 
			this.processFrameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.processFrameButton.Location = new System.Drawing.Point(115, 585);
			this.processFrameButton.Name = "processFrameButton";
			this.processFrameButton.Size = new System.Drawing.Size(94, 23);
			this.processFrameButton.TabIndex = 5;
			this.processFrameButton.Text = "Process Frame";
			this.processFrameButton.UseVisualStyleBackColor = true;
			this.processFrameButton.Click += new System.EventHandler(this.processFrameButton_Click);
			// 
			// frameTrackBar
			// 
			this.frameTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.frameTrackBar.AutoSize = false;
			this.frameTrackBar.Enabled = false;
			this.frameTrackBar.Location = new System.Drawing.Point(215, 585);
			this.frameTrackBar.Maximum = 100;
			this.frameTrackBar.Name = "frameTrackBar";
			this.frameTrackBar.Size = new System.Drawing.Size(584, 32);
			this.frameTrackBar.TabIndex = 6;
			this.frameTrackBar.Scroll += new System.EventHandler(this.frameTrackBar_Scroll);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1043, 729);
			this.Controls.Add(this.frameTrackBar);
			this.Controls.Add(this.processFrameButton);
			this.Controls.Add(this.videoPropertyGrid);
			this.Controls.Add(this.processVideoButton);
			this.Controls.Add(this.logListBox);
			this.Controls.Add(this.videoPictureBox);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Text = "Video Processing Test";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.videoPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.frameTrackBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox videoPictureBox;
		private System.Windows.Forms.ListBox logListBox;
		private System.Windows.Forms.Button processVideoButton;
		private System.Windows.Forms.PropertyGrid videoPropertyGrid;
		private System.Windows.Forms.Button processFrameButton;
		private System.Windows.Forms.TrackBar frameTrackBar;
	}
}

