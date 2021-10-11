﻿
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
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exportAsXModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.videoPictureBox = new System.Windows.Forms.PictureBox();
			this.logListBox = new System.Windows.Forms.ListBox();
			this.processVideoButton = new System.Windows.Forms.Button();
			this.videoPropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.processFrameButton = new System.Windows.Forms.Button();
			this.frameTrackBar = new System.Windows.Forms.TrackBar();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.buttonStop = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageSettings = new System.Windows.Forms.TabPage();
			this.tabPageLights = new System.Windows.Forms.TabPage();
			this.dataGridViewLights = new System.Windows.Forms.DataGridView();
			this.xModelSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.videoPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.frameTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPageSettings.SuspendLayout();
			this.tabPageLights.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLights)).BeginInit();
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
			this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.exportAsXModelToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.openToolStripMenuItem.Text = "Load Video";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// exportAsXModelToolStripMenuItem
			// 
			this.exportAsXModelToolStripMenuItem.Name = "exportAsXModelToolStripMenuItem";
			this.exportAsXModelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exportAsXModelToolStripMenuItem.Text = "Export As xModel";
			this.exportAsXModelToolStripMenuItem.Click += new System.EventHandler(this.exportAsXModelToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
			this.videoPictureBox.Location = new System.Drawing.Point(3, 2);
			this.videoPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.videoPictureBox.Name = "videoPictureBox";
			this.videoPictureBox.Size = new System.Drawing.Size(792, 563);
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
			this.logListBox.Location = new System.Drawing.Point(12, 631);
			this.logListBox.Name = "logListBox";
			this.logListBox.Size = new System.Drawing.Size(998, 94);
			this.logListBox.TabIndex = 2;
			// 
			// processVideoButton
			// 
			this.processVideoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.processVideoButton.Location = new System.Drawing.Point(3, 570);
			this.processVideoButton.Name = "processVideoButton";
			this.processVideoButton.Size = new System.Drawing.Size(97, 23);
			this.processVideoButton.TabIndex = 3;
			this.processVideoButton.Text = "Process Video";
			this.processVideoButton.UseVisualStyleBackColor = true;
			this.processVideoButton.Click += new System.EventHandler(this.processVideoButton_Click);
			// 
			// videoPropertyGrid
			// 
			this.videoPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.videoPropertyGrid.Location = new System.Drawing.Point(3, 3);
			this.videoPropertyGrid.Name = "videoPropertyGrid";
			this.videoPropertyGrid.Size = new System.Drawing.Size(172, 562);
			this.videoPropertyGrid.TabIndex = 4;
			this.videoPropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.videoPropertyGrid_PropertyValueChanged);
			// 
			// processFrameButton
			// 
			this.processFrameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.processFrameButton.Location = new System.Drawing.Point(170, 570);
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
			this.frameTrackBar.Location = new System.Drawing.Point(270, 570);
			this.frameTrackBar.Maximum = 100;
			this.frameTrackBar.Name = "frameTrackBar";
			this.frameTrackBar.Size = new System.Drawing.Size(525, 23);
			this.frameTrackBar.TabIndex = 6;
			this.frameTrackBar.Scroll += new System.EventHandler(this.frameTrackBar_Scroll);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
			this.splitContainer1.Location = new System.Drawing.Point(12, 27);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.buttonStop);
			this.splitContainer1.Panel1.Controls.Add(this.videoPictureBox);
			this.splitContainer1.Panel1.Controls.Add(this.processVideoButton);
			this.splitContainer1.Panel1.Controls.Add(this.processFrameButton);
			this.splitContainer1.Panel1.Controls.Add(this.frameTrackBar);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer1.Size = new System.Drawing.Size(998, 598);
			this.splitContainer1.SplitterDistance = 800;
			this.splitContainer1.SplitterWidth = 10;
			this.splitContainer1.TabIndex = 7;
			// 
			// buttonStop
			// 
			this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonStop.Location = new System.Drawing.Point(106, 570);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(58, 23);
			this.buttonStop.TabIndex = 7;
			this.buttonStop.Text = "Stop";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageSettings);
			this.tabControl1.Controls.Add(this.tabPageLights);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(186, 596);
			this.tabControl1.TabIndex = 5;
			// 
			// tabPageSettings
			// 
			this.tabPageSettings.Controls.Add(this.videoPropertyGrid);
			this.tabPageSettings.Location = new System.Drawing.Point(4, 24);
			this.tabPageSettings.Name = "tabPageSettings";
			this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSettings.Size = new System.Drawing.Size(178, 568);
			this.tabPageSettings.TabIndex = 0;
			this.tabPageSettings.Text = "Settings";
			this.tabPageSettings.UseVisualStyleBackColor = true;
			// 
			// tabPageLights
			// 
			this.tabPageLights.Controls.Add(this.dataGridViewLights);
			this.tabPageLights.Location = new System.Drawing.Point(4, 24);
			this.tabPageLights.Name = "tabPageLights";
			this.tabPageLights.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageLights.Size = new System.Drawing.Size(180, 570);
			this.tabPageLights.TabIndex = 1;
			this.tabPageLights.Text = "Lights";
			this.tabPageLights.UseVisualStyleBackColor = true;
			// 
			// dataGridViewLights
			// 
			this.dataGridViewLights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewLights.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewLights.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridViewLights.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewLights.Name = "dataGridViewLights";
			this.dataGridViewLights.RowTemplate.Height = 25;
			this.dataGridViewLights.Size = new System.Drawing.Size(174, 564);
			this.dataGridViewLights.TabIndex = 0;
			// 
			// xModelSaveFileDialog
			// 
			this.xModelSaveFileDialog.DefaultExt = "xmodel";
			this.xModelSaveFileDialog.Filter = "xmodel files (*.xmodel)|*.xmodel|All files (*.*)|*.*";
			this.xModelSaveFileDialog.RestoreDirectory = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1022, 737);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.logListBox);
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
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPageSettings.ResumeLayout(false);
			this.tabPageLights.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLights)).EndInit();
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
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageSettings;
		private System.Windows.Forms.TabPage tabPageLights;
		private System.Windows.Forms.DataGridView dataGridViewLights;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exportAsXModelToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.SaveFileDialog xModelSaveFileDialog;
	}
}

