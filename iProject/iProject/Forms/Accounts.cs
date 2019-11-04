using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iProject.Forms {
    public partial class Accounts : MetroFramework.Forms.MetroForm {
        public Accounts() {
            InitializeComponent();
        }

        ConnectionSettings connectionSettings = new ConnectionSettings();
        
        // Takes all of the input fields from Fees Create tab and creates a new fees entry in tblFee
        private void btnCreate_FeesCreate_Click(object sender, EventArgs e) {
            string query = "INSERT INTO tblFee (" +
                           " GrNumber, Class, StudentName," +
                           " StudentFatherName, TotalFee," +
                           " DateOfIssue, DueDate, Status, Month" +
                           ")" +
                           " VALUES (" +
                           "'" + txtGRNo_FeesCreate.Text + "'," +
                           "'" + cbClass_FeesCreate.SelectedItem.ToString() + "'," +
                           "'" + txtStudentName_FeesCreate.Text + "'," +
                           "'" + txtStudentFatherName_FeesCreate.Text + "'," +
                           "'" + txtTotalFee_FeesCreate.Text + "'," +
                           "'" + dtDateOfIssue_FeesCreate.Value.ToShortDateString() + "'," +
                           "'" + dtDueDate_FeesCreate.Value.ToShortDateString() + "'," +
                           "'" + cbStatus_FeesCreate.SelectedItem.ToString() + "'," +
                           "'" + cbMonth_FeesCreate.SelectedItem.ToString() + "'" +
                           ")";

            DatabaseManager databaseManager = new DatabaseManager();
            databaseManager.executeQuery(query);

            string query2 = "INSERT INTO tblProfitLoss (" +
                    "Income, IncomeType, Date" +
                    ")" +
                    " VALUES (" +
                    "'" + txtTotalFee_FeesCreate.Text + "'," +
                    "'Fees'," +
                    "'" + dtDateOfIssue_FeesCreate.Value.ToShortDateString() + "'" +
                    ")";

            databaseManager.executeQuery(query2);
        }

        private void btnGenerate_Voucher_Click(object sender, EventArgs e) {
            // TODO: By pressing this button, a report is generated of a voucher
        }

        private void btnUpdate_UFS_Click(object sender, EventArgs e) {
            string query = "UPDATE tblFee" +
                           " SET Status='" + cbStatus_UFS.SelectedItem.ToString() + "'" +
                           " WHERE GRNumber='" + txtGRNo_UFS.Text + "'" +
                           " AND Class='" + txtClass_UFS.Text + "'" +
                           " AND Month='" + cbMonth_UFS.SelectedItem.ToString() + "'";

            DatabaseManager databaseManager = new DatabaseManager();
            databaseManager.executeQuery(query);
        }

        private void btnAddExpense_Expenses_Click(object sender, EventArgs e) {
            string query = "INSERT INTO tblOtherExpense (" +
                           "ExpenseType, ExpenseName, Budget, Month" +
                           ") VALUES (" +
                           "'" + txtType_Expenses.Text + "'," +
                           "'" + txtName_Expenses.Text + "'," +
                           "'" + txtBudget_Expenses.Text + "'," +
                           "'" + dtMonth_Expenses.Value.ToShortDateString() + "'" +
                           ")";

            DatabaseManager databaseManager = new DatabaseManager();
            databaseManager.executeQuery(query);

            string query2 = "INSERT INTO tblProfitLoss(" +
                            "Expense, ExpenseType, Date" +
                            ") VALUES (" +
                            "'" + txtBudget_Expenses.Text + "'," +
                            "'" + txtType_Expenses.Text + "'," +
                            "'" + dtMonth_Expenses.Value.ToShortDateString() + "'" +
                            ")";

            databaseManager.executeQuery(query2);
        }

        private void btnView_MPL_Click(object sender, EventArgs e) {

            string query = "SELECT SUM(Income) as Income," +
                           " SUM(Expense) as Expense" +
                           " FROM tblProfitLoss" +
                           " WHERE Date BETWEEN '" + dtFrom_MPL.Value.ToShortDateString() + "'" +
                           " AND '" + dtTo_MPL.Value.ToShortDateString() + "'";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connectionSettings.SqlConnection);

            connectionSettings.SqlConnection.Open();

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvMonthlyProfitLoss_MPL.DataSource = dataTable;

            connectionSettings.SqlConnection.Close();
        }

        private void btnCreate_ES_Click(object sender, EventArgs e) {

        }
    }
}
