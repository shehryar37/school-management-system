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
    public partial class FormTeacherPanel : MetroFramework.Forms.MetroForm {
        public FormTeacherPanel() {
            InitializeComponent();
        }

        private void btnStudent_TeacherPanel_Click(object sender, EventArgs e) {
            Students students = new Students();
            students.Show();
        }

        private void btnClass_TeacherPanel_Click(object sender, EventArgs e) {
            Classes classes = new Classes();
            classes.Show();
        }

        private void btnAttendance_TeacherPanel_Click(object sender, EventArgs e) {
            Attendance attendance = new Attendance();
            attendance.Show();
        }

        private void btnReports_TeacherPanel_Click(object sender, EventArgs e) {
            Reports reports = new Reports();
            reports.Show();
        }
    }
}
