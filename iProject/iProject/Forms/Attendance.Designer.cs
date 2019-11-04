namespace iProject.Forms {
    partial class Attendance {
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
            this.tabStudents = new MetroFramework.Controls.MetroTabPage();
            this.tabTeachers = new MetroFramework.Controls.MetroTabPage();
            this.lblClass_Students = new MetroFramework.Controls.MetroLabel();
            this.cbClass_Students = new MetroFramework.Controls.MetroComboBox();
            this.dtDate_Students = new MetroFramework.Controls.MetroDateTime();
            this.btnView_Students = new MetroFramework.Controls.MetroTile();
            this.lblSection_Students = new MetroFramework.Controls.MetroLabel();
            this.btnMark_Students = new MetroFramework.Controls.MetroTile();
            this.cbSection_Students = new MetroFramework.Controls.MetroComboBox();
            this.lblDate_Students = new MetroFramework.Controls.MetroLabel();
            this.dgvClassStudents_Students = new System.Windows.Forms.DataGridView();
            this.lblTeacherID_Teachers = new MetroFramework.Controls.MetroLabel();
            this.txtTeacherID_Teachers = new MetroFramework.Controls.MetroTextBox();
            this.dtDate_Teachers = new MetroFramework.Controls.MetroDateTime();
            this.btnView_Teachers = new MetroFramework.Controls.MetroTile();
            this.lblDate_Teachers = new MetroFramework.Controls.MetroLabel();
            this.btnMark_Teachers = new MetroFramework.Controls.MetroTile();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroTabControl1.SuspendLayout();
            this.tabStudents.SuspendLayout();
            this.tabTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassStudents_Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabStudents);
            this.metroTabControl1.Controls.Add(this.tabTeachers);
            this.metroTabControl1.Location = new System.Drawing.Point(24, 80);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(853, 497);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabStudents
            // 
            this.tabStudents.Controls.Add(this.dgvClassStudents_Students);
            this.tabStudents.Controls.Add(this.lblDate_Students);
            this.tabStudents.Controls.Add(this.cbSection_Students);
            this.tabStudents.Controls.Add(this.btnMark_Students);
            this.tabStudents.Controls.Add(this.lblSection_Students);
            this.tabStudents.Controls.Add(this.btnView_Students);
            this.tabStudents.Controls.Add(this.dtDate_Students);
            this.tabStudents.Controls.Add(this.cbClass_Students);
            this.tabStudents.Controls.Add(this.lblClass_Students);
            this.tabStudents.HorizontalScrollbarBarColor = true;
            this.tabStudents.HorizontalScrollbarHighlightOnWheel = false;
            this.tabStudents.HorizontalScrollbarSize = 10;
            this.tabStudents.Location = new System.Drawing.Point(4, 38);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Size = new System.Drawing.Size(845, 455);
            this.tabStudents.TabIndex = 0;
            this.tabStudents.Text = " Students ";
            this.tabStudents.VerticalScrollbarBarColor = true;
            this.tabStudents.VerticalScrollbarHighlightOnWheel = false;
            this.tabStudents.VerticalScrollbarSize = 10;
            // 
            // tabTeachers
            // 
            this.tabTeachers.Controls.Add(this.dataGridView1);
            this.tabTeachers.Controls.Add(this.btnMark_Teachers);
            this.tabTeachers.Controls.Add(this.lblDate_Teachers);
            this.tabTeachers.Controls.Add(this.btnView_Teachers);
            this.tabTeachers.Controls.Add(this.dtDate_Teachers);
            this.tabTeachers.Controls.Add(this.txtTeacherID_Teachers);
            this.tabTeachers.Controls.Add(this.lblTeacherID_Teachers);
            this.tabTeachers.HorizontalScrollbarBarColor = true;
            this.tabTeachers.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTeachers.HorizontalScrollbarSize = 10;
            this.tabTeachers.Location = new System.Drawing.Point(4, 38);
            this.tabTeachers.Name = "tabTeachers";
            this.tabTeachers.Size = new System.Drawing.Size(845, 455);
            this.tabTeachers.TabIndex = 1;
            this.tabTeachers.Text = " Teachers ";
            this.tabTeachers.VerticalScrollbarBarColor = true;
            this.tabTeachers.VerticalScrollbarHighlightOnWheel = false;
            this.tabTeachers.VerticalScrollbarSize = 10;
            // 
            // lblClass_Students
            // 
            this.lblClass_Students.AutoSize = true;
            this.lblClass_Students.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblClass_Students.Location = new System.Drawing.Point(50, 50);
            this.lblClass_Students.Name = "lblClass_Students";
            this.lblClass_Students.Size = new System.Drawing.Size(51, 25);
            this.lblClass_Students.TabIndex = 6;
            this.lblClass_Students.Text = "Class";
            // 
            // cbClass_Students
            // 
            this.cbClass_Students.FormattingEnabled = true;
            this.cbClass_Students.ItemHeight = 24;
            this.cbClass_Students.Location = new System.Drawing.Point(150, 50);
            this.cbClass_Students.Name = "cbClass_Students";
            this.cbClass_Students.Size = new System.Drawing.Size(200, 30);
            this.cbClass_Students.TabIndex = 41;
            this.cbClass_Students.UseSelectable = true;
            // 
            // dtDate_Students
            // 
            this.dtDate_Students.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate_Students.Location = new System.Drawing.Point(562, 50);
            this.dtDate_Students.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtDate_Students.Name = "dtDate_Students";
            this.dtDate_Students.Size = new System.Drawing.Size(200, 30);
            this.dtDate_Students.TabIndex = 42;
            // 
            // btnView_Students
            // 
            this.btnView_Students.ActiveControl = null;
            this.btnView_Students.Location = new System.Drawing.Point(469, 100);
            this.btnView_Students.Name = "btnView_Students";
            this.btnView_Students.Size = new System.Drawing.Size(250, 50);
            this.btnView_Students.TabIndex = 43;
            this.btnView_Students.Text = "View";
            this.btnView_Students.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnView_Students.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnView_Students.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnView_Students.UseSelectable = true;
            // 
            // lblSection_Students
            // 
            this.lblSection_Students.AutoSize = true;
            this.lblSection_Students.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSection_Students.Location = new System.Drawing.Point(50, 100);
            this.lblSection_Students.Name = "lblSection_Students";
            this.lblSection_Students.Size = new System.Drawing.Size(70, 25);
            this.lblSection_Students.TabIndex = 44;
            this.lblSection_Students.Text = "Section";
            // 
            // btnMark_Students
            // 
            this.btnMark_Students.ActiveControl = null;
            this.btnMark_Students.Location = new System.Drawing.Point(300, 400);
            this.btnMark_Students.Name = "btnMark_Students";
            this.btnMark_Students.Size = new System.Drawing.Size(250, 50);
            this.btnMark_Students.TabIndex = 45;
            this.btnMark_Students.Text = "Mark";
            this.btnMark_Students.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMark_Students.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnMark_Students.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnMark_Students.UseSelectable = true;
            // 
            // cbSection_Students
            // 
            this.cbSection_Students.FormattingEnabled = true;
            this.cbSection_Students.ItemHeight = 24;
            this.cbSection_Students.Location = new System.Drawing.Point(150, 100);
            this.cbSection_Students.Name = "cbSection_Students";
            this.cbSection_Students.Size = new System.Drawing.Size(200, 30);
            this.cbSection_Students.TabIndex = 46;
            this.cbSection_Students.UseSelectable = true;
            // 
            // lblDate_Students
            // 
            this.lblDate_Students.AutoSize = true;
            this.lblDate_Students.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDate_Students.Location = new System.Drawing.Point(450, 50);
            this.lblDate_Students.Name = "lblDate_Students";
            this.lblDate_Students.Size = new System.Drawing.Size(50, 25);
            this.lblDate_Students.TabIndex = 47;
            this.lblDate_Students.Text = "Date";
            // 
            // dgvClassStudents_Students
            // 
            this.dgvClassStudents_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassStudents_Students.Location = new System.Drawing.Point(0, 161);
            this.dgvClassStudents_Students.Name = "dgvClassStudents_Students";
            this.dgvClassStudents_Students.RowTemplate.Height = 24;
            this.dgvClassStudents_Students.Size = new System.Drawing.Size(845, 218);
            this.dgvClassStudents_Students.TabIndex = 48;
            // 
            // lblTeacherID_Teachers
            // 
            this.lblTeacherID_Teachers.AutoSize = true;
            this.lblTeacherID_Teachers.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTeacherID_Teachers.Location = new System.Drawing.Point(33, 50);
            this.lblTeacherID_Teachers.Name = "lblTeacherID_Teachers";
            this.lblTeacherID_Teachers.Size = new System.Drawing.Size(94, 25);
            this.lblTeacherID_Teachers.TabIndex = 6;
            this.lblTeacherID_Teachers.Text = "Teacher ID";
            // 
            // txtTeacherID_Teachers
            // 
            // 
            // 
            // 
            this.txtTeacherID_Teachers.CustomButton.Image = null;
            this.txtTeacherID_Teachers.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtTeacherID_Teachers.CustomButton.Name = "";
            this.txtTeacherID_Teachers.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTeacherID_Teachers.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTeacherID_Teachers.CustomButton.TabIndex = 1;
            this.txtTeacherID_Teachers.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTeacherID_Teachers.CustomButton.UseSelectable = true;
            this.txtTeacherID_Teachers.CustomButton.Visible = false;
            this.txtTeacherID_Teachers.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTeacherID_Teachers.Lines = new string[0];
            this.txtTeacherID_Teachers.Location = new System.Drawing.Point(150, 50);
            this.txtTeacherID_Teachers.MaxLength = 32767;
            this.txtTeacherID_Teachers.Name = "txtTeacherID_Teachers";
            this.txtTeacherID_Teachers.PasswordChar = '\0';
            this.txtTeacherID_Teachers.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTeacherID_Teachers.SelectedText = "";
            this.txtTeacherID_Teachers.SelectionLength = 0;
            this.txtTeacherID_Teachers.SelectionStart = 0;
            this.txtTeacherID_Teachers.ShortcutsEnabled = true;
            this.txtTeacherID_Teachers.Size = new System.Drawing.Size(200, 30);
            this.txtTeacherID_Teachers.TabIndex = 7;
            this.txtTeacherID_Teachers.UseSelectable = true;
            this.txtTeacherID_Teachers.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTeacherID_Teachers.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtDate_Teachers
            // 
            this.dtDate_Teachers.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate_Teachers.Location = new System.Drawing.Point(450, 50);
            this.dtDate_Teachers.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtDate_Teachers.Name = "dtDate_Teachers";
            this.dtDate_Teachers.Size = new System.Drawing.Size(200, 30);
            this.dtDate_Teachers.TabIndex = 42;
            // 
            // btnView_Teachers
            // 
            this.btnView_Teachers.ActiveControl = null;
            this.btnView_Teachers.Location = new System.Drawing.Point(575, 97);
            this.btnView_Teachers.Name = "btnView_Teachers";
            this.btnView_Teachers.Size = new System.Drawing.Size(250, 50);
            this.btnView_Teachers.TabIndex = 43;
            this.btnView_Teachers.Text = "View";
            this.btnView_Teachers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnView_Teachers.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnView_Teachers.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnView_Teachers.UseSelectable = true;
            // 
            // lblDate_Teachers
            // 
            this.lblDate_Teachers.AutoSize = true;
            this.lblDate_Teachers.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDate_Teachers.Location = new System.Drawing.Point(387, 50);
            this.lblDate_Teachers.Name = "lblDate_Teachers";
            this.lblDate_Teachers.Size = new System.Drawing.Size(50, 25);
            this.lblDate_Teachers.TabIndex = 44;
            this.lblDate_Teachers.Text = "Date";
            // 
            // btnMark_Teachers
            // 
            this.btnMark_Teachers.ActiveControl = null;
            this.btnMark_Teachers.Location = new System.Drawing.Point(300, 400);
            this.btnMark_Teachers.Name = "btnMark_Teachers";
            this.btnMark_Teachers.Size = new System.Drawing.Size(250, 50);
            this.btnMark_Teachers.TabIndex = 45;
            this.btnMark_Teachers.Text = "Mark";
            this.btnMark_Teachers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMark_Teachers.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnMark_Teachers.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnMark_Teachers.UseSelectable = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(845, 218);
            this.dataGridView1.TabIndex = 49;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.metroTabControl1.ResumeLayout(false);
            this.tabStudents.ResumeLayout(false);
            this.tabStudents.PerformLayout();
            this.tabTeachers.ResumeLayout(false);
            this.tabTeachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassStudents_Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabStudents;
        private MetroFramework.Controls.MetroTabPage tabTeachers;
        private MetroFramework.Controls.MetroLabel lblClass_Students;
        private MetroFramework.Controls.MetroComboBox cbClass_Students;
        private MetroFramework.Controls.MetroDateTime dtDate_Students;
        private System.Windows.Forms.DataGridView dgvClassStudents_Students;
        private MetroFramework.Controls.MetroLabel lblDate_Students;
        private MetroFramework.Controls.MetroComboBox cbSection_Students;
        private MetroFramework.Controls.MetroTile btnMark_Students;
        private MetroFramework.Controls.MetroLabel lblSection_Students;
        private MetroFramework.Controls.MetroTile btnView_Students;
        private MetroFramework.Controls.MetroLabel lblTeacherID_Teachers;
        private MetroFramework.Controls.MetroTextBox txtTeacherID_Teachers;
        private MetroFramework.Controls.MetroDateTime dtDate_Teachers;
        private MetroFramework.Controls.MetroTile btnView_Teachers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTile btnMark_Teachers;
        private MetroFramework.Controls.MetroLabel lblDate_Teachers;
    }
}