using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaster
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source = localhost;Initial Catalog=c#quizmaster; User Id=root;password=''";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ExecuteQuery(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (dataTable = new DataTable(""))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
