namespace AlbumMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemPropeties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.photoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAndNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleMarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxPhotos = new System.Windows.Forms.ListView();
            this.titleColHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPrev = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNext = new System.Windows.Forms.ToolStripButton();
            this.albumPhotoPanel1 = new AlbumMan.AlbumPhotoPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.photoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAlbumToolStripMenuItem,
            this.saveAlbumToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItemPropeties,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openAlbumToolStripMenuItem
            // 
            this.openAlbumToolStripMenuItem.Image = global::AlbumMan.Properties.Resources.folder;
            this.openAlbumToolStripMenuItem.Name = "openAlbumToolStripMenuItem";
            this.openAlbumToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.openAlbumToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openAlbumToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openAlbumToolStripMenuItem.Text = "Open";
            this.openAlbumToolStripMenuItem.Click += new System.EventHandler(this.OpenAlbumToolStripMenuItem_Click);
            // 
            // saveAlbumToolStripMenuItem
            // 
            this.saveAlbumToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAlbumToolStripMenuItem.Image")));
            this.saveAlbumToolStripMenuItem.Name = "saveAlbumToolStripMenuItem";
            this.saveAlbumToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAlbumToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAlbumToolStripMenuItem.Text = "Save";
            this.saveAlbumToolStripMenuItem.Click += new System.EventHandler(this.SaveAlbumToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // toolStripMenuItemPropeties
            // 
            this.toolStripMenuItemPropeties.Image = global::AlbumMan.Properties.Resources.tick;
            this.toolStripMenuItemPropeties.Name = "toolStripMenuItemPropeties";
            this.toolStripMenuItemPropeties.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItemPropeties.Text = "Properties";
            this.toolStripMenuItemPropeties.Click += new System.EventHandler(this.ToolStripMenuItemPropeties_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::AlbumMan.Properties.Resources.door_out;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // photoToolStripMenuItem
            // 
            this.photoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previousToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.saveAndNextToolStripMenuItem,
            this.toggleMarkToolStripMenuItem});
            this.photoToolStripMenuItem.Name = "photoToolStripMenuItem";
            this.photoToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.photoToolStripMenuItem.Text = "Photo";
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Image = global::AlbumMan.Properties.Resources.arrow_left;
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.previousToolStripMenuItem.Text = "Previous";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.PreviousToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Image = global::AlbumMan.Properties.Resources.arrow_right;
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.NextToolStripMenuItem_Click);
            // 
            // saveAndNextToolStripMenuItem
            // 
            this.saveAndNextToolStripMenuItem.Image = global::AlbumMan.Properties.Resources.book_next;
            this.saveAndNextToolStripMenuItem.Name = "saveAndNextToolStripMenuItem";
            this.saveAndNextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.saveAndNextToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveAndNextToolStripMenuItem.Text = "Confirm and Next";
            this.saveAndNextToolStripMenuItem.Click += new System.EventHandler(this.SaveAndNextToolStripMenuItem_Click);
            // 
            // toggleMarkToolStripMenuItem
            // 
            this.toggleMarkToolStripMenuItem.Image = global::AlbumMan.Properties.Resources.tick;
            this.toggleMarkToolStripMenuItem.Name = "toggleMarkToolStripMenuItem";
            this.toggleMarkToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.toggleMarkToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.toggleMarkToolStripMenuItem.Text = "Toggle Mark";
            this.toggleMarkToolStripMenuItem.Click += new System.EventHandler(this.ToggleMarkToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxPhotos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.albumPhotoPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 391);
            this.splitContainer1.SplitterDistance = 109;
            this.splitContainer1.TabIndex = 1;
            // 
            // listBoxPhotos
            // 
            this.listBoxPhotos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listBoxPhotos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleColHeader});
            this.listBoxPhotos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPhotos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPhotos.FullRowSelect = true;
            this.listBoxPhotos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listBoxPhotos.HideSelection = false;
            this.listBoxPhotos.Location = new System.Drawing.Point(0, 0);
            this.listBoxPhotos.Name = "listBoxPhotos";
            this.listBoxPhotos.Size = new System.Drawing.Size(109, 391);
            this.listBoxPhotos.TabIndex = 0;
            this.listBoxPhotos.UseCompatibleStateImageBehavior = false;
            this.listBoxPhotos.View = System.Windows.Forms.View.Details;
            this.listBoxPhotos.SelectedIndexChanged += new System.EventHandler(this.ListBoxPhotos_SelectedIndexChanged);
            this.listBoxPhotos.Resize += new System.EventHandler(this.ListBoxPhotos_Resize);
            // 
            // titleColHeader
            // 
            this.titleColHeader.Text = "Title";
            this.titleColHeader.Width = 200;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 391);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripSeparator1,
            this.toolStripButtonPrev,
            this.toolStripButtonNext});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 35);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = global::AlbumMan.Properties.Resources.folder;
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(32, 32);
            this.toolStripButtonOpen.Text = "Open Album";
            this.toolStripButtonOpen.ToolTipText = "Open Album (Ctrl+O)";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.ToolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::AlbumMan.Properties.Resources.disk_multiple;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(32, 32);
            this.toolStripButtonSave.Text = "Save Album";
            this.toolStripButtonSave.ToolTipText = "Save Album (Ctrl+S)";
            this.toolStripButtonSave.Click += new System.EventHandler(this.ToolStripButtonSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripButtonPrev
            // 
            this.toolStripButtonPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrev.Image = global::AlbumMan.Properties.Resources.arrow_left;
            this.toolStripButtonPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrev.Name = "toolStripButtonPrev";
            this.toolStripButtonPrev.Size = new System.Drawing.Size(32, 32);
            this.toolStripButtonPrev.Text = "Previous (F3)";
            this.toolStripButtonPrev.Click += new System.EventHandler(this.ToolStripButtonPrev_Click);
            // 
            // toolStripButtonNext
            // 
            this.toolStripButtonNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNext.Image = global::AlbumMan.Properties.Resources.arrow_right;
            this.toolStripButtonNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNext.Name = "toolStripButtonNext";
            this.toolStripButtonNext.Size = new System.Drawing.Size(32, 32);
            this.toolStripButtonNext.Text = "Next (F4)";
            this.toolStripButtonNext.Click += new System.EventHandler(this.ToolStripButtonNext_Click);
            // 
            // albumPhotoPanel1
            // 
            this.albumPhotoPanel1.Date = new System.DateTime(2019, 9, 10, 23, 30, 0, 0);
            this.albumPhotoPanel1.Description = "";
            this.albumPhotoPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albumPhotoPanel1.Location = new System.Drawing.Point(0, 0);
            this.albumPhotoPanel1.Marked = false;
            this.albumPhotoPanel1.Name = "albumPhotoPanel1";
            this.albumPhotoPanel1.Size = new System.Drawing.Size(687, 391);
            this.albumPhotoPanel1.TabIndex = 0;
            this.albumPhotoPanel1.Tags = ((System.Collections.Generic.List<string>)(resources.GetObject("albumPhotoPanel1.Tags")));
            this.albumPhotoPanel1.Title = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "AlbumMan";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listBoxPhotos;
        private System.Windows.Forms.ColumnHeader titleColHeader;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripMenuItem photoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAndNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleMarkToolStripMenuItem;
        private AlbumPhotoPanel albumPhotoPanel1;
        private System.Windows.Forms.ToolStripMenuItem saveAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrev;
        private System.Windows.Forms.ToolStripButton toolStripButtonNext;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPropeties;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

