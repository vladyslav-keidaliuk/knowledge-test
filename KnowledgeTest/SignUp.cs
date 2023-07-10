using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KnowledgeTest
{
    public partial class SignUp : Form
    {
        private string FIO;
        private string Login;
        private string Password;
        private string Email;
        public SignUp()
        {
            InitializeComponent();
            this.Text = "Реєстрація";
            Login_label.Text = "Ваш логін:";
            Error_label.Text = " ";
            this.Load += SignUp_Load;
            this.FormClosing += SignUp_Closing;
        }
        
        private void SignUp_Closing(object sender, FormClosingEventArgs e)
        {
            if (this == Form.ActiveForm) 
            {
                Application.Exit(); 
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorPack.DarkBlue;

            FIO_label.ForeColor = ColorPack.White;
            Login_label.ForeColor = ColorPack.White;
            Password_label.ForeColor = ColorPack.White;
            SignUp_button.BackColor = ColorPack.Yellow;
            Email_label.ForeColor = ColorPack.White;
            Error_label.ForeColor = ColorPack.Magenta;
            Back_button.BackColor = ColorPack.Orange;
            Back_button.ForeColor = ColorPack.White;
            Back_button.Text = "Назад";
            
            FIO_textBox.BackColor = ColorPack.DarkBlue;
            FIO_textBox.ForeColor = ColorPack.Aquamarine;
            Login_textBox.BackColor = ColorPack.DarkBlue;
            Login_textBox.ForeColor = ColorPack.Aquamarine;
            Password_textBox.BackColor = ColorPack.DarkBlue;
            Password_textBox.ForeColor = ColorPack.Aquamarine;
            Email_textBox.BackColor = ColorPack.DarkBlue;
            Email_textBox.ForeColor = ColorPack.Aquamarine;
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FIO_textBox.Text))
            {
                FIO_textBox.Text = "Поле пусте";
            }
            if (string.IsNullOrEmpty(Login_textBox.Text))
            {
                Login_textBox.Text = "Поле пусте";
            }
            if (string.IsNullOrEmpty(Password_textBox.Text))
            {
                Password_textBox.Text = "Поле пусте";
            }
            if (string.IsNullOrEmpty(Email_textBox.Text))
            {
                Email_textBox.Text = "Поле пусте";
            }
            

            else
            {
                if (string.IsNullOrEmpty(FIO_textBox.Text)==false && FIO_textBox.Text != "Поле пусте"&&
                    string.IsNullOrEmpty(Login_textBox.Text)==false && Login_textBox.Text != "Поле пусте"&&
                    string.IsNullOrEmpty(Password_textBox.Text)==false && Password_textBox.Text != "Поле пусте"&&
                    string.IsNullOrEmpty(Email_textBox.Text)==false && Email_textBox.Text != "Поле пусте")
                {
                    FIO = FIO_textBox.Text;
                    Login = Login_textBox.Text;
                    Password = Password_textBox.Text;
                    if (IsGmailEmail(Email_textBox.Text))
                    {
                        Email = Email_textBox.Text;
                        if (DB_Operations.IsLoginExists(Login))
                        {
                            Error_label.Text = "Помилка, користувач з таким логіном вже існує";
                        }
                        else
                        {
                            DB_Operations.Add_User_to_DB(FIO,Login,Password,Email);

                            First first = Application.OpenForms["First"] as First;
                            if (first != null)
                            {
                                first.Show();
                            }
                            this.Close();
                        }
                    }
                    else
                    {
                        Email_textBox.Text="Помилка, невірний запис пошти.";
                    }
                }
               
                if (IsGmailEmail(Email_textBox.Text))
                {
                    Email = Email_textBox.Text;
                }
                else
                {
                    Email_textBox.Text="Помилка, невірний запис пошти.";
                }
                
                FIO_textBox.Click += TextBox_Click;
                Login_textBox.Click += TextBox_Click;
                Password_textBox.Click += TextBox_Click;
                Email_textBox.Click += TextBox_Click;
                
                
            }
        }
        
        static bool IsGmailEmail(string email)
        {
            string gmailPattern = @"^[a-zA-Z0-9_.+-]+@gmail\.com$";
            return Regex.IsMatch(email, gmailPattern);
        }
        
        private void TextBox_Click(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                textBox.Text = string.Empty; 
            }
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
    }
}