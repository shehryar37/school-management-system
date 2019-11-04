namespace iProject.Forms {
    partial class Employee {
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
            this.tcEmployee = new MetroFramework.Controls.MetroTabControl();
            this.tabAddEmployee = new MetroFramework.Controls.MetroTabPage();
            this.cbStatus_AE = new MetroFramework.Controls.MetroComboBox();
            this.txtQualification_AE = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail_AE = new MetroFramework.Controls.MetroTextBox();
            this.rbUnmarried_AE = new MetroFramework.Controls.MetroRadioButton();
            this.rbMarried_AE = new MetroFramework.Controls.MetroRadioButton();
            this.txtPhoneNumber_AE = new MetroFramework.Controls.MetroTextBox();
            this.txtCity_AE = new MetroFramework.Controls.MetroTextBox();
            this.txtFatherName_AE = new MetroFramework.Controls.MetroTextBox();
            this.lblStatus_AE = new MetroFramework.Controls.MetroLabel();
            this.lblCity_AE = new MetroFramework.Controls.MetroLabel();
            this.lblJoiningDate_AE = new MetroFramework.Controls.MetroLabel();
            this.lblReligion_AE = new MetroFramework.Controls.MetroLabel();
            this.lblMaritalStatus_AE = new MetroFramework.Controls.MetroLabel();
            this.lblAddress_AE = new MetroFramework.Controls.MetroLabel();
            this.lblNationality_AE = new MetroFramework.Controls.MetroLabel();
            this.lblPhoneNumber_AE = new MetroFramework.Controls.MetroLabel();
            this.lblEmail_AE = new MetroFramework.Controls.MetroLabel();
            this.lblQualification_AE = new MetroFramework.Controls.MetroLabel();
            this.lblEmployeeType_AE = new MetroFramework.Controls.MetroLabel();
            this.lblFathersName_AE = new MetroFramework.Controls.MetroLabel();
            this.btnAdd_AE = new MetroFramework.Controls.MetroTile();
            this.txtAddress_AE = new MetroFramework.Controls.MetroTextBox();
            this.lblGender_AE = new MetroFramework.Controls.MetroLabel();
            this.dtJoiningDate_AE = new MetroFramework.Controls.MetroDateTime();
            this.txtName_AE = new MetroFramework.Controls.MetroTextBox();
            this.lblName_AE = new MetroFramework.Controls.MetroLabel();
            this.tabUpdateEmployee = new MetroFramework.Controls.MetroTabPage();
            this.tabDeleteEmployee = new MetroFramework.Controls.MetroTabPage();
            this.txtReligion_AE = new MetroFramework.Controls.MetroTextBox();
            this.rbPakistani_AE = new MetroFramework.Controls.MetroRadioButton();
            this.rbOther_AE = new MetroFramework.Controls.MetroRadioButton();
            this.cbType_AE = new MetroFramework.Controls.MetroComboBox();
            this.rbFemale_AE = new MetroFramework.Controls.MetroRadioButton();
            this.rbMale_AE = new MetroFramework.Controls.MetroRadioButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.tcEmployee.SuspendLayout();
            this.tabAddEmployee.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcEmployee
            // 
            this.tcEmployee.Controls.Add(this.tabAddEmployee);
            this.tcEmployee.Controls.Add(this.tabUpdateEmployee);
            this.tcEmployee.Controls.Add(this.tabDeleteEmployee);
            this.tcEmployee.Location = new System.Drawing.Point(18, 60);
            this.tcEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcEmployee.Name = "tcEmployee";
            this.tcEmployee.SelectedIndex = 0;
            this.tcEmployee.Size = new System.Drawing.Size(640, 449);
            this.tcEmployee.TabIndex = 0;
            this.tcEmployee.UseSelectable = true;
            // 
            // tabAddEmployee
            // 
            this.tabAddEmployee.Controls.Add(this.metroPanel3);
            this.tabAddEmployee.Controls.Add(this.metroPanel2);
            this.tabAddEmployee.Controls.Add(this.metroPanel1);
            this.tabAddEmployee.Controls.Add(this.cbType_AE);
            this.tabAddEmployee.Controls.Add(this.txtReligion_AE);
            this.tabAddEmployee.Controls.Add(this.cbStatus_AE);
            this.tabAddEmployee.Controls.Add(this.txtQualification_AE);
            this.tabAddEmployee.Controls.Add(this.txtEmail_AE);
            this.tabAddEmployee.Controls.Add(this.txtPhoneNumber_AE);
            this.tabAddEmployee.Controls.Add(this.txtCity_AE);
            this.tabAddEmployee.Controls.Add(this.txtFatherName_AE);
            this.tabAddEmployee.Controls.Add(this.lblStatus_AE);
            this.tabAddEmployee.Controls.Add(this.lblCity_AE);
            this.tabAddEmployee.Controls.Add(this.lblJoiningDate_AE);
            this.tabAddEmployee.Controls.Add(this.lblReligion_AE);
            this.tabAddEmployee.Controls.Add(this.lblMaritalStatus_AE);
            this.tabAddEmployee.Controls.Add(this.lblAddress_AE);
            this.tabAddEmployee.Controls.Add(this.lblNationality_AE);
            this.tabAddEmployee.Controls.Add(this.lblPhoneNumber_AE);
            this.tabAddEmployee.Controls.Add(this.lblEmail_AE);
            this.tabAddEmployee.Controls.Add(this.lblQualification_AE);
            this.tabAddEmployee.Controls.Add(this.lblEmployeeType_AE);
            this.tabAddEmployee.Controls.Add(this.lblFathersName_AE);
            this.tabAddEmployee.Controls.Add(this.btnAdd_AE);
            this.tabAddEmployee.Controls.Add(this.txtAddress_AE);
            this.tabAddEmployee.Controls.Add(this.lblGender_AE);
            this.tabAddEmployee.Controls.Add(this.dtJoiningDate_AE);
            this.tabAddEmployee.Controls.Add(this.txtName_AE);
            this.tabAddEmployee.Controls.Add(this.lblName_AE);
            this.tabAddEmployee.HorizontalScrollbarBarColor = true;
            this.tabAddEmployee.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAddEmployee.HorizontalScrollbarSize = 8;
            this.tabAddEmployee.Location = new System.Drawing.Point(4, 38);
            this.tabAddEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabAddEmployee.Name = "tabAddEmployee";
            this.tabAddEmployee.Size = new System.Drawing.Size(632, 407);
            this.tabAddEmployee.TabIndex = 0;
            this.tabAddEmployee.Text = " Add Employee ";
            this.tabAddEmployee.VerticalScrollbarBarColor = true;
            this.tabAddEmployee.VerticalScrollbarHighlightOnWheel = false;
            this.tabAddEmployee.VerticalScrollbarSize = 8;
            // 
            // cbStatus_AE
            // 
            this.cbStatus_AE.FormattingEnabled = true;
            this.cbStatus_AE.ItemHeight = 23;
            this.cbStatus_AE.Location = new System.Drawing.Point(112, 283);
            this.cbStatus_AE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStatus_AE.Name = "cbStatus_AE";
            this.cbStatus_AE.Size = new System.Drawing.Size(150, 29);
            this.cbStatus_AE.TabIndex = 128;
            this.cbStatus_AE.UseSelectable = true;
            // 
            // txtQualification_AE
            // 
            // 
            // 
            // 
            this.txtQualification_AE.CustomButton.Image = null;
            this.txtQualification_AE.CustomButton.Location = new System.Drawing.Point(110, 2);
            this.txtQualification_AE.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQualification_AE.CustomButton.Name = "";
            this.txtQualification_AE.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.txtQualification_AE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQualification_AE.CustomButton.TabIndex = 1;
            this.txtQualification_AE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQualification_AE.CustomButton.UseSelectable = true;
            this.txtQualification_AE.CustomButton.Visible = false;
            this.txtQualification_AE.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtQualification_AE.Lines = new string[0];
            this.txtQualification_AE.Location = new System.Drawing.Point(435, 162);
            this.txtQualification_AE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQualification_AE.MaxLength = 32767;
            this.txtQualification_AE.Name = "txtQualification_AE";
            this.txtQualification_AE.PasswordChar = '\0';
            this.txtQualification_AE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQualification_AE.SelectedText = "";
            this.txtQualification_AE.SelectionLength = 0;
            this.txtQualification_AE.SelectionStart = 0;
            this.txtQualification_AE.ShortcutsEnabled = true;
            this.txtQualification_AE.Size = new System.Drawing.Size(150, 24);
            this.txtQualification_AE.TabIndex = 126;
            this.txtQualification_AE.UseSelectable = true;
            this.txtQualification_AE.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQualification_AE.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmail_AE
            // 
            // 
            // 
            // 
            this.txtEmail_AE.CustomButton.Image = null;
            this.txtEmail_AE.CustomButton.Location = new System.Drawing.Point(110, 2);
            this.txtEmail_AE.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail_AE.CustomButton.Name = "";
            this.txtEmail_AE.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.txtEmail_AE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail_AE.CustomButton.TabIndex = 1;
            this.txtEmail_AE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail_AE.CustomButton.UseSelectable = true;
            this.txtEmail_AE.CustomButton.Visible = false;
            this.txtEmail_AE.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEmail_AE.Lines = new string[0];
            this.txtEmail_AE.Location = new System.Drawing.Point(112, 161);
            this.txtEmail_AE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail_AE.MaxLength = 32767;
            this.txtEmail_AE.Name = "txtEmail_AE";
            this.txtEmail_AE.PasswordChar = '\0';
            this.txtEmail_AE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail_AE.SelectedText = "";
            this.txtEmail_AE.SelectionLength = 0;
            this.txtEmail_AE.SelectionStart = 0;
            this.txtEmail_AE.ShortcutsEnabled = true;
            this.txtEmail_AE.Size = new System.Drawing.Size(150, 24);
            this.txtEmail_AE.TabIndex = 124;
            this.txtEmail_AE.UseSelectable = true;
            this.txtEmail_AE.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail_AE.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbUnmarried_AE
            // 
            this.rbUnmarried_AE.AutoSize = true;
            this.rbUnmarried_AE.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbUnmarried_AE.Location = new System.Drawing.Point(76, 0);
            this.rbUnmarried_AE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbUnmarried_AE.Name = "rbUnmarried_AE";
            this.rbUnmarried_AE.Size = new System.Drawing.Size(111, 25);
            this.rbUnmarried_AE.TabIndex = 123;
            this.rbUnmarried_AE.Text = "Unmarried";
            this.rbUnmarried_AE.UseSelectable = true;
            // 
            // rbMarried_AE
            // 
            this.rbMarried_AE.AutoSize = true;
            this.rbMarried_AE.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbMarried_AE.Location = new System.Drawing.Point(0, 0);
            this.rbMarried_AE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMarried_AE.Name = "rbMarried_AE";
            this.rbMarried_AE.Size = new System.Drawing.Size(89, 25);
            this.rbMarried_AE.TabIndex = 122;
            this.rbMarried_AE.Text = "Married";
            this.rbMarried_AE.UseSelectable = true;
            // 
            // txtPhoneNumber_AE
            // 
            // 
            // 
            // 
            this.txtPhoneNumber_AE.CustomButton.Image = null;
            this.txtPhoneNumber_AE.CustomButton.Location = new System.Drawing.Point(110, 2);
            this.txtPhoneNumber_AE.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhoneNumber_AE.CustomButton.Name = "";
            this.txtPhoneNumber_AE.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.txtPhoneNumber_AE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhoneNumber_AE.CustomButton.TabIndex = 1;
            this.txtPhoneNumber_AE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhoneNumber_AE.CustomButton.UseSelectable = true;
            this.txtPhoneNumber_AE.CustomButton.Visible = false;
            this.txtPhoneNumber_AE.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPhoneNumber_AE.Lines = new string[0];
            this.txtPhoneNumber_AE.Location = new System.Drawing.Point(435, 244);
            this.txtPhoneNumber_AE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhoneNumber_AE.MaxLength = 32767;
            this.txtPhoneNumber_AE.Name = "txtPhoneNumber_AE";
            this.txtPhoneNumber_AE.PasswordChar = '\0';
            this.txtPhoneNumber_AE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhoneNumber_AE.SelectedText = "";
            this.txtPhoneNumber_AE.SelectionLength = 0;
            this.txtPhoneNumber_AE.SelectionStart = 0;
            this.txtPhoneNumber_AE.ShortcutsEnabled = true;
            this.txtPhoneNumber_AE.Size = new System.Drawing.Size(150, 24);
            this.txtPhoneNumber_AE.TabIndex = 121;
            this.txtPhoneNumber_AE.UseSelectable = true;
            this.txtPhoneNumber_AE.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhoneNumber_AE.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCity_AE
            // 
            // 
            // 
            // 
            this.txtCity_AE.CustomButton.Image = null;
            this.txtCity_AE.CustomButton.Location = new System.Drawing.Point(110, 2);
            this.txtCity_AE.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCity_AE.CustomButton.Name = "";
            this.txtCity_AE.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.txtCity_AE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCity_AE.CustomButton.TabIndex = 1;
            this.txtCity_AE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCity_AE.CustomButton.UseSelectable = true;
            this.txtCity_AE.CustomButton.Visible = false;
            this.txtCity_AE.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCity_AE.Lines = new string[0];
            this.txtCity_AE.Location = new System.Drawing.Point(112, 81);
            this.txtCity_AE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCity_AE.MaxLength = 32767;
            this.txtCity_AE.Name = "txtCity_AE";
            this.txtCity_AE.PasswordChar = '\0';
            this.txtCity_AE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCity_AE.SelectedText = "";
            this.txtCity_AE.SelectionLength = 0;
            this.txtCity_AE.SelectionStart = 0;
            this.txtCity_AE.ShortcutsEnabled = true;
            this.txtCity_AE.Size = new System.Drawing.Size(150, 24);
            this.txtCity_AE.TabIndex = 120;
            this.txtCity_AE.UseSelectable = true;
            this.txtCity_AE.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCity_AE.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFatherName_AE
            // 
            // 
            // 
            // 
            this.txtFatherName_AE.CustomButton.Image = null;
            this.txtFatherName_AE.CustomButton.Location = new System.Drawing.Point(110, 2);
            this.txtFatherName_AE.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFatherName_AE.CustomButton.Name = "";
            this.txtFatherName_AE.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.txtFatherName_AE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFatherName_AE.CustomButton.TabIndex = 1;
            this.txtFatherName_AE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFatherName_AE.CustomButton.UseSelectable = true;
            this.txtFatherName_AE.CustomButton.Visible = false;
            this.txtFatherName_AE.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtFatherName_AE.Lines = new string[0];
            this.txtFatherName_AE.Location = new System.Drawing.Point(435, 41);
            this.txtFatherName_AE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFatherName_AE.MaxLength = 32767;
            this.txtFatherName_AE.Name = "txtFatherName_AE";
            this.txtFatherName_AE.PasswordChar = '\0';
            this.txtFatherName_AE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFatherName_AE.SelectedText = "";
            this.txtFatherName_AE.SelectionLength = 0;
            this.txtFatherName_AE.SelectionStart = 0;
            this.txtFatherName_AE.ShortcutsEnabled = true;
            this.txtFatherName_AE.Size = new System.Drawing.Size(150, 24);
            this.txtFatherName_AE.TabIndex = 119;
            this.txtFatherName_AE.UseSelectable = true;
            this.txtFatherName_AE.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFatherName_AE.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblStatus_AE
            // 
            this.lblStatus_AE.AutoSize = true;
            this.lblStatus_AE.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblStatus_AE.Location = new System.Drawing.Point(22, 283);
            this.lblStatus_AE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus_AE.Name = "lblStatus_AE";
            this.lblStatus_AE.Size = new System.Drawing.Size(57, 25);
            this.lblStatus_AE.TabIndex = 118;
            this.lblStatus_AE.Text = "Status";
            // 
            // lblCity_AE
            // 
            this.lblCity_AE.AutoSize = true;
            this.lblCity_AE.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCity_AE.Location = new System.Drawing.Point(22, 81);
            this.lblCity_AE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity_AE.Name = "lblCity_AE";
            this.lblCity_AE.Size = new System.Drawing.Size(40, 25);
            this.lblCity_AE.TabIndex = 116;
            this.lblCity_AE.Text = "City";
            // 
            // lblJoiningDate_AE
            // 
            this.lblJoiningDate_AE.AutoSize = true;
            this.lblJoiningDate_AE.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblJoiningDate_AE.Location = new System.Drawing.Point(300, 81);
            this.lblJoiningDate_AE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJoiningDate_AE.Name = "lblJoiningDate_AE";
            this.lblJoiningDate_AE.Size = new System.Drawing.Size(106, 25);
            this.lblJoiningDate_AE.TabIndex = 115;
            this.lblJoiningDate_AE.Text = "Joining Date";
            // 
            // lblReligion_AE
            // 
            this.lblReligion_AE.AutoSize = true;
            this.lblReligion_AE.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblReligion_AE.Location = new System.Drawing.Point(22, 243);
            this.lblReligion_AE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReligion_AE.Name = "lblReligion_AE";
            this.lblReligion_AE.Size = new System.Drawing.Size(73, 25);
            this.lblReligion_AE.TabIndex = 114;
            this.lblReligion_AE.Text = "Religion";
            // 
            // lblMaritalStatus_AE
            // 
            this.lblMaritalStatus_AE.AutoSize = true;
            this.lblMaritalStatus_AE.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblMaritalStatus_AE.Location = new System.Drawing.Point(300, 122);
            this.lblMaritalStatus_AE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaritalStatus_AE.Name = "lblMaritalStatus_AE";
            this.lblMaritalStatus_AE.Size = new System.Drawing.Size(114, 25);
            this.lblMaritalStatus_AE.TabIndex = 113;
            this.lblMaritalStatus_AE.Text = "Marital Status";
            // 
            // lblAddress_AE
            // 
            this.lblAddress_AE.AutoSize = true;
            this.lblAddress_AE.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAddress_AE.Location = new System.Drawing.Point(300, 284);
            this.lblAddress_AE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress_AE.Name = "lblAddress_AE";
            this.lblAddress_AE.Size = new System.Drawing.Size(72, 25);
            this.lblAddress_AE.TabIndex = 112;
            this.lblAddress_AE.Text = "Address";
            // 
            // lblNationality_AE
            // 
            this.lblNationality_AE.AutoSize = true;
            this.lblNationality_AE.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNationality_AE.Location = new System.Drawing.Point(22, 202);
            this.lblNationality_AE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNationality_AE.Name = "lblNationality_AE";
            this.lblNationality_AE.Size = new System.Drawing.Size(93, 25);
            this.lblNationality_AE.TabIndex = 111;
            this.lblNationality_AE.Text = "Nationality";
            // 
            // lblPhoneNumber_AE
            // 
            this.lblPhoneNumber_AE.AutoSize = true;
            this.lblPhoneNumber_AE.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPhoneNumber_AE.Location = new System.Drawing.Point(300, 244);
            this.lblPhoneNumber_AE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber_AE.Name = "lblPhoneNumber_AE";
            this.lblPhoneNumber_AE.Size = new System.Drawing.Size(129, 25);
            this.lblPhoneNumber_AE.TabIndex = 110;
            this.lblPhoneNumber_AE.Text = "Phone Number";
            // 
            // lblEmail_AE
            // 
            this.lblEmail_AE.AutoSize = true;
            this.lblEmail_AE.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEmail_AE.Location = new System.Drawing.Point(22, 161);
            this.lblEmail_AE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail_AE.Name = "lblEmail_AE";
            this.lblEmail_AE.Size = new System.Drawing.Size(53, 25);
            this.lblEmail_AE.TabIndex = 109;
            this.lblEmail_AE.Text = "Email";
            // 
            // lblQualification_AE
            // 
            this.lblQualification_AE.AutoSize = true;
            this.lblQualification_AE.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblQualification_AE.Location = new System.Drawing.Point(300, 162);
            this.lblQualification_AE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQualification_AE.Name = "lblQualification_AE";
            this.lblQualification_AE.Size = new System.Drawing.Size(108, 25);
            this.lblQualification_AE.TabIndex = 108;
            this.lblQualification_AE.Text = "Qualification";
            // 
            // lblEmployeeType_AE
            // 
            this.lblEmployeeType_AE.AutoSize = true;
            this.lblEmployeeType_AE.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEmployeeType_AE.Location = new System.Drawing.Point(300, 203);
            this.lblEmployeeType_AE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeType_AE.Name = "lblEmployeeType_AE";
            this.lblEmployeeType_AE.Size = new System.Drawing.Size(125, 25);
            this.lblEmployeeType_AE.TabIndex = 107;
            this.lblEmployeeType_AE.Text = "Employee Type";
            // 
            // lblFathersName_AE
            // 
            this.lblFathersName_AE.AutoSize = true;
            this.lblFathersName_AE.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblFathersName_AE.Location = new System.Drawing.Point(300, 41);
            this.lblFathersName_AE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFathersName_AE.Name = "lblFathersName_AE";
            this.lblFathersName_AE.Size = new System.Drawing.Size(119, 25);
            this.lblFathersName_AE.TabIndex = 106;
            this.lblFathersName_AE.Text = "Father\'s Name";
            // 
            // btnAdd_AE
            // 
            this.btnAdd_AE.ActiveControl = null;
            this.btnAdd_AE.Location = new System.Drawing.Point(486, 364);
            this.btnAdd_AE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd_AE.Name = "btnAdd_AE";
            this.btnAdd_AE.Size = new System.Drawing.Size(144, 41);
            this.btnAdd_AE.TabIndex = 105;
            this.btnAdd_AE.Text = "Add";
            this.btnAdd_AE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd_AE.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAdd_AE.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAdd_AE.UseSelectable = true;
            this.btnAdd_AE.Click += new System.EventHandler(this.btnAdd_AE_Click);
            // 
            // txtAddress_AE
            // 
            // 
            // 
            // 
            this.txtAddress_AE.CustomButton.Image = null;
            this.txtAddress_AE.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txtAddress_AE.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress_AE.CustomButton.Name = "";
            this.txtAddress_AE.CustomButton.Size = new System.Drawing.Size(54, 55);
            this.txtAddress_AE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress_AE.CustomButton.TabIndex = 1;
            this.txtAddress_AE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress_AE.CustomButton.UseSelectable = true;
            this.txtAddress_AE.CustomButton.Visible = false;
            this.txtAddress_AE.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtAddress_AE.Lines = new string[0];
            this.txtAddress_AE.Location = new System.Drawing.Point(435, 284);
            this.txtAddress_AE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress_AE.MaxLength = 32767;
            this.txtAddress_AE.Multiline = true;
            this.txtAddress_AE.Name = "txtAddress_AE";
            this.txtAddress_AE.PasswordChar = '\0';
            this.txtAddress_AE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress_AE.SelectedText = "";
            this.txtAddress_AE.SelectionLength = 0;
            this.txtAddress_AE.SelectionStart = 0;
            this.txtAddress_AE.ShortcutsEnabled = true;
            this.txtAddress_AE.Size = new System.Drawing.Size(150, 65);
            this.txtAddress_AE.TabIndex = 104;
            this.txtAddress_AE.UseSelectable = true;
            this.txtAddress_AE.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress_AE.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblGender_AE
            // 
            this.lblGender_AE.AutoSize = true;
            this.lblGender_AE.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblGender_AE.Location = new System.Drawing.Point(22, 121);
            this.lblGender_AE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender_AE.Name = "lblGender_AE";
            this.lblGender_AE.Size = new System.Drawing.Size(68, 25);
            this.lblGender_AE.TabIndex = 101;
            this.lblGender_AE.Text = "Gender";
            // 
            // dtJoiningDate_AE
            // 
            this.dtJoiningDate_AE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtJoiningDate_AE.Location = new System.Drawing.Point(435, 81);
            this.dtJoiningDate_AE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtJoiningDate_AE.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtJoiningDate_AE.Name = "dtJoiningDate_AE";
            this.dtJoiningDate_AE.Size = new System.Drawing.Size(151, 29);
            this.dtJoiningDate_AE.TabIndex = 96;
            // 
            // txtName_AE
            // 
            // 
            // 
            // 
            this.txtName_AE.CustomButton.Image = null;
            this.txtName_AE.CustomButton.Location = new System.Drawing.Point(110, 2);
            this.txtName_AE.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName_AE.CustomButton.Name = "";
            this.txtName_AE.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.txtName_AE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName_AE.CustomButton.TabIndex = 1;
            this.txtName_AE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName_AE.CustomButton.UseSelectable = true;
            this.txtName_AE.CustomButton.Visible = false;
            this.txtName_AE.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtName_AE.Lines = new string[0];
            this.txtName_AE.Location = new System.Drawing.Point(112, 41);
            this.txtName_AE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName_AE.MaxLength = 32767;
            this.txtName_AE.Name = "txtName_AE";
            this.txtName_AE.PasswordChar = '\0';
            this.txtName_AE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName_AE.SelectedText = "";
            this.txtName_AE.SelectionLength = 0;
            this.txtName_AE.SelectionStart = 0;
            this.txtName_AE.ShortcutsEnabled = true;
            this.txtName_AE.Size = new System.Drawing.Size(150, 24);
            this.txtName_AE.TabIndex = 75;
            this.txtName_AE.UseSelectable = true;
            this.txtName_AE.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName_AE.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblName_AE
            // 
            this.lblName_AE.AutoSize = true;
            this.lblName_AE.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblName_AE.Location = new System.Drawing.Point(22, 41);
            this.lblName_AE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName_AE.Name = "lblName_AE";
            this.lblName_AE.Size = new System.Drawing.Size(58, 25);
            this.lblName_AE.TabIndex = 74;
            this.lblName_AE.Text = "Name";
            // 
            // tabUpdateEmployee
            // 
            this.tabUpdateEmployee.HorizontalScrollbarBarColor = true;
            this.tabUpdateEmployee.HorizontalScrollbarHighlightOnWheel = false;
            this.tabUpdateEmployee.HorizontalScrollbarSize = 8;
            this.tabUpdateEmployee.Location = new System.Drawing.Point(4, 38);
            this.tabUpdateEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabUpdateEmployee.Name = "tabUpdateEmployee";
            this.tabUpdateEmployee.Size = new System.Drawing.Size(632, 407);
            this.tabUpdateEmployee.TabIndex = 1;
            this.tabUpdateEmployee.Text = " Update Employee ";
            this.tabUpdateEmployee.VerticalScrollbarBarColor = true;
            this.tabUpdateEmployee.VerticalScrollbarHighlightOnWheel = false;
            this.tabUpdateEmployee.VerticalScrollbarSize = 8;
            // 
            // tabDeleteEmployee
            // 
            this.tabDeleteEmployee.HorizontalScrollbarBarColor = true;
            this.tabDeleteEmployee.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDeleteEmployee.HorizontalScrollbarSize = 8;
            this.tabDeleteEmployee.Location = new System.Drawing.Point(4, 38);
            this.tabDeleteEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDeleteEmployee.Name = "tabDeleteEmployee";
            this.tabDeleteEmployee.Size = new System.Drawing.Size(632, 407);
            this.tabDeleteEmployee.TabIndex = 2;
            this.tabDeleteEmployee.Text = " Delete Employee ";
            this.tabDeleteEmployee.VerticalScrollbarBarColor = true;
            this.tabDeleteEmployee.VerticalScrollbarHighlightOnWheel = false;
            this.tabDeleteEmployee.VerticalScrollbarSize = 8;
            // 
            // txtReligion_AE
            // 
            // 
            // 
            // 
            this.txtReligion_AE.CustomButton.Image = null;
            this.txtReligion_AE.CustomButton.Location = new System.Drawing.Point(110, 2);
            this.txtReligion_AE.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtReligion_AE.CustomButton.Name = "";
            this.txtReligion_AE.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.txtReligion_AE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReligion_AE.CustomButton.TabIndex = 1;
            this.txtReligion_AE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReligion_AE.CustomButton.UseSelectable = true;
            this.txtReligion_AE.CustomButton.Visible = false;
            this.txtReligion_AE.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtReligion_AE.Lines = new string[0];
            this.txtReligion_AE.Location = new System.Drawing.Point(113, 244);
            this.txtReligion_AE.Margin = new System.Windows.Forms.Padding(2);
            this.txtReligion_AE.MaxLength = 32767;
            this.txtReligion_AE.Name = "txtReligion_AE";
            this.txtReligion_AE.PasswordChar = '\0';
            this.txtReligion_AE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReligion_AE.SelectedText = "";
            this.txtReligion_AE.SelectionLength = 0;
            this.txtReligion_AE.SelectionStart = 0;
            this.txtReligion_AE.ShortcutsEnabled = true;
            this.txtReligion_AE.Size = new System.Drawing.Size(150, 24);
            this.txtReligion_AE.TabIndex = 129;
            this.txtReligion_AE.UseSelectable = true;
            this.txtReligion_AE.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReligion_AE.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbPakistani_AE
            // 
            this.rbPakistani_AE.AutoSize = true;
            this.rbPakistani_AE.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbPakistani_AE.Location = new System.Drawing.Point(0, 0);
            this.rbPakistani_AE.Margin = new System.Windows.Forms.Padding(2);
            this.rbPakistani_AE.Name = "rbPakistani_AE";
            this.rbPakistani_AE.Size = new System.Drawing.Size(96, 25);
            this.rbPakistani_AE.TabIndex = 130;
            this.rbPakistani_AE.Text = "Pakistani";
            this.rbPakistani_AE.UseSelectable = true;
            // 
            // rbOther_AE
            // 
            this.rbOther_AE.AutoSize = true;
            this.rbOther_AE.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbOther_AE.Location = new System.Drawing.Point(77, 0);
            this.rbOther_AE.Margin = new System.Windows.Forms.Padding(2);
            this.rbOther_AE.Name = "rbOther_AE";
            this.rbOther_AE.Size = new System.Drawing.Size(73, 25);
            this.rbOther_AE.TabIndex = 131;
            this.rbOther_AE.Text = "Other";
            this.rbOther_AE.UseSelectable = true;
            // 
            // cbType_AE
            // 
            this.cbType_AE.FormattingEnabled = true;
            this.cbType_AE.ItemHeight = 23;
            this.cbType_AE.Location = new System.Drawing.Point(435, 199);
            this.cbType_AE.Margin = new System.Windows.Forms.Padding(2);
            this.cbType_AE.Name = "cbType_AE";
            this.cbType_AE.Size = new System.Drawing.Size(150, 29);
            this.cbType_AE.TabIndex = 132;
            this.cbType_AE.UseSelectable = true;
            // 
            // rbFemale_AE
            // 
            this.rbFemale_AE.AutoSize = true;
            this.rbFemale_AE.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbFemale_AE.Location = new System.Drawing.Point(77, 0);
            this.rbFemale_AE.Margin = new System.Windows.Forms.Padding(2);
            this.rbFemale_AE.Name = "rbFemale_AE";
            this.rbFemale_AE.Size = new System.Drawing.Size(84, 25);
            this.rbFemale_AE.TabIndex = 103;
            this.rbFemale_AE.Text = "Female";
            this.rbFemale_AE.UseSelectable = true;
            // 
            // rbMale_AE
            // 
            this.rbMale_AE.AutoSize = true;
            this.rbMale_AE.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbMale_AE.Location = new System.Drawing.Point(0, 1);
            this.rbMale_AE.Margin = new System.Windows.Forms.Padding(2);
            this.rbMale_AE.Name = "rbMale_AE";
            this.rbMale_AE.Size = new System.Drawing.Size(66, 25);
            this.rbMale_AE.TabIndex = 102;
            this.rbMale_AE.Text = "Male";
            this.rbMale_AE.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.rbFemale_AE);
            this.metroPanel1.Controls.Add(this.rbMale_AE);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(112, 121);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(167, 25);
            this.metroPanel1.TabIndex = 134;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.rbPakistani_AE);
            this.metroPanel2.Controls.Add(this.rbOther_AE);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(112, 203);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(167, 25);
            this.metroPanel2.TabIndex = 135;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.rbMarried_AE);
            this.metroPanel3.Controls.Add(this.rbUnmarried_AE);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(435, 122);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(194, 25);
            this.metroPanel3.TabIndex = 136;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 528);
            this.Controls.Add(this.tcEmployee);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Employee";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Employee ";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.tcEmployee.ResumeLayout(false);
            this.tabAddEmployee.ResumeLayout(false);
            this.tabAddEmployee.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tcEmployee;
        private MetroFramework.Controls.MetroTabPage tabAddEmployee;
        private MetroFramework.Controls.MetroTabPage tabUpdateEmployee;
        private MetroFramework.Controls.MetroTabPage tabDeleteEmployee;
        private MetroFramework.Controls.MetroLabel lblName_AE;
        private MetroFramework.Controls.MetroTextBox txtName_AE;
        private MetroFramework.Controls.MetroDateTime dtJoiningDate_AE;
        private MetroFramework.Controls.MetroLabel lblGender_AE;
        private MetroFramework.Controls.MetroTextBox txtAddress_AE;
        private MetroFramework.Controls.MetroComboBox cbStatus_AE;
        private MetroFramework.Controls.MetroTextBox txtQualification_AE;
        private MetroFramework.Controls.MetroTextBox txtEmail_AE;
        private MetroFramework.Controls.MetroRadioButton rbUnmarried_AE;
        private MetroFramework.Controls.MetroRadioButton rbMarried_AE;
        private MetroFramework.Controls.MetroTextBox txtPhoneNumber_AE;
        private MetroFramework.Controls.MetroTextBox txtCity_AE;
        private MetroFramework.Controls.MetroTextBox txtFatherName_AE;
        private MetroFramework.Controls.MetroLabel lblStatus_AE;
        private MetroFramework.Controls.MetroLabel lblCity_AE;
        private MetroFramework.Controls.MetroLabel lblJoiningDate_AE;
        private MetroFramework.Controls.MetroLabel lblReligion_AE;
        private MetroFramework.Controls.MetroLabel lblMaritalStatus_AE;
        private MetroFramework.Controls.MetroLabel lblAddress_AE;
        private MetroFramework.Controls.MetroLabel lblNationality_AE;
        private MetroFramework.Controls.MetroLabel lblPhoneNumber_AE;
        private MetroFramework.Controls.MetroLabel lblEmail_AE;
        private MetroFramework.Controls.MetroLabel lblQualification_AE;
        private MetroFramework.Controls.MetroLabel lblEmployeeType_AE;
        private MetroFramework.Controls.MetroLabel lblFathersName_AE;
        private MetroFramework.Controls.MetroTile btnAdd_AE;
        private MetroFramework.Controls.MetroTextBox txtReligion_AE;
        private MetroFramework.Controls.MetroRadioButton rbOther_AE;
        private MetroFramework.Controls.MetroRadioButton rbPakistani_AE;
        private MetroFramework.Controls.MetroComboBox cbType_AE;
        private MetroFramework.Controls.MetroRadioButton rbMale_AE;
        private MetroFramework.Controls.MetroRadioButton rbFemale_AE;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
    }
}