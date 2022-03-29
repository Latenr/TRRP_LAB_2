using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Data.SQLite;
namespace TRRP_LAB_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            var param = JObject.Parse(File.ReadAllText("settings.json"));
            if (param["TYPE"].ToString() == "SOCKET") MQGroup.Enabled=false;
            else if (param["TYPE"].ToString() == "MQ") SoketGroup.Enabled=false;
            else
            {
                MQGroup.Enabled= false;
                SoketGroup.Enabled = false;
            }
        }

        private void SoketNormalizeButton_Click(object sender, EventArgs e)
        {
            var param = JObject.Parse(File.ReadAllText("settings.json"));
            ReadRecordsFromSqlite(label6.Text);
            
        }

        private void MQNormalizeButton_Click(object sender, EventArgs e)
        {
            var param = JObject.Parse(File.ReadAllText("settings.json"));
            ReadRecordsFromSqlite(param["SQLITE_PATH"].ToString());
        }

        public static  List<Record> ReadRecordsFromSqlite(string dbFileName)
        {
            var sqliteConnectionString = new SQLiteConnectionStringBuilder
            {
                DataSource = dbFileName
            }.ConnectionString;

            var records = new List<Record>();
            using (var connection = new SQLiteConnection(sqliteConnectionString))
            {
                using (var command = new SQLiteCommand("SELECT * FROM appointment", connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id_appointment = int.Parse(reader["id_appointment"].ToString());
                            var doctor = (string)reader["doctor"];
                            var department = (string)reader["department"];
                            var hospital = (string)reader["hospital"];
                            var patient = (string)reader["patient"];
                            var age = int.Parse(reader["age"].ToString());
                            var reason = (string)reader["reason"];
                            var line = new Record(id_appointment, doctor, department, hospital, patient, age, reason);
                            records.Add(line);
                        }
                    }
                }
            }
            return records; ;
        }
    }
}
