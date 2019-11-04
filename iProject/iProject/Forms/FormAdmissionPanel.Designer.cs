namespace iProject.Forms {
    partial class FormAdmissionPanel {
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
            this.btnEmployee_AdmissionPanel = new MetroFramework.Controls.MetroTile();
            this.btnStudent_AdmissionPanel = new MetroFramework.Controls.MetroTile();
            this.btnClass_AdmissionPanel = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnEmployee_AdmissionPanel
            // 
            this.btnEmployee_AdmissionPanel.ActiveControl = null;
            this.btnEmployee_AdmissionPanel.Location = new System.Drawing.Point(250, 120);
            this.btnEmployee_AdmissionPanel.Name = "btnEmployee_AdmissionPanel";
            this.btnEmployee_AdmissionPanel.Size = new System.Drawing.Size(170, 180);
            this.btnEmployee_AdmissionPanel.TabIndex = 1;
            this.btnEmployee_AdmissionPanel.Text = "Employee";
            this.btnEmployee_AdmissionPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployee_AdmissionPanel.TileImage = global::iProject.Properties.Resources.EmployeeIcon;
            this.btnEmployee_AdmissionPanel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmployee_AdmissionPanel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnEmployee_AdmissionPanel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnEmployee_AdmissionPanel.UseSelectable = true;
            this.btnEmployee_AdmissionPanel.UseTileImage = true;
            this.btnEmployee_AdmissionPanel.Click += new System.EventHandler(this.btnEmployee_AdmissionPanel_Click);
            // 
            // btnStudent_AdmissionPanel
            // 
            this.btnStudent_AdmissionPanel.ActiveControl = null;
            this.btnStudent_AdmissionPanel.Location = new System.Drawing.Point(450, 120);
            this.btnStudent_AdmissionPanel.Name = "btnStudent_AdmissionPanel";
            this.btnStudent_AdmissionPanel.Size = new System.Drawing.Size(170, 180);
            this.btnStudent_AdmissionPanel.TabIndex = 3;
            this.btnStudent_AdmissionPanel.Text = "Students";
            this.btnStudent_AdmissionPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudent_AdmissionPanel.TileImage = global::iProject.Properties.Resources.StudentIcon;
            this.btnStudent_AdmissionPanel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStudent_AdmissionPanel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnStudent_AdmissionPanel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnStudent_AdmissionPanel.UseSelectable = true;
            this.btnStudent_AdmissionPanel.UseTileImage = true;
            this.btnStudent_AdmissionPanel.Click += new System.EventHandler(this.btnStudent_AdmissionPanel_Click);
            // 
            // btnClass_AdmissionPanel
            // 
            this.btnClass_AdmissionPanel.ActiveControl = null;
            this.btnClass_AdmissionPanel.Location = new System.Drawing.Point(350, 320);
            this.btnClass_AdmissionPanel.Name = "btnClass_AdmissionPanel";
            this.btnClass_AdmissionPanel.Size = new System.Drawing.Size(170, 180);
            this.btnClass_AdmissionPanel.TabIndex = 4;
            this.btnClass_AdmissionPanel.Text = "Classes";
            this.btnClass_AdmissionPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClass_AdmissionPanel.TileImage = global::iProject.Properties.Resources.ClassIcon;
            this.btnClass_AdmissionPanel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClass_AdmissionPanel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnClass_AdmissionPanel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnClass_AdmissionPanel.UseSelectable = true;
            this.btnClass_AdmissionPanel.UseTileImage = true;
            this.btnClass_AdmissionPanel.Click += new System.EventHandler(this.btnClass_AdmissionPanel_Click);
            // 
            // FormAdmissionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.btnClass_AdmissionPanel);
            this.Controls.Add(this.btnStudent_AdmissionPanel);
            this.Controls.Add(this.btnEmployee_AdmissionPanel);
            this.Name = "FormAdmissionPanel";
            this.Text = "Admission / HR Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnEmployee_AdmissionPanel;
        private MetroFramework.Controls.MetroTile btnStudent_AdmissionPanel;
        private MetroFramework.Controls.MetroTile btnClass_AdmissionPanel;
    }
}