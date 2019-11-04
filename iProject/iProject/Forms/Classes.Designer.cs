namespace iProject.Forms {
    partial class Classes {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabAddClasses = new MetroFramework.Controls.MetroTabPage();
            this.cbClassTeacher_AddClasses = new MetroFramework.Controls.MetroComboBox();
            this.lblClassTeacher_AddClasses = new MetroFramework.Controls.MetroLabel();
            this.btnAdd_AddClasses = new MetroFramework.Controls.MetroTile();
            this.lblClassName_AddClasses = new MetroFramework.Controls.MetroLabel();
            this.txtClassName_AddClasses = new MetroFramework.Controls.MetroTextBox();
            this.tabAllClasses = new MetroFramework.Controls.MetroTabPage();
            this.dgvClasses_AllClasses = new System.Windows.Forms.DataGridView();
            this.btnView_AllClasses = new MetroFramework.Controls.MetroTile();
            this.cbClassName_AllClasses = new MetroFramework.Controls.MetroComboBox();
            this.lblClassName_AllClasses = new MetroFramework.Controls.MetroLabel();
            this.lblRoomNumber_AddClasses = new MetroFramework.Controls.MetroLabel();
            this.txtRoomNumber_AddClasses = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.tabAddClasses.SuspendLayout();
            this.tabAllClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses_AllClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabAddClasses);
            this.metroTabControl1.Controls.Add(this.tabAllClasses);
            this.metroTabControl1.Location = new System.Drawing.Point(24, 64);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(853, 513);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabAddClasses
            // 
            this.tabAddClasses.Controls.Add(this.txtRoomNumber_AddClasses);
            this.tabAddClasses.Controls.Add(this.lblRoomNumber_AddClasses);
            this.tabAddClasses.Controls.Add(this.cbClassTeacher_AddClasses);
            this.tabAddClasses.Controls.Add(this.lblClassTeacher_AddClasses);
            this.tabAddClasses.Controls.Add(this.btnAdd_AddClasses);
            this.tabAddClasses.Controls.Add(this.lblClassName_AddClasses);
            this.tabAddClasses.Controls.Add(this.txtClassName_AddClasses);
            this.tabAddClasses.HorizontalScrollbarBarColor = true;
            this.tabAddClasses.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAddClasses.HorizontalScrollbarSize = 10;
            this.tabAddClasses.Location = new System.Drawing.Point(4, 38);
            this.tabAddClasses.Name = "tabAddClasses";
            this.tabAddClasses.Size = new System.Drawing.Size(845, 471);
            this.tabAddClasses.TabIndex = 0;
            this.tabAddClasses.Text = " Add Classes ";
            this.tabAddClasses.VerticalScrollbarBarColor = true;
            this.tabAddClasses.VerticalScrollbarHighlightOnWheel = false;
            this.tabAddClasses.VerticalScrollbarSize = 10;
            // 
            // cbClassTeacher_AddClasses
            // 
            this.cbClassTeacher_AddClasses.FormattingEnabled = true;
            this.cbClassTeacher_AddClasses.ItemHeight = 24;
            this.cbClassTeacher_AddClasses.Location = new System.Drawing.Point(600, 100);
            this.cbClassTeacher_AddClasses.Name = "cbClassTeacher_AddClasses";
            this.cbClassTeacher_AddClasses.Size = new System.Drawing.Size(200, 30);
            this.cbClassTeacher_AddClasses.TabIndex = 40;
            this.cbClassTeacher_AddClasses.UseSelectable = true;
            // 
            // lblClassTeacher_AddClasses
            // 
            this.lblClassTeacher_AddClasses.AutoSize = true;
            this.lblClassTeacher_AddClasses.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblClassTeacher_AddClasses.Location = new System.Drawing.Point(447, 100);
            this.lblClassTeacher_AddClasses.Name = "lblClassTeacher_AddClasses";
            this.lblClassTeacher_AddClasses.Size = new System.Drawing.Size(116, 25);
            this.lblClassTeacher_AddClasses.TabIndex = 38;
            this.lblClassTeacher_AddClasses.Text = "Class Teacher";
            // 
            // btnAdd_AddClasses
            // 
            this.btnAdd_AddClasses.ActiveControl = null;
            this.btnAdd_AddClasses.Location = new System.Drawing.Point(300, 180);
            this.btnAdd_AddClasses.Name = "btnAdd_AddClasses";
            this.btnAdd_AddClasses.Size = new System.Drawing.Size(250, 50);
            this.btnAdd_AddClasses.TabIndex = 35;
            this.btnAdd_AddClasses.Text = "Add";
            this.btnAdd_AddClasses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd_AddClasses.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAdd_AddClasses.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAdd_AddClasses.UseSelectable = true;
            // 
            // lblClassName_AddClasses
            // 
            this.lblClassName_AddClasses.AutoSize = true;
            this.lblClassName_AddClasses.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblClassName_AddClasses.Location = new System.Drawing.Point(60, 50);
            this.lblClassName_AddClasses.Name = "lblClassName_AddClasses";
            this.lblClassName_AddClasses.Size = new System.Drawing.Size(104, 25);
            this.lblClassName_AddClasses.TabIndex = 5;
            this.lblClassName_AddClasses.Text = "Class Name";
            // 
            // txtClassName_AddClasses
            // 
            // 
            // 
            // 
            this.txtClassName_AddClasses.CustomButton.Image = null;
            this.txtClassName_AddClasses.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtClassName_AddClasses.CustomButton.Name = "";
            this.txtClassName_AddClasses.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtClassName_AddClasses.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClassName_AddClasses.CustomButton.TabIndex = 1;
            this.txtClassName_AddClasses.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClassName_AddClasses.CustomButton.UseSelectable = true;
            this.txtClassName_AddClasses.CustomButton.Visible = false;
            this.txtClassName_AddClasses.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtClassName_AddClasses.Lines = new string[0];
            this.txtClassName_AddClasses.Location = new System.Drawing.Point(200, 50);
            this.txtClassName_AddClasses.MaxLength = 32767;
            this.txtClassName_AddClasses.Name = "txtClassName_AddClasses";
            this.txtClassName_AddClasses.PasswordChar = '\0';
            this.txtClassName_AddClasses.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClassName_AddClasses.SelectedText = "";
            this.txtClassName_AddClasses.SelectionLength = 0;
            this.txtClassName_AddClasses.SelectionStart = 0;
            this.txtClassName_AddClasses.ShortcutsEnabled = true;
            this.txtClassName_AddClasses.Size = new System.Drawing.Size(200, 30);
            this.txtClassName_AddClasses.TabIndex = 4;
            this.txtClassName_AddClasses.UseSelectable = true;
            this.txtClassName_AddClasses.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClassName_AddClasses.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabAllClasses
            // 
            this.tabAllClasses.Controls.Add(this.dgvClasses_AllClasses);
            this.tabAllClasses.Controls.Add(this.btnView_AllClasses);
            this.tabAllClasses.Controls.Add(this.cbClassName_AllClasses);
            this.tabAllClasses.Controls.Add(this.lblClassName_AllClasses);
            this.tabAllClasses.HorizontalScrollbarBarColor = true;
            this.tabAllClasses.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAllClasses.HorizontalScrollbarSize = 10;
            this.tabAllClasses.Location = new System.Drawing.Point(4, 38);
            this.tabAllClasses.Name = "tabAllClasses";
            this.tabAllClasses.Size = new System.Drawing.Size(845, 471);
            this.tabAllClasses.TabIndex = 1;
            this.tabAllClasses.Text = " All Classes ";
            this.tabAllClasses.VerticalScrollbarBarColor = true;
            this.tabAllClasses.VerticalScrollbarHighlightOnWheel = false;
            this.tabAllClasses.VerticalScrollbarSize = 10;
            // 
            // dgvClasses_AllClasses
            // 
            this.dgvClasses_AllClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses_AllClasses.Location = new System.Drawing.Point(4, 109);
            this.dgvClasses_AllClasses.Name = "dgvClasses_AllClasses";
            this.dgvClasses_AllClasses.RowTemplate.Height = 24;
            this.dgvClasses_AllClasses.Size = new System.Drawing.Size(838, 359);
            this.dgvClasses_AllClasses.TabIndex = 43;
            // 
            // btnView_AllClasses
            // 
            this.btnView_AllClasses.ActiveControl = null;
            this.btnView_AllClasses.Location = new System.Drawing.Point(550, 40);
            this.btnView_AllClasses.Name = "btnView_AllClasses";
            this.btnView_AllClasses.Size = new System.Drawing.Size(250, 50);
            this.btnView_AllClasses.TabIndex = 42;
            this.btnView_AllClasses.Text = "View";
            this.btnView_AllClasses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnView_AllClasses.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnView_AllClasses.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnView_AllClasses.UseSelectable = true;
            // 
            // cbClassName_AllClasses
            // 
            this.cbClassName_AllClasses.FormattingEnabled = true;
            this.cbClassName_AllClasses.ItemHeight = 24;
            this.cbClassName_AllClasses.Location = new System.Drawing.Point(200, 50);
            this.cbClassName_AllClasses.Name = "cbClassName_AllClasses";
            this.cbClassName_AllClasses.Size = new System.Drawing.Size(200, 30);
            this.cbClassName_AllClasses.TabIndex = 41;
            this.cbClassName_AllClasses.UseSelectable = true;
            // 
            // lblClassName_AllClasses
            // 
            this.lblClassName_AllClasses.AutoSize = true;
            this.lblClassName_AllClasses.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblClassName_AllClasses.Location = new System.Drawing.Point(50, 50);
            this.lblClassName_AllClasses.Name = "lblClassName_AllClasses";
            this.lblClassName_AllClasses.Size = new System.Drawing.Size(104, 25);
            this.lblClassName_AllClasses.TabIndex = 6;
            this.lblClassName_AllClasses.Text = "Class Name";
            // 
            // lblRoomNumber_AddClasses
            // 
            this.lblRoomNumber_AddClasses.AutoSize = true;
            this.lblRoomNumber_AddClasses.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRoomNumber_AddClasses.Location = new System.Drawing.Point(447, 50);
            this.lblRoomNumber_AddClasses.Name = "lblRoomNumber_AddClasses";
            this.lblRoomNumber_AddClasses.Size = new System.Drawing.Size(132, 25);
            this.lblRoomNumber_AddClasses.TabIndex = 41;
            this.lblRoomNumber_AddClasses.Text = "Room Number";
            // 
            // txtRoomNumber_AddClasses
            // 
            // 
            // 
            // 
            this.txtRoomNumber_AddClasses.CustomButton.Image = null;
            this.txtRoomNumber_AddClasses.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtRoomNumber_AddClasses.CustomButton.Name = "";
            this.txtRoomNumber_AddClasses.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtRoomNumber_AddClasses.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRoomNumber_AddClasses.CustomButton.TabIndex = 1;
            this.txtRoomNumber_AddClasses.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRoomNumber_AddClasses.CustomButton.UseSelectable = true;
            this.txtRoomNumber_AddClasses.CustomButton.Visible = false;
            this.txtRoomNumber_AddClasses.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtRoomNumber_AddClasses.Lines = new string[0];
            this.txtRoomNumber_AddClasses.Location = new System.Drawing.Point(600, 50);
            this.txtRoomNumber_AddClasses.MaxLength = 32767;
            this.txtRoomNumber_AddClasses.Name = "txtRoomNumber_AddClasses";
            this.txtRoomNumber_AddClasses.PasswordChar = '\0';
            this.txtRoomNumber_AddClasses.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRoomNumber_AddClasses.SelectedText = "";
            this.txtRoomNumber_AddClasses.SelectionLength = 0;
            this.txtRoomNumber_AddClasses.SelectionStart = 0;
            this.txtRoomNumber_AddClasses.ShortcutsEnabled = true;
            this.txtRoomNumber_AddClasses.Size = new System.Drawing.Size(200, 30);
            this.txtRoomNumber_AddClasses.TabIndex = 42;
            this.txtRoomNumber_AddClasses.UseSelectable = true;
            this.txtRoomNumber_AddClasses.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRoomNumber_AddClasses.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Classes";
            this.Text = "Classes";
            this.metroTabControl1.ResumeLayout(false);
            this.tabAddClasses.ResumeLayout(false);
            this.tabAddClasses.PerformLayout();
            this.tabAllClasses.ResumeLayout(false);
            this.tabAllClasses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses_AllClasses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabAddClasses;
        private MetroFramework.Controls.MetroTabPage tabAllClasses;
        private MetroFramework.Controls.MetroTextBox txtClassName_AddClasses;
        private MetroFramework.Controls.MetroLabel lblClassName_AddClasses;
        private MetroFramework.Controls.MetroLabel lblClassTeacher_AddClasses;
        private MetroFramework.Controls.MetroTile btnAdd_AddClasses;
        private MetroFramework.Controls.MetroComboBox cbClassTeacher_AddClasses;
        private MetroFramework.Controls.MetroTile btnView_AllClasses;
        private MetroFramework.Controls.MetroComboBox cbClassName_AllClasses;
        private MetroFramework.Controls.MetroLabel lblClassName_AllClasses;
        private System.Windows.Forms.DataGridView dgvClasses_AllClasses;
        private MetroFramework.Controls.MetroTextBox txtRoomNumber_AddClasses;
        private MetroFramework.Controls.MetroLabel lblRoomNumber_AddClasses;
    }
}