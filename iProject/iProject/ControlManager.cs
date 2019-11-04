using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iProject {
    // This handles dynamic controls
    class ControlManager : ConnectionSettings {

        // Used to populate a ComboBox
        public void populateControl(string query, string source, string display, string value, ComboBox comboBox) {
            ConnectionSettings connectionSettings = new ConnectionSettings();

            try {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connectionSettings.SqlConnection);

                connectionSettings.SqlConnection.Open();

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, source);
                comboBox.DisplayMember = display;
                comboBox.ValueMember = value;
                comboBox.DataSource = dataSet.Tables[source];

                connectionSettings.SqlConnection.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                connectionSettings.SqlConnection.Close();
            }
        }

        //Used to populate a DataGridView
        public void populateControl(string query, DataGridView dataGridView) {
            ConnectionSettings connectionSettings = new ConnectionSettings();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connectionSettings.SqlConnection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);

            dataGridView.DataSource = table;
        }

        // No idea what this means. 
        // TODO: Design refresh functions for above mentioned controls (takes a min)
    }
}
