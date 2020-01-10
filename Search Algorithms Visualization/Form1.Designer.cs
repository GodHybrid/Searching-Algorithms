namespace Search_Algorithms_Visualization
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depthfirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breadthfirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestfirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTimeElapsed = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCheckedSquares = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPathLength = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBarSpeedUpd = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanelPauseStop = new System.Windows.Forms.TableLayoutPanel();
            this.buttonStartPause = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.trackSizeCtrl = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeedUpd)).BeginInit();
            this.tableLayoutPanelPauseStop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSizeCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchWithToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchWithToolStripMenuItem
            // 
            this.searchWithToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.depthfirstToolStripMenuItem,
            this.breadthfirstToolStripMenuItem,
            this.bestfirstToolStripMenuItem});
            this.searchWithToolStripMenuItem.Name = "searchWithToolStripMenuItem";
            this.searchWithToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.searchWithToolStripMenuItem.Text = "Search with...";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.aToolStripMenuItem.Text = "A*";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // depthfirstToolStripMenuItem
            // 
            this.depthfirstToolStripMenuItem.Name = "depthfirstToolStripMenuItem";
            this.depthfirstToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.depthfirstToolStripMenuItem.Text = "Depth-first";
            this.depthfirstToolStripMenuItem.Click += new System.EventHandler(this.depthfirstToolStripMenuItem_Click);
            // 
            // breadthfirstToolStripMenuItem
            // 
            this.breadthfirstToolStripMenuItem.Name = "breadthfirstToolStripMenuItem";
            this.breadthfirstToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.breadthfirstToolStripMenuItem.Text = "Breadth-first";
            this.breadthfirstToolStripMenuItem.Click += new System.EventHandler(this.breadthfirstToolStripMenuItem_Click);
            // 
            // bestfirstToolStripMenuItem
            // 
            this.bestfirstToolStripMenuItem.Name = "bestfirstToolStripMenuItem";
            this.bestfirstToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.bestfirstToolStripMenuItem.Text = "Best-first";
            this.bestfirstToolStripMenuItem.Click += new System.EventHandler(this.bestfirstToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTimeElapsed,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabelCheckedSquares,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabelPathLength,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(936, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTimeElapsed
            // 
            this.toolStripStatusLabelTimeElapsed.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripStatusLabelTimeElapsed.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelTimeElapsed.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabelTimeElapsed.Name = "toolStripStatusLabelTimeElapsed";
            this.toolStripStatusLabelTimeElapsed.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripStatusLabelTimeElapsed.Size = new System.Drawing.Size(57, 19);
            this.toolStripStatusLabelTimeElapsed.Text = "Time";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(23, 19);
            this.toolStripStatusLabel5.Text = "ms";
            // 
            // toolStripStatusLabelCheckedSquares
            // 
            this.toolStripStatusLabelCheckedSquares.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripStatusLabelCheckedSquares.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelCheckedSquares.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabelCheckedSquares.Name = "toolStripStatusLabelCheckedSquares";
            this.toolStripStatusLabelCheckedSquares.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripStatusLabelCheckedSquares.Size = new System.Drawing.Size(77, 19);
            this.toolStripStatusLabelCheckedSquares.Text = "Checked";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(28, 19);
            this.toolStripStatusLabel6.Text = "sqrs";
            // 
            // toolStripStatusLabelPathLength
            // 
            this.toolStripStatusLabelPathLength.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripStatusLabelPathLength.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelPathLength.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabelPathLength.Name = "toolStripStatusLabelPathLength";
            this.toolStripStatusLabelPathLength.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripStatusLabelPathLength.Size = new System.Drawing.Size(92, 19);
            this.toolStripStatusLabelPathLength.Text = "Path length";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(28, 19);
            this.toolStripStatusLabel7.Text = "sqrs";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripStatusLabel8.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel8.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.toolStripStatusLabel8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(6, 19);
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripStatusLabelStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(610, 19);
            this.toolStripStatusLabelStatus.Spring = true;
            this.toolStripStatusLabelStatus.Text = "Status";
            this.toolStripStatusLabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(936, 394);
            this.tableLayoutPanelMain.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBarSpeedUpd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tableLayoutPanelPauseStop);
            this.groupBox1.Controls.Add(this.trackSizeCtrl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(705, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 388);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Field Control";
            // 
            // trackBarSpeedUpd
            // 
            this.trackBarSpeedUpd.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarSpeedUpd.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBarSpeedUpd.Location = new System.Drawing.Point(3, 87);
            this.trackBarSpeedUpd.Name = "trackBarSpeedUpd";
            this.trackBarSpeedUpd.Size = new System.Drawing.Size(222, 45);
            this.trackBarSpeedUpd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Update tempo:";
            // 
            // tableLayoutPanelPauseStop
            // 
            this.tableLayoutPanelPauseStop.ColumnCount = 2;
            this.tableLayoutPanelPauseStop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPauseStop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelPauseStop.Controls.Add(this.buttonStartPause, 0, 0);
            this.tableLayoutPanelPauseStop.Controls.Add(this.buttonStop, 1, 0);
            this.tableLayoutPanelPauseStop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelPauseStop.Location = new System.Drawing.Point(3, 340);
            this.tableLayoutPanelPauseStop.Name = "tableLayoutPanelPauseStop";
            this.tableLayoutPanelPauseStop.RowCount = 1;
            this.tableLayoutPanelPauseStop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPauseStop.Size = new System.Drawing.Size(222, 45);
            this.tableLayoutPanelPauseStop.TabIndex = 2;
            // 
            // buttonStartPause
            // 
            this.buttonStartPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStartPause.Location = new System.Drawing.Point(3, 3);
            this.buttonStartPause.Name = "buttonStartPause";
            this.buttonStartPause.Size = new System.Drawing.Size(105, 39);
            this.buttonStartPause.TabIndex = 0;
            this.buttonStartPause.Text = "Start";
            this.buttonStartPause.UseVisualStyleBackColor = true;
            this.buttonStartPause.Click += new System.EventHandler(this.buttonStartPause_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStop.Location = new System.Drawing.Point(114, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(105, 39);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop and reset";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // trackSizeCtrl
            // 
            this.trackSizeCtrl.BackColor = System.Drawing.SystemColors.Control;
            this.trackSizeCtrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackSizeCtrl.Location = new System.Drawing.Point(3, 29);
            this.trackSizeCtrl.Minimum = 1;
            this.trackSizeCtrl.Name = "trackSizeCtrl";
            this.trackSizeCtrl.Size = new System.Drawing.Size(222, 45);
            this.trackSizeCtrl.SmallChange = 2;
            this.trackSizeCtrl.TabIndex = 1;
            this.trackSizeCtrl.Value = 1;
            this.trackSizeCtrl.ValueChanged += new System.EventHandler(this.trackSizeCtrl_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(696, 388);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(936, 442);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Search Algorithms v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeedUpd)).EndInit();
            this.tableLayoutPanelPauseStop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackSizeCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTimeElapsed;
        private System.Windows.Forms.ToolStripMenuItem depthfirstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breadthfirstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestfirstToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackSizeCtrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPauseStop;
        private System.Windows.Forms.Button buttonStartPause;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TrackBar trackBarSpeedUpd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCheckedSquares;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPathLength;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

