namespace Auto_Keyboard
{
    partial class frmKryesore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKryesore));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.PositionsListView = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RemoveSelectedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remotefromfileMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SleepTimeLabel = new System.Windows.Forms.Label();
            this.numSleepTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnAddPositions = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chckSpace = new System.Windows.Forms.CheckBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chckEnter = new System.Windows.Forms.CheckBox();
            this.linkFkeys = new System.Windows.Forms.LinkLabel();
            this.linkbuymeacoffe = new System.Windows.Forms.LinkLabel();
            this.ctxNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.ListViewContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSleepTime)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.ctxNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnUP);
            this.groupBox1.Controls.Add(this.btnDown);
            this.groupBox1.Controls.Add(this.PositionsListView);
            this.groupBox1.Location = new System.Drawing.Point(11, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(220, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 22);
            this.label6.TabIndex = 53;
            this.label6.Text = "↕";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnUP
            // 
            this.btnUP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUP.Image = global::Auto_Keyboard.Properties.Resources.UPArrow;
            this.btnUP.Location = new System.Drawing.Point(219, 44);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(26, 68);
            this.btnUP.TabIndex = 52;
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnDown
            // 
            this.btnDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Image = global::Auto_Keyboard.Properties.Resources.DownArrow;
            this.btnDown.Location = new System.Drawing.Point(219, 118);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(26, 68);
            this.btnDown.TabIndex = 51;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // PositionsListView
            // 
            this.PositionsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.PositionsListView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.PositionsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PositionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnMessage});
            this.PositionsListView.ContextMenuStrip = this.ListViewContextMenu;
            this.PositionsListView.FullRowSelect = true;
            this.PositionsListView.GridLines = true;
            this.PositionsListView.HoverSelection = true;
            this.PositionsListView.Location = new System.Drawing.Point(3, 9);
            this.PositionsListView.MultiSelect = false;
            this.PositionsListView.Name = "PositionsListView";
            this.PositionsListView.ShowGroups = false;
            this.PositionsListView.ShowItemToolTips = true;
            this.PositionsListView.Size = new System.Drawing.Size(211, 177);
            this.PositionsListView.TabIndex = 5;
            this.PositionsListView.TileSize = new System.Drawing.Size(1, 1);
            this.PositionsListView.UseCompatibleStateImageBehavior = false;
            this.PositionsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Tag = "idja";
            this.columnID.Text = "#";
            this.columnID.Width = 0;
            // 
            // columnMessage
            // 
            this.columnMessage.Text = "Text";
            this.columnMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnMessage.Width = 210;
            // 
            // ListViewContextMenu
            // 
            this.ListViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveSelectedMenuItem,
            this.remotefromfileMenuItem1,
            this.RemoveAllMenuItem,
            this.upSelectedToolStripMenuItem,
            this.downToolStripMenuItem});
            this.ListViewContextMenu.Name = "ListViewContextMenu";
            this.ListViewContextMenu.Size = new System.Drawing.Size(167, 114);
            // 
            // RemoveSelectedMenuItem
            // 
            this.RemoveSelectedMenuItem.Image = global::Auto_Keyboard.Properties.Resources.deleselected;
            this.RemoveSelectedMenuItem.Name = "RemoveSelectedMenuItem";
            this.RemoveSelectedMenuItem.Size = new System.Drawing.Size(166, 22);
            this.RemoveSelectedMenuItem.Text = "Remove Selected";
            this.RemoveSelectedMenuItem.Click += new System.EventHandler(this.RemoveSelectedMenuItem_Click);
            // 
            // remotefromfileMenuItem1
            // 
            this.remotefromfileMenuItem1.Image = global::Auto_Keyboard.Properties.Resources.removefromlist;
            this.remotefromfileMenuItem1.Name = "remotefromfileMenuItem1";
            this.remotefromfileMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.remotefromfileMenuItem1.Text = "Remove from file";
            this.remotefromfileMenuItem1.Click += new System.EventHandler(this.remotefromfileMenuItem1_Click);
            // 
            // RemoveAllMenuItem
            // 
            this.RemoveAllMenuItem.Image = global::Auto_Keyboard.Properties.Resources.deleteAll;
            this.RemoveAllMenuItem.Name = "RemoveAllMenuItem";
            this.RemoveAllMenuItem.Size = new System.Drawing.Size(166, 22);
            this.RemoveAllMenuItem.Text = "Remove All Items";
            this.RemoveAllMenuItem.Click += new System.EventHandler(this.RemoveAllMenuItem_Click);
            // 
            // upSelectedToolStripMenuItem
            // 
            this.upSelectedToolStripMenuItem.Image = global::Auto_Keyboard.Properties.Resources.UP;
            this.upSelectedToolStripMenuItem.Name = "upSelectedToolStripMenuItem";
            this.upSelectedToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.upSelectedToolStripMenuItem.Text = "Up Selected";
            this.upSelectedToolStripMenuItem.Click += new System.EventHandler(this.upSelectedToolStripMenuItem_Click);
            // 
            // downToolStripMenuItem
            // 
            this.downToolStripMenuItem.Image = global::Auto_Keyboard.Properties.Resources.down;
            this.downToolStripMenuItem.Name = "downToolStripMenuItem";
            this.downToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.downToolStripMenuItem.Text = "Down Selected";
            this.downToolStripMenuItem.Click += new System.EventHandler(this.downToolStripMenuItem_Click);
            // 
            // SleepTimeLabel
            // 
            this.SleepTimeLabel.AutoSize = true;
            this.SleepTimeLabel.Location = new System.Drawing.Point(16, 51);
            this.SleepTimeLabel.Name = "SleepTimeLabel";
            this.SleepTimeLabel.Size = new System.Drawing.Size(37, 13);
            this.SleepTimeLabel.TabIndex = 46;
            this.SleepTimeLabel.Text = "Sleep:";
            // 
            // numSleepTime
            // 
            this.numSleepTime.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numSleepTime.Location = new System.Drawing.Point(42, 48);
            this.numSleepTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSleepTime.Name = "numSleepTime";
            this.numSleepTime.Size = new System.Drawing.Size(100, 20);
            this.numSleepTime.TabIndex = 45;
            this.numSleepTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSleepTime.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Text:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(42, 16);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(100, 20);
            this.txtMessage.TabIndex = 48;
            // 
            // btnAddPositions
            // 
            this.btnAddPositions.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPositions.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddPositions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPositions.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddPositions.Location = new System.Drawing.Point(154, 14);
            this.btnAddPositions.Name = "btnAddPositions";
            this.btnAddPositions.Size = new System.Drawing.Size(43, 25);
            this.btnAddPositions.TabIndex = 49;
            this.btnAddPositions.Text = "&Add";
            this.btnAddPositions.UseVisualStyleBackColor = false;
            this.btnAddPositions.Click += new System.EventHandler(this.btnAddPositions_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chckSpace);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAddPositions);
            this.groupBox2.Controls.Add(this.numSleepTime);
            this.groupBox2.Controls.Add(this.txtMessage);
            this.groupBox2.Controls.Add(this.chckEnter);
            this.groupBox2.Location = new System.Drawing.Point(11, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 97);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            // 
            // chckSpace
            // 
            this.chckSpace.AutoSize = true;
            this.chckSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chckSpace.Location = new System.Drawing.Point(10, 74);
            this.chckSpace.Name = "chckSpace";
            this.chckSpace.Size = new System.Drawing.Size(98, 17);
            this.chckSpace.TabIndex = 54;
            this.chckSpace.Text = "Space after text";
            this.chckSpace.UseVisualStyleBackColor = true;
            this.chckSpace.CheckedChanged += new System.EventHandler(this.chckSpace_CheckedChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoad.Location = new System.Drawing.Point(204, 45);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(43, 25);
            this.btnLoad.TabIndex = 52;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.Location = new System.Drawing.Point(154, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(43, 25);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.Location = new System.Drawing.Point(204, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(43, 25);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chckEnter
            // 
            this.chckEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chckEnter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chckEnter.Location = new System.Drawing.Point(156, 74);
            this.chckEnter.Name = "chckEnter";
            this.chckEnter.Size = new System.Drawing.Size(92, 17);
            this.chckEnter.TabIndex = 53;
            this.chckEnter.Text = "Enter after text";
            this.chckEnter.UseVisualStyleBackColor = true;
            // 
            // linkFkeys
            // 
            this.linkFkeys.ActiveLinkColor = System.Drawing.SystemColors.GrayText;
            this.linkFkeys.AutoSize = true;
            this.linkFkeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFkeys.ForeColor = System.Drawing.SystemColors.GrayText;
            this.linkFkeys.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkFkeys.LinkColor = System.Drawing.SystemColors.GrayText;
            this.linkFkeys.Location = new System.Drawing.Point(224, 292);
            this.linkFkeys.Name = "linkFkeys";
            this.linkFkeys.Size = new System.Drawing.Size(43, 12);
            this.linkFkeys.TabIndex = 52;
            this.linkFkeys.TabStop = true;
            this.linkFkeys.Text = "Hot Keys";
            this.linkFkeys.VisitedLinkColor = System.Drawing.SystemColors.GrayText;
            this.linkFkeys.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFkeys_LinkClicked);
            // 
            // linkbuymeacoffe
            // 
            this.linkbuymeacoffe.ActiveLinkColor = System.Drawing.SystemColors.GrayText;
            this.linkbuymeacoffe.AutoSize = true;
            this.linkbuymeacoffe.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkbuymeacoffe.ForeColor = System.Drawing.SystemColors.GrayText;
            this.linkbuymeacoffe.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkbuymeacoffe.LinkColor = System.Drawing.SystemColors.GrayText;
            this.linkbuymeacoffe.Location = new System.Drawing.Point(9, 292);
            this.linkbuymeacoffe.Name = "linkbuymeacoffe";
            this.linkbuymeacoffe.Size = new System.Drawing.Size(78, 12);
            this.linkbuymeacoffe.TabIndex = 51;
            this.linkbuymeacoffe.TabStop = true;
            this.linkbuymeacoffe.Text = " Buy Me A Coffee";
            this.linkbuymeacoffe.VisitedLinkColor = System.Drawing.SystemColors.GrayText;
            this.linkbuymeacoffe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkF7_LinkClicked);
            // 
            // ctxNotifyIcon
            // 
            this.ctxNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsShow,
            this.tsExit});
            this.ctxNotifyIcon.Name = "ctxNotifyIcon";
            this.ctxNotifyIcon.Size = new System.Drawing.Size(104, 48);
            // 
            // tsShow
            // 
            this.tsShow.Image = global::Auto_Keyboard.Properties.Resources.show;
            this.tsShow.Name = "tsShow";
            this.tsShow.Size = new System.Drawing.Size(103, 22);
            this.tsShow.Text = "Show";
            this.tsShow.Click += new System.EventHandler(this.tsShow_Click);
            // 
            // tsExit
            // 
            this.tsExit.Image = global::Auto_Keyboard.Properties.Resources.exit;
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(103, 22);
            this.tsExit.Text = "Exit";
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Application run from System Tray";
            this.notifyIcon.BalloonTipTitle = "Auto Text Message";
            this.notifyIcon.ContextMenuStrip = this.ctxNotifyIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Auto Text And Click";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // frmKryesore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(276, 310);
            this.Controls.Add(this.linkFkeys);
            this.Controls.Add(this.linkbuymeacoffe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SleepTimeLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(292, 349);
            this.MinimumSize = new System.Drawing.Size(292, 349);
            this.Name = "frmKryesore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto - Keyboard";
            this.Load += new System.EventHandler(this.frmKryesore_Load);
            this.Resize += new System.EventHandler(this.frmKryesore_Resize);
            this.groupBox1.ResumeLayout(false);
            this.ListViewContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSleepTime)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ctxNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView PositionsListView;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnMessage;
        private System.Windows.Forms.Label SleepTimeLabel;
        private System.Windows.Forms.NumericUpDown numSleepTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnAddPositions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.LinkLabel linkFkeys;
        private System.Windows.Forms.LinkLabel linkbuymeacoffe;
        private System.Windows.Forms.ContextMenuStrip ctxNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem tsShow;
        private System.Windows.Forms.ToolStripMenuItem tsExit;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip ListViewContextMenu;
        private System.Windows.Forms.ToolStripMenuItem RemoveSelectedMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remotefromfileMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem RemoveAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downToolStripMenuItem;
        private System.Windows.Forms.CheckBox chckEnter;
        private System.Windows.Forms.CheckBox chckSpace;
    }
}

