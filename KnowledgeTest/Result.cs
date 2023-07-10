using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace KnowledgeTest
{
    public partial class Result : Form
    {
        private string Login;
        private string Password;
        private int Questions_At_Test;
        private string result;
        private int Score;
        public Result(string login, string password,int score,int questions_at_test,string result)
        {
            InitializeComponent();
            this.Text = "Результат";
            Login = login;
            Password = password;
            this.result = result;
            Questions_At_Test = questions_at_test;
            Score = score;
            // label1.Text = result;
            this.FormClosing += Result_Closing;
            this.Load += Result_Load;
            
        }

        private void Result_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorPack.DarkBlue;
            Label_Result.Text = "Результат тестування:";
            Label_Result.Font = new Font("Arial",14);
            Label_Result.ForeColor = ColorPack.White;

            Result_Info_label.ForeColor = ColorPack.White;
            Result_Info_label.Font = new Font("Arial", 14);
            Result_Info_label.Text = 
                $"Ви набрали: {Score} балів з {Questions_At_Test} можливих." +
                $"\nДетальна інформація була надіслана на пошту, що була вказана при реєстрації," +
                $" а саме ({DB_Operations.GetEmail(Login,Password)}). ";

            Top_label.ForeColor = ColorPack.Yellow;
            Top_label.Font = new Font("Arial", 14);

            string top = DB_Operations.GetTopUsers();
            Top_label.Text = " ТОП 5 користувачів\n\n"+top;

            MainPage_button.Text = "Головна сторінка";
            MainPage_button.ForeColor = ColorPack.White;
            MainPage_button.BackColor = ColorPack.Blue;
            MainPage_button.Font = new Font("Arial", 14);
            
            CloseApp_button.Text = "Закрити додаток";
            CloseApp_button.ForeColor = ColorPack.White;
            CloseApp_button.BackColor = ColorPack.Orange;
            CloseApp_button.Font = new Font("Arial", 14);
            
            


            Send_Email_With_Results(result);
        }

        private void Send_Email_With_Results(string result)
        {
            string fromMail = "YOUR_EMAIl";
            string fromPassword = "YOUR_PASSWORD";
        
            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Результати тестування";
            string recipient = DB_Operations.GetEmail(Login, Password);
            message.To.Add(new MailAddress(recipient));
            message.Body = result;
        
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };
            
            smtpClient.Send(message);
        }
        

        private void Result_Closing(object sender, FormClosingEventArgs e)
        {   
            if (this == Form.ActiveForm) 
            {
                Application.Exit(); 
            }
        }
        

        private void MainPage_button_Click(object sender, EventArgs e)
        {
            First first = Application.OpenForms["First"] as First;
            if (first != null)
            {
                first.Show();
            }
            this.Close();
        }

        private void CloseApp_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}