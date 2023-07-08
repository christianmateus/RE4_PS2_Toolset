namespace RE4_PS2_Toolset.Forms.ETS
{
    partial class ETSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ETSForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusObjectQuantity = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEmptyETSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openETSFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.table = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeObjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.statusObjectQuantity});
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(908, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.BackColor = System.Drawing.Color.White;
            this.statusText.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusText.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(4, 17);
            // 
            // statusObjectQuantity
            // 
            this.statusObjectQuantity.BackColor = System.Drawing.Color.White;
            this.statusObjectQuantity.Name = "statusObjectQuantity";
            this.statusObjectQuantity.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEmptyETSToolStripMenuItem,
            this.openETSFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.refreshTableToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createEmptyETSToolStripMenuItem
            // 
            this.createEmptyETSToolStripMenuItem.Name = "createEmptyETSToolStripMenuItem";
            this.createEmptyETSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createEmptyETSToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.createEmptyETSToolStripMenuItem.Text = "Create empty ETS";
            this.createEmptyETSToolStripMenuItem.Click += new System.EventHandler(this.createEmptyETSToolStripMenuItem_Click);
            // 
            // openETSFileToolStripMenuItem
            // 
            this.openETSFileToolStripMenuItem.Name = "openETSFileToolStripMenuItem";
            this.openETSFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openETSFileToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.openETSFileToolStripMenuItem.Text = "Open ETS file";
            this.openETSFileToolStripMenuItem.Click += new System.EventHandler(this.openETSFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.saveFileToolStripMenuItem.Text = "Save file";
            // 
            // refreshTableToolStripMenuItem
            // 
            this.refreshTableToolStripMenuItem.Name = "refreshTableToolStripMenuItem";
            this.refreshTableToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.refreshTableToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.refreshTableToolStripMenuItem.Text = "Refresh table";
            this.refreshTableToolStripMenuItem.Click += new System.EventHandler(this.refreshTableToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.closeToolStripMenuItem.Text = "Close file";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewObjectToolStripMenuItem,
            this.removeObjectToolStripMenuItem,
            this.duplicateSelectedToolStripMenuItem,
            this.toolStripSeparator2,
            this.removeSelectedToolStripMenuItem,
            this.removeAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.editToolStripMenuItem.Text = "Object";
            // 
            // addNewObjectToolStripMenuItem
            // 
            this.addNewObjectToolStripMenuItem.Name = "addNewObjectToolStripMenuItem";
            this.addNewObjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.addNewObjectToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.addNewObjectToolStripMenuItem.Text = "Add new object";
            this.addNewObjectToolStripMenuItem.Click += new System.EventHandler(this.addNewObjectToolStripMenuItem_Click);
            // 
            // removeObjectToolStripMenuItem
            // 
            this.removeObjectToolStripMenuItem.Name = "removeObjectToolStripMenuItem";
            this.removeObjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.removeObjectToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.removeObjectToolStripMenuItem.Text = "Remove object";
            this.removeObjectToolStripMenuItem.Click += new System.EventHandler(this.removeObjectToolStripMenuItem_Click);
            // 
            // duplicateSelectedToolStripMenuItem
            // 
            this.duplicateSelectedToolStripMenuItem.Name = "duplicateSelectedToolStripMenuItem";
            this.duplicateSelectedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.duplicateSelectedToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.duplicateSelectedToolStripMenuItem.Text = "Duplicate object";
            this.duplicateSelectedToolStripMenuItem.Click += new System.EventHandler(this.duplicateObjectToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.removeSelectedToolStripMenuItem.Text = "Remove selected";
            // 
            // removeAllToolStripMenuItem
            // 
            this.removeAllToolStripMenuItem.Name = "removeAllToolStripMenuItem";
            this.removeAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.removeAllToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.removeAllToolStripMenuItem.Text = "Remove all";
            this.removeAllToolStripMenuItem.Click += new System.EventHandler(this.removeAllToolStripMenuItem_Click);
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeRows = false;
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(0, 73);
            this.table.Name = "table";
            this.table.RowTemplate.Height = 80;
            this.table.Size = new System.Drawing.Size(908, 420);
            this.table.TabIndex = 3;
            this.table.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.table_CellMouseUp);
            this.table.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 40);
            this.panel1.TabIndex = 4;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(111, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(93, 34);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove object";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(12, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add new object";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tableContextMenu
            // 
            this.tableContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeObjectToolStripMenuItem1,
            this.duplicateObjectToolStripMenuItem});
            this.tableContextMenu.Name = "tableContextMenu";
            this.tableContextMenu.Size = new System.Drawing.Size(161, 48);
            // 
            // removeObjectToolStripMenuItem1
            // 
            this.removeObjectToolStripMenuItem1.Name = "removeObjectToolStripMenuItem1";
            this.removeObjectToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.removeObjectToolStripMenuItem1.Text = "Remove object";
            this.removeObjectToolStripMenuItem1.Click += new System.EventHandler(this.removeObjectToolStripMenuItem1_Click);
            // 
            // duplicateObjectToolStripMenuItem
            // 
            this.duplicateObjectToolStripMenuItem.Name = "duplicateObjectToolStripMenuItem";
            this.duplicateObjectToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.duplicateObjectToolStripMenuItem.Text = "Duplicate object";
            this.duplicateObjectToolStripMenuItem.Click += new System.EventHandler(this.duplicateObjectToolStripMenuItem_Click_1);
            // 
            // ETSForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(908, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.table);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ETSForm";
            this.Text = "ETS Tool";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ETSForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ETSForm_DragEnter);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openETSFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem duplicateSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusObjectQuantity;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.ToolStripMenuItem refreshTableToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip tableContextMenu;
        private System.Windows.Forms.ToolStripMenuItem removeObjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem duplicateObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEmptyETSToolStripMenuItem;
    }
}