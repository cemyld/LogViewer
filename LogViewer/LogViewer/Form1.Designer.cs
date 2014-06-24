namespace LogViewer
{
    partial class FrmLogViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogViewer));
            this.msTopMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlFiles = new System.Windows.Forms.TabControl();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.MainContainerTable = new System.Windows.Forms.TableLayoutPanel();
            this.flayoutFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbLogType = new System.Windows.Forms.ComboBox();
            this.frmLogViewerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frmLogViewerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.msTopMenu.SuspendLayout();
            this.MainContainerTable.SuspendLayout();
            this.flayoutFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmLogViewerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmLogViewerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // msTopMenu
            // 
            this.msTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile});
            this.msTopMenu.Location = new System.Drawing.Point(0, 0);
            this.msTopMenu.Name = "msTopMenu";
            this.msTopMenu.Size = new System.Drawing.Size(916, 33);
            this.msTopMenu.TabIndex = 0;
            this.msTopMenu.Text = "menuStrip1";
            // 
            // toolStripMenuFile
            // 
            this.toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openFolderToolStripMenuItem});
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(50, 29);
            this.toolStripMenuFile.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(195, 30);
            this.openToolStripMenuItem.Text = "Open File...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(195, 30);
            this.openFolderToolStripMenuItem.Text = "Open Folder...";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // tabControlFiles
            // 
            this.tabControlFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFiles.Location = new System.Drawing.Point(3, 48);
            this.tabControlFiles.Name = "tabControlFiles";
            this.tabControlFiles.SelectedIndex = 0;
            this.tabControlFiles.Size = new System.Drawing.Size(910, 431);
            this.tabControlFiles.TabIndex = 1;
            this.tabControlFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(696, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 34);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(569, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(121, 34);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(217, 3);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowCheckBox = true;
            this.dtpEndTime.Size = new System.Drawing.Size(219, 26);
            this.dtpEndTime.TabIndex = 1;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(3, 3);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowCheckBox = true;
            this.dtpStartTime.Size = new System.Drawing.Size(208, 26);
            this.dtpStartTime.TabIndex = 0;
            // 
            // MainContainerTable
            // 
            this.MainContainerTable.ColumnCount = 1;
            this.MainContainerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainContainerTable.Controls.Add(this.tabControlFiles, 0, 1);
            this.MainContainerTable.Controls.Add(this.flayoutFilter, 0, 0);
            this.MainContainerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainerTable.Location = new System.Drawing.Point(0, 33);
            this.MainContainerTable.Name = "MainContainerTable";
            this.MainContainerTable.RowCount = 2;
            this.MainContainerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.MainContainerTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainContainerTable.Size = new System.Drawing.Size(916, 457);
            this.MainContainerTable.TabIndex = 3;
            // 
            // flayoutFilter
            // 
            this.flayoutFilter.Controls.Add(this.dtpStartTime);
            this.flayoutFilter.Controls.Add(this.dtpEndTime);
            this.flayoutFilter.Controls.Add(this.cmbLogType);
            this.flayoutFilter.Controls.Add(this.btnFilter);
            this.flayoutFilter.Controls.Add(this.btnClear);
            this.flayoutFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flayoutFilter.Location = new System.Drawing.Point(3, 3);
            this.flayoutFilter.Name = "flayoutFilter";
            this.flayoutFilter.Size = new System.Drawing.Size(910, 39);
            this.flayoutFilter.TabIndex = 2;
            // 
            // cmbLogType
            // 
            this.cmbLogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLogType.FormattingEnabled = true;
            this.cmbLogType.Items.AddRange(new object[] {
            "ALL",
            "INFO",
            "WARN",
            "FATAL",
            "DEBUG",
            "ERROR",
            "VALIDATION_ERROR"});
            this.cmbLogType.Location = new System.Drawing.Point(442, 3);
            this.cmbLogType.Name = "cmbLogType";
            this.cmbLogType.Size = new System.Drawing.Size(121, 28);
            this.cmbLogType.TabIndex = 2;
            // 
            // frmLogViewerBindingSource
            // 
            this.frmLogViewerBindingSource.DataSource = typeof(LogViewer.FrmLogViewer);
            // 
            // frmLogViewerBindingSource1
            // 
            this.frmLogViewerBindingSource1.DataSource = typeof(LogViewer.FrmLogViewer);
            // 
            // FrmLogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(916, 490);
            this.Controls.Add(this.MainContainerTable);
            this.Controls.Add(this.msTopMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msTopMenu;
            this.Name = "FrmLogViewer";
            this.Text = "Log Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msTopMenu.ResumeLayout(false);
            this.msTopMenu.PerformLayout();
            this.MainContainerTable.ResumeLayout(false);
            this.flayoutFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frmLogViewerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmLogViewerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msTopMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlFiles;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.TableLayoutPanel MainContainerTable;
        private System.Windows.Forms.FlowLayoutPanel flayoutFilter;
        private System.Windows.Forms.BindingSource frmLogViewerBindingSource;
        private System.Windows.Forms.BindingSource frmLogViewerBindingSource1;
        private System.Windows.Forms.ComboBox cmbLogType;


    }
}

