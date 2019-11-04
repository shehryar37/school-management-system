namespace iProject.Forms {
    partial class FormTeacherPanel {
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
            this.btnStudent_TeacherPanel = new MetroFramework.Controls.MetroTile();
            this.btnClass_TeacherPanel = new MetroFramework.Controls.MetroTile();
            this.btnAttendance_TeacherPanel = new MetroFramework.Controls.MetroTile();
            this.btnReports_TeacherPanel = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnStudent_TeacherPanel
            // 
            this.btnStudent_TeacherPanel.ActiveControl = null;
            this.btnStudent_TeacherPanel.Location = new System.Drawing.Point(250, 120);
            this.btnStudent_TeacherPanel.Name = "btnStudent_TeacherPanel";
            this.btnStudent_TeacherPanel.Size = new System.Drawing.Size(170, 180);
            this.btnStudent_TeacherPanel.TabIndex = 3;
            this.btnStudent_TeacherPanel.Text = "Students";
            this.btnStudent_TeacherPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudent_TeacherPanel.TileImage = global::iProject.Properties.Resources.StudentIcon;
            this.btnStudent_TeacherPanel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStudent_TeacherPanel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnStudent_TeacherPanel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnStudent_TeacherPanel.UseSelectable = true;
            this.btnStudent_TeacherPanel.UseTileImage = true;
            this.btnStudent_TeacherPanel.Click += new System.EventHandler(this.btnStudent_TeacherPanel_Click);
            // 
            // btnClass_TeacherPanel
            // 
            this.btnClass_TeacherPanel.ActiveControl = null;
            this.btnClass_TeacherPanel.Location = new System.Drawing.Point(450, 120);
            this.btnClass_TeacherPanel.Name = "btnClass_TeacherPanel";
            this.btnClass_TeacherPanel.Size = new System.Drawing.Size(170, 180);
            this.btnClass_TeacherPanel.TabIndex = 4;
            this.btnClass_TeacherPanel.Text = "Classes";
            this.btnClass_TeacherPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClass_TeacherPanel.TileImage = global::iProject.Properties.Resources.ClassIcon;
            this.btnClass_TeacherPanel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClass_TeacherPanel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnClass_TeacherPanel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnClass_TeacherPanel.UseSelectable = true;
            this.btnClass_TeacherPanel.UseTileImage = true;
            this.btnClass_TeacherPanel.Click += new System.EventHandler(this.btnClass_TeacherPanel_Click);
            // 
            // btnAttendance_TeacherPanel
            // 
            this.btnAttendance_TeacherPanel.ActiveControl = null;
            this.btnAttendance_TeacherPanel.Location = new System.Drawing.Point(250, 320);
            this.btnAttendance_TeacherPanel.Name = "btnAttendance_TeacherPanel";
            this.btnAttendance_TeacherPanel.Size = new System.Drawing.Size(170, 180);
            this.btnAttendance_TeacherPanel.TabIndex = 5;
            this.btnAttendance_TeacherPanel.Text = "Attendance";
            this.btnAttendance_TeacherPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAttendance_TeacherPanel.TileImage = global::iProject.Properties.Resources.AttendanceIcon;
            this.btnAttendance_TeacherPanel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAttendance_TeacherPanel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAttendance_TeacherPanel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAttendance_TeacherPanel.UseSelectable = true;
            this.btnAttendance_TeacherPanel.UseTileImage = true;
            this.btnAttendance_TeacherPanel.Click += new System.EventHandler(this.btnAttendance_TeacherPanel_Click);
            // 
            // btnReports_TeacherPanel
            // 
            this.btnReports_TeacherPanel.ActiveControl = null;
            this.btnReports_TeacherPanel.Location = new System.Drawing.Point(450, 320);
            this.btnReports_TeacherPanel.Name = "btnReports_TeacherPanel";
            this.btnReports_TeacherPanel.Size = new System.Drawing.Size(170, 180);
            this.btnReports_TeacherPanel.TabIndex = 6;
            this.btnReports_TeacherPanel.Text = "Reports";
            this.btnReports_TeacherPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports_TeacherPanel.TileImage = global::iProject.Properties.Resources.ReportIcon;
            this.btnReports_TeacherPanel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReports_TeacherPanel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnReports_TeacherPanel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnReports_TeacherPanel.UseSelectable = true;
            this.btnReports_TeacherPanel.UseTileImage = true;
            this.btnReports_TeacherPanel.Click += new System.EventHandler(this.btnReports_TeacherPanel_Click);
            // 
            // FormTeacherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.btnReports_TeacherPanel);
            this.Controls.Add(this.btnAttendance_TeacherPanel);
            this.Controls.Add(this.btnClass_TeacherPanel);
            this.Controls.Add(this.btnStudent_TeacherPanel);
            this.Name = "FormTeacherPanel";
            this.Text = "Teacher Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnStudent_TeacherPanel;
        private MetroFramework.Controls.MetroTile btnClass_TeacherPanel;
        private MetroFramework.Controls.MetroTile btnAttendance_TeacherPanel;
        private MetroFramework.Controls.MetroTile btnReports_TeacherPanel;
    }
}