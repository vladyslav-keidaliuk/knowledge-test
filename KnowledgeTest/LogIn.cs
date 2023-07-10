using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KnowledgeTest
{
    public partial class LogIn : Form
    {
        private string Login;
        private string Password;
        public LogIn()
        {
            InitializeComponent();
            this.Text = "Авторизація";
            Error_label.Text = " ";
            this.Load += LogIn_Load;
            this.FormClosing += LogIn_Closing;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void LogIn_Closing(object sender, FormClosingEventArgs e)
        {
            if (this == Form.ActiveForm) 
            {
                Application.Exit(); 
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorPack.DarkBlue;
            Error_label.ForeColor = ColorPack.Orange;
            Login_label.ForeColor = ColorPack.White;
            Login_textBox.BackColor = ColorPack.DarkBlue;
            Login_textBox.ForeColor = ColorPack.Aquamarine;
            Password_label.ForeColor = ColorPack.White;
            Password_textBox.BackColor = ColorPack.DarkBlue;
            Password_textBox.ForeColor = ColorPack.Aquamarine;
            Back_button.BackColor = ColorPack.Orange;
            Back_button.ForeColor = ColorPack.White;
            Back_button.Text = "Назад";
            Start_test_button.BackColor = ColorPack.Blue;
            Start_test_button.ForeColor = ColorPack.White;
            Start_test_button.Text = "Увійти";
            
        }
        

        private void Back_button_Click(object sender, EventArgs e)
        {
            First first = Application.OpenForms["First"] as First;
            if (first != null)
            {
                first.Show();
            }
            this.Close();
        }
        

        private void Start_test_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Login_textBox.Text))
            {
                Login_textBox.Text = "Поле пусте";
            }
            if (string.IsNullOrEmpty(Password_textBox.Text))
            {
                Password_textBox.Text = "Поле пусте";
            }
            else
            {
                if (string.IsNullOrEmpty(Login_textBox.Text)==false && Login_textBox.Text != "Поле пусте"&&
                    string.IsNullOrEmpty(Password_textBox.Text)==false && Password_textBox.Text != "Поле пусте")
                {
                    Login = Login_textBox.Text;
                    Password = Password_textBox.Text;
                    
                    if (IsLoginAndPasswordCorrect(Login,Password))
                    {
                        AfterLogin afterlogin = new AfterLogin(Login,Password);
                        this.Hide();
                        afterlogin.Show(this);

                    }
                    else
                    {
                        Error_label.Text="Дані введені невірно, спробуйте ще раз.";
                    }
                }
                
                Login_textBox.Click += TextBox_Click;
                Password_textBox.Click += TextBox_Click;

            }
        }
        
        private void TextBox_Click(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                textBox.Text = string.Empty; 
            }
        }
        
        private bool IsLoginAndPasswordCorrect(string login, string password)
        {
            MySqlConnection conn;
            string myConnectionString = "server=YOUR;uid=YOUR_ID;pwd=YOUR_PASSWORD;database=YOUR_DB";
            conn = new MySqlConnection(myConnectionString);

            try
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM users WHERE Login = @login AND Password = @password";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
            catch (MySqlException)
            {
                Console.WriteLine("Error");
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}