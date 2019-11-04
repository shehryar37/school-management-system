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
    public partial class FormAdmissionPanel : MetroFramework.Forms.MetroForm {
        public FormAdmissionPanel() {
            InitializeComponent();
        }

        private void btnEmployee_AdmissionPanel_Click(object sender, EventArgs e) {
            Employee employee = new Employee();
            employee.Show();
        }

        private void btnStudent_AdmissionPanel_Click(object sender, EventArgs e) {
            Students students = new Students();
            students.Show();
        }

        private void btnClass_AdmissionPanel_Click(object sender, EventArgs e) {
            Classes classes = new Classes();
            classes.Show();
        }
    }
}
