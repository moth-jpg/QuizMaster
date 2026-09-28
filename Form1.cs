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
        int gameTime = 60;
        int currentTime = 0;
        DataTable dataTable = null;
        int row = 0;

        Question question = null;
        List<Question> questionList = null;
        List<Question> currentQuestions = null;

        Random random = new Random();
        int currentQuestion = 0;

        string connectionString = @"Data Source = localhost;Initial Catalog=quizmaster; User Id=root;password=''";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAnswerOne.Click += CheckAnswer;
            btnAnswerTwo.Click += CheckAnswer;
            btnAnswerThree.Click += CheckAnswer;
            btnAnswerFour.Click += CheckAnswer;
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
            currentTime = gameTime;
            GetAllQuestions();
            GameModeOne();
            StartQuiz(); ;

            pnlGame.Visible = true;
        }

        private void btnGameModeTwo_Click(object sender, EventArgs e)
        {
            currentTime = gameTime;
            GetAllQuestions();
            GameModeTwo();
            StartQuiz();

            pnlGame.Visible = true;
        }

        private void btnGameModeThree_Click(object sender, EventArgs e)
        {
            currentTime = gameTime;
            GetAllQuestions();
            GameModeThree();
            StartQuiz();

            pnlGame.Visible = true;
        }

        private void StartQuiz()
        {
            if(currentQuestions == null || currentQuestions.Count == 0)
            {
                MessageBox.Show("No Questions available!");
                return;
            }

            ShuffleList();
            currentQuestion = 0;
            DisplayQuestion();
            tmrGame.Start();
        }

        /// <summary>
        /// RANDOMISING LIST SO EACH QUIZ WILL BE UNIQUE
        /// </summary>
        private void ShuffleList()
        {
            for(int i = currentQuestions.Count -1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Question temp = questionList[i];
                questionList[i] = questionList[j];
                questionList[j] = temp;
            }
        }

        private void GameModeOne()
        {
            currentQuestions = questionList.ToList();
        }

        private void GameModeTwo()
        {
            currentQuestions = questionList.GetRange(20, 20);
        }

        private void GameModeThree()
        {
            currentQuestions = questionList.GetRange(40, 20);
        }

        private void GetAllQuestions()
        {
            questionList = new List<Question>();
            row = 0;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using(dataTable = new DataTable("questions"))
                {
                    using (MySqlCommand cmd = new MySqlCommand("Select * FROM questions", conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dataTable);
                    }
                }
            }

            if(dataTable.Rows.Count > 0)
            {
                //Loop through all the rows found in the database
                foreach(DataRow rows in dataTable.Rows)
                {
                    question = new Question(Convert.ToInt32(dataTable.Rows[row][0]), dataTable.Rows[row][1].ToString(), dataTable.Rows[row][2].ToString(), dataTable.Rows[row][3].ToString(), dataTable.Rows[row][4].ToString(),dataTable.Rows[row][5].ToString());
                    questionList.Add(question);
                    row++;
                }
            }
            else
            {
                MessageBox.Show("No items found");
            }
        }

        private void DisplayQuestion()
        {
            //get the current question
            Question q = currentQuestions[currentQuestion];

            //display teh question
            lblQuestion.Text = q.GetQuestion();

            //Put all 4 answers into a list
            List<string> answers = new List<string>
            {
                q.GetCorrectAnswer(),
                q.GetFalseAnswerOne(),
                q.GetFalseAnswerTwo(),
                q.GetFalseAnswerThree(),
            };

            //Shuffle all the answers 
            for(int i = answers.Count - 1; i >0;  i--)
            {
                int j = random.Next(i + 1);

                string temp = answers[i];
                answers[i] = answers[j];
                answers[j] = temp;
            }

            //Assign the shuffles answers to the buttons
            btnAnswerOne.Text = answers[0];
            btnAnswerTwo.Text = answers[1];
            btnAnswerTwo.Text = answers[2];
            btnAnswerFour.Text = answers[3];
        }

        private void CheckAnswer(object sender,  EventArgs e)
        {
            Button clickedButton = sender as Button;

            //Get the correct answer for this question
            string correctAnswer = currentQuestions[currentQuestion].GetCorrectAnswer();

            //checked the clicked button
            if(clickedButton.Text == correctAnswer)
            {
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Wrong answer");
            }

            // Move to the next question
            currentQuestion++;

            // Check if there are more questions
            if (currentQuestion < currentQuestions.Count)
            {
                DisplayQuestion();
            }
            else
            {
                tmrGame.Stop();
                MessageBox.Show("Quiz completed!");
            }
        }
    }
}
