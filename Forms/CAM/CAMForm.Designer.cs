namespace RE4_PS2_Toolset.Forms.CAM
{
    partial class CAMForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAMForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEmptyCAMFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToObjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spinActivationType = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.spinVerticesCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.spinDatasetCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.spinLightGroup = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.spinCameraType = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerateEntry = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCameraCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinActivationType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinVerticesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDatasetCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinLightGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCameraType)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.cameraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEmptyCAMFileToolStripMenuItem,
            this.loadCAMToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createEmptyCAMFileToolStripMenuItem
            // 
            this.createEmptyCAMFileToolStripMenuItem.Name = "createEmptyCAMFileToolStripMenuItem";
            this.createEmptyCAMFileToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.createEmptyCAMFileToolStripMenuItem.Text = "Create empty CAM file";
            // 
            // loadCAMToolStripMenuItem
            // 
            this.loadCAMToolStripMenuItem.Name = "loadCAMToolStripMenuItem";
            this.loadCAMToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.loadCAMToolStripMenuItem.Text = "Open CAM file";
            this.loadCAMToolStripMenuItem.Click += new System.EventHandler(this.loadCAMToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveFileToolStripMenuItem.Text = "Save file";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToObjToolStripMenuItem});
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.cameraToolStripMenuItem.Text = "Camera";
            // 
            // exportToObjToolStripMenuItem
            // 
            this.exportToObjToolStripMenuItem.Name = "exportToObjToolStripMenuItem";
            this.exportToObjToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.exportToObjToolStripMenuItem.Text = "Export triggerzones to obj";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(12)))), ((int)(((byte)(148)))));
            this.groupBox1.Controls.Add(this.spinActivationType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.spinVerticesCount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.spinDatasetCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.spinLightGroup);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.spinCameraType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGenerateEntry);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(36, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // spinActivationType
            // 
            this.spinActivationType.Location = new System.Drawing.Point(156, 78);
            this.spinActivationType.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.spinActivationType.Name = "spinActivationType";
            this.spinActivationType.Size = new System.Drawing.Size(63, 20);
            this.spinActivationType.TabIndex = 10;
            this.spinActivationType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spinActivationType.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Activation type";
            // 
            // spinVerticesCount
            // 
            this.spinVerticesCount.Location = new System.Drawing.Point(526, 78);
            this.spinVerticesCount.Name = "spinVerticesCount";
            this.spinVerticesCount.Size = new System.Drawing.Size(63, 20);
            this.spinVerticesCount.TabIndex = 8;
            this.spinVerticesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spinVerticesCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vertices count";
            // 
            // spinDatasetCount
            // 
            this.spinDatasetCount.Location = new System.Drawing.Point(427, 78);
            this.spinDatasetCount.Name = "spinDatasetCount";
            this.spinDatasetCount.Size = new System.Drawing.Size(63, 20);
            this.spinDatasetCount.TabIndex = 6;
            this.spinDatasetCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spinDatasetCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dataset count";
            // 
            // spinLightGroup
            // 
            this.spinLightGroup.Location = new System.Drawing.Point(334, 78);
            this.spinLightGroup.Name = "spinLightGroup";
            this.spinLightGroup.Size = new System.Drawing.Size(63, 20);
            this.spinLightGroup.TabIndex = 4;
            this.spinLightGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Light group";
            // 
            // spinCameraType
            // 
            this.spinCameraType.Location = new System.Drawing.Point(245, 78);
            this.spinCameraType.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.spinCameraType.Name = "spinCameraType";
            this.spinCameraType.Size = new System.Drawing.Size(63, 20);
            this.spinCameraType.TabIndex = 2;
            this.spinCameraType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spinCameraType.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Camera type";
            // 
            // btnGenerateEntry
            // 
            this.btnGenerateEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnGenerateEntry.Location = new System.Drawing.Point(286, 190);
            this.btnGenerateEntry.Name = "btnGenerateEntry";
            this.btnGenerateEntry.Size = new System.Drawing.Size(155, 28);
            this.btnGenerateEntry.TabIndex = 0;
            this.btnGenerateEntry.Text = "Generate new entry";
            this.btnGenerateEntry.UseVisualStyleBackColor = true;
            this.btnGenerateEntry.Click += new System.EventHandler(this.btnGenerateEntry_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.statusCameraCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 483);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(956, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.BackColor = System.Drawing.Color.White;
            this.statusText.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(4, 17);
            // 
            // statusCameraCount
            // 
            this.statusCameraCount.BackColor = System.Drawing.Color.White;
            this.statusCameraCount.Name = "statusCameraCount";
            this.statusCameraCount.Size = new System.Drawing.Size(0, 17);
            // 
            // CAMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(956, 505);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CAMForm";
            this.Text = "CAM Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinActivationType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinVerticesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDatasetCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinLightGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCameraType)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEmptyCAMFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToObjToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerateEntry;
        private System.Windows.Forms.NumericUpDown spinCameraType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spinDatasetCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown spinLightGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown spinVerticesCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown spinActivationType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusCameraCount;
    }
}