using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iProject.Forms {
    public partial class Employee : MetroFramework.Forms.MetroForm {
        public Employee() {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            ControlManager controlManager = new ControlManager();

            controlManager.populateControl("SELECT * FROM tblStatus", "tblStatus", "StatusName", "StatusID", cbStatus_AE);
            controlManager.populateControl("SELECT * FROM tblEmployeeType", "tblemployeeType", "EmployeeTypeName", "EmployeeTypeID", cbType_AE);
        }

        string separator = "','";
        string query;

        private void btnAdd_AE_Click(object sender, EventArgs e)
        {

            string nationality = "";

            if(rbPakistani_AE.Checked)
            {
                nationality = "Pakistani";
            }
            else
            {
                nationality = "Other";
            }

            string maritalStatus = "";

            if(rbMarried_AE.Checked)
            {
                maritalStatus = "Married";
            }
            else
            {
                maritalStatus = "Unmarried";
            }

            string gender = "";

            if(rbMale_AE.Checked)
            {
                gender = "M";
            }
            else
            {
                gender = "F";
            }

            query = "INSERT INTO tblEmployee" + " VALUES('" +
                txtName_AE.Text + separator +
                txtFatherName_AE.Text + separator +
                cbType_AE.SelectedValue.ToString() + separator +
                txtQualification_AE.Text + separator +
                txtEmail_AE.Text + separator +
                txtPhoneNumber_AE.Text + separator +
                nationality + separator +
                txtAddress_AE.Text + separator +
                maritalStatus + separator +
                gender + separator +
                txtReligion_AE.Text + separator +
                dtJoiningDate_AE.Text + separator +
                txtCity_AE.Text + separator +
                cbStatus_AE.SelectedValue.ToString() + "')";

            DatabaseManager databaseManager = new DatabaseManager();

            databaseManager.executeQuery(query);

            MessageBox.Show("Employee Added!");


        }
    }
}
