namespace iProject.Forms {
    partial class FormAccountsPanel {
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
            this.btnEmployee_AccountsPanel = new MetroFramework.Controls.MetroTile();
            this.btnStudent_AccountsPanel = new MetroFramework.Controls.MetroTile();
            this.btnAccounts_AccountsPanel = new MetroFramework.Controls.MetroTile();
            this.btnReports_AccountsPanel = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnEmployee_AccountsPanel
            // 
            this.btnEmployee_AccountsPanel.ActiveControl = null;
            this.btnEmployee_AccountsPanel.Location = new System.Drawing.Point(250, 120);
            this.btnEmployee_AccountsPanel.Name = "btnEmployee_AccountsPanel";
            this.btnEmployee_AccountsPanel.Size = new System.Drawing.Size(170, 180);
            this.btnEmployee_AccountsPanel.TabIndex = 1;
            this.btnEmployee_AccountsPanel.Text = "Employee";
            this.btnEmployee_AccountsPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployee_AccountsPanel.TileImage = global::iProject.Properties.Resources.EmployeeIcon;
            this.btnEmployee_AccountsPanel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmployee_AccountsPanel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnEmployee_AccountsPanel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnEmployee_AccountsPanel.UseSelectable = true;
            this.btnEmployee_AccountsPanel.UseTileImage = true;
            this.btnEmployee_AccountsPanel.Click += new System.EventHandler(this.btnEmployee_AccountsPanel_Click);
            // 
            // btnStudent_AccountsPanel
            // 
            this.btnStudent_AccountsPanel.ActiveControl = null;
            this.btnStudent_AccountsPanel.Location = new System.Drawing.Point(450, 120);
            this.btnStudent_AccountsPanel.Name = "btnStudent_AccountsPanel";
            this.btnStudent_AccountsPanel.Size = new System.Drawing.Size(170, 180);
            this.btnStudent_AccountsPanel.TabIndex = 3;
            this.btnStudent_AccountsPanel.Text = "Students";
            this.btnStudent_AccountsPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudent_AccountsPanel.TileImage = global::iProject.Properties.Resources.StudentIcon;
            this.btnStudent_AccountsPanel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStudent_AccountsPanel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnStudent_AccountsPanel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnStudent_AccountsPanel.UseSelectable = true;
            this.btnStudent_AccountsPanel.UseTileImage = true;
            this.btnStudent_AccountsPanel.Click += new System.EventHandler(this.btnStudent_AccountsPanel_Click);
            // 
            // btnAccounts_AccountsPanel
            // 
            this.btnAccounts_AccountsPanel.ActiveControl = null;
            this.btnAccounts_AccountsPanel.Location = new System.Drawing.Point(250, 320);
            this.btnAccounts_AccountsPanel.Name = "btnAccounts_AccountsPanel";
            this.btnAccounts_AccountsPanel.Size = new System.Drawing.Size(170, 180);
            this.btnAccounts_AccountsPanel.TabIndex = 5;
            this.btnAccounts_AccountsPanel.Text = "Accounts";
            this.btnAccounts_AccountsPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccounts_AccountsPanel.TileImage = global::iProject.Properties.Resources.AccountsIcon;
            this.btnAccounts_AccountsPanel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAccounts_AccountsPanel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAccounts_AccountsPanel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAccounts_AccountsPanel.UseSelectable = true;
            this.btnAccounts_AccountsPanel.UseTileImage = true;
            this.btnAccounts_AccountsPanel.Click += new System.EventHandler(this.btnAccounts_AccountsPanel_Click);
            // 
            // btnReports_AccountsPanel
            // 
            this.btnReports_AccountsPanel.ActiveControl = null;
            this.btnReports_AccountsPanel.Location = new System.Drawing.Point(450, 320);
            this.btnReports_AccountsPanel.Name = "btnReports_AccountsPanel";
            this.btnReports_AccountsPanel.Size = new System.Drawing.Size(170, 180);
            this.btnReports_AccountsPanel.TabIndex = 6;
            this.btnReports_AccountsPanel.Text = "Reports";
            this.btnReports_AccountsPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports_AccountsPanel.TileImage = global::iProject.Properties.Resources.ReportIcon;
            this.btnReports_AccountsPanel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReports_AccountsPanel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnReports_AccountsPanel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnReports_AccountsPanel.UseSelectable = true;
            this.btnReports_AccountsPanel.UseTileImage = true;
            this.btnReports_AccountsPanel.Click += new System.EventHandler(this.btnReports_AccountsPanel_Click);
            // 
            // FormAccountsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.btnReports_AccountsPanel);
            this.Controls.Add(this.btnAccounts_AccountsPanel);
            this.Controls.Add(this.btnStudent_AccountsPanel);
            this.Controls.Add(this.btnEmployee_AccountsPanel);
            this.Name = "FormAccountsPanel";
            this.Text = "Accounts Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnEmployee_AccountsPanel;
        private MetroFramework.Controls.MetroTile btnStudent_AccountsPanel;
        private MetroFramework.Controls.MetroTile btnAccounts_AccountsPanel;
        private MetroFramework.Controls.MetroTile btnReports_AccountsPanel;
    }
}