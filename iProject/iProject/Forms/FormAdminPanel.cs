using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iProject.Forms;

namespace iProject {
    public partial class FormAdminPanel : MetroFramework.Forms.MetroForm {
        public FormAdminPanel() {
            InitializeComponent();
        }

        private void btnEmployee_AdminPanel_Click(object sender, EventArgs e) {
            Employee employee = new Employee();
            employee.Show();
        }

        private void btnStudent_AdminPanel_Click(object sender, EventArgs e) {
            Students students = new Students();
            students.Show();
        }

        private void btnClass_AdminPanel_Click(object sender, EventArgs e) {
            Classes classes = new Classes();
            classes.Show();
        }

        private void btnAttendance_AdminPanel_Click(object sender, EventArgs e) {
            Attendance attendance = new Attendance();
            attendance.Show();
        }

        private void btnAccounts_AdminPanel_Click(object sender, EventArgs e) {
            Accounts accounts = new Accounts();
            accounts.Show();
        }

        private void btnReports_AdminPanel_Click(object sender, EventArgs e) {
            Reports reports = new Reports();
            reports.Show();
        }
    }
}
