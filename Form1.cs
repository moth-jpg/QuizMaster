using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaster
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source = localhost;Initial Catalog=quizmaster; User Id=root;password=''";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterHere_Click(object sender, EventArgs e)
        { 
            //Changing to Login Tab
            tbControl.SelectedIndex = 1;            
        }

        private void btnLoginHere_Click(object sender, EventArgs e)
        {
            //Changing to Register Tab
            tbControl.SelectedIndex = 0;
        }

        /// <summary>
        /// Logic Logic
        /// checking to see if there is an used that fits the playername and password
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string playername = tbxLoginName.Text.Trim();
            string password = tbxLoginPassword.Text.Trim();

            if(playername == "" || password == "")
            {
                MessageBox.Show("Username and Password Required!");
                return;
            }
            else
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    using (conn)
                    {
                        conn.Open();
                        string query = "SELECT COUNT(*) FROM login WHERE PlayerName=@PlayerName AND Password=@Password";
                        MySqlDataAdapter ada = new MySqlDataAdapter(query, conn);
                        ada.SelectCommand.Parameters.AddWithValue("@PlayerName", playername);
                        ada.SelectCommand.Parameters.AddWithValue("@Password", password);

                        DataTable table = new DataTable();
                        ada.Fill(table);

                        if(table.Rows.Count > 0)
                        {
                            MessageBox.Show("Logged in succesfully");
                            conn.Close();
                            tbControl.SelectedIndex = 2;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Invalid Details!");
                            conn.Close();
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        /// <summary>
        /// Register Logic
        /// Adding the Playername and password for the new user to the database 
        /// </summary>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string playername = tbxRegisterName.Text.Trim();
            string password = tbxRegisterPassword.Text.Trim();

            if(playername == "" || password == "")
            {
                MessageBox.Show("All fields must be filled in to proceed");
                return;
            }
            else
            {
                //perform registration logics
                try
                {
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    using (conn)
                    {
                        conn.Open();
                        string query = "INSERT INTO login(playername, password)values(@PlayerName, @Password)";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@PlayerName", playername.ToLower());
                        cmd.Parameters.AddWithValue ("@Password", password);

                        int status =cmd.ExecuteNonQuery();

                        if(status > 0)
                        {
                            MessageBox.Show("Account created succesfully!");
                            conn.Close();
                            tbControl.SelectedIndex = 1;
                        }
                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnGameModeOne_Click(object sender, EventArgs e)
        {

        }

        private void btnGameModeTwo_Click(object sender, EventArgs e)
        {

        }

        private void btnGameModeThree_Click(object sender, EventArgs e)
        {

        }
    }
}
