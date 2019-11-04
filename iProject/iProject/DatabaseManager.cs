using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iProject {
    class DatabaseManager : ConnectionSettings {
        // Executes a query
        public void executeQuery(string query) {
            ConnectionSettings connectionSettings = new ConnectionSettings();

            try {
                connectionSettings.SqlConnection.Open();

                SqlCommand command = new SqlCommand(query, connectionSettings.SqlConnection);
                command.ExecuteNonQuery();

                connectionSettings.SqlConnection.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                connectionSettings.SqlConnection.Close();
            }
        }

        //Returns whether rows are affected or not (test to confirm)
        public int rowsAffected(string query) {
            ConnectionSettings connectionSettings = new ConnectionSettings();

            try {
                connectionSettings.SqlConnection.Open();

                SqlCommand command = new SqlCommand(query, connectionSettings.SqlConnection);
                int rows = Convert.ToInt32(command.ExecuteScalar());

                connectionSettings.SqlConnection.Close();

                return rows;
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                connectionSettings.SqlConnection.Close();
                return 0;
            }
        }

        // Fetches a record from a table based on the primary key primaryKeyValue
        public DataRow fetchRecord(string primaryKeyValue, string source, string primaryKey) {
            ConnectionSettings connectionSettings = new ConnectionSettings();

            string query = "SELECT * FROM " + source + " WHERE " + primaryKey + "=" + primaryKeyValue;

            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionSettings.SqlConnection);

            connectionSettings.SqlConnection.Open();

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, source);

            return dataSet.Tables[source].Rows[0];
        }

        // Fetches the entire table
        public DataTable fetchTable(string source) {
            ConnectionSettings connectionSettings = new ConnectionSettings();

            string query = "SELECT * FROM " + source;

            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionSettings.SqlConnection);

            connectionSettings.SqlConnection.Open();

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, source);

            return dataSet.Tables[source];
        }

        // fetches the part of the table that satisfies the query
        public DataTable fetchTable(string query, string source) {
            ConnectionSettings databaseSetting = new ConnectionSettings();

            SqlDataAdapter adapter = new SqlDataAdapter(query, databaseSetting.SqlConnection);

            databaseSetting.SqlConnection.Open();

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, source);

            return dataSet.Tables[source];
        }

        // Not a reliable function -- fetches the primary key based on any other value in the row
        public string fetchPrimaryKey(string value, string source, string field) {
            ConnectionSettings databaseSetting = new ConnectionSettings();

            string query = "SELECT * FROM " + source + " WHERE " + field + "='" + value + "'";

            SqlCommand command = new SqlCommand(query, databaseSetting.SqlConnection);

            databaseSetting.SqlConnection.Open();

            string primaryKey = command.ExecuteScalar().ToString();

            databaseSetting.SqlConnection.Close();

            return primaryKey;
        }
    }
}
