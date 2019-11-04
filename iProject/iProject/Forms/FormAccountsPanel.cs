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
    public partial class FormAccountsPanel : MetroFramework.Forms.MetroForm {
        public FormAccountsPanel() {
            InitializeComponent();
        }

        private void btnEmployee_AccountsPanel_Click(object sender, EventArgs e) {
            Employee employee = new Employee();
            employee.Show();
        }

        private void btnStudent_AccountsPanel_Click(object sender, EventArgs e) {
            Students students = new Students();
            students.Show();
        }

        private void btnAccounts_AccountsPanel_Click(object sender, EventArgs e) {
            Accounts accounts = new Accounts();
            accounts.Show();
        }

        private void btnReports_AccountsPanel_Click(object sender, EventArgs e) {
            Reports reports = new Reports();
            reports.Show();
        }
    }
}
