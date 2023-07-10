using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KnowledgeTest
{
    public partial class AfterLogin : Form
    {
        private string Login;
        private string Password;
        public AfterLogin(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
            InitializeComponent();
            this.Load += AfterLogin_Load;
            this.FormClosing += AfterLogin_Closing;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
        }

        private void AfterLogin_Closing(object sender, FormClosingEventArgs e)
        {
            if (this == Form.ActiveForm) 
            {
                Application.Exit(); 
            }
        }

        
        private void AfterLogin_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorPack.DarkBlue;

            string text = DB_Operations.GetTopUsers();
            Top_label.Font = new Font("Arial", 14);
            Top_label.ForeColor = ColorPack.Aquamarine;
            Top_label.Text = " ТОП 5 користувачів\n\n"+text;
            FIO_label.ForeColor = ColorPack.White;
            FIO_label.Font = new Font("Arial", 14);
            FIO_label.Text = "Ваше ФІО : "+ DB_Operations.GetFIO(Login, Password);
            Score_label.ForeColor = ColorPack.White;
            Score_label.Font = new Font("Arial", 14);

            StartTest_button.ForeColor = ColorPack.White;
            StartTest_button.BackColor = ColorPack.Blue;
            StartTest_button.Font = new Font("Arial", 14);
            

            if (DB_Operations.GetScore(Login,Password)!=-1)
            {
                Score_label.Text = "Минулий раз Ви пройшли тест з наступним результатом: " + DB_Operations.GetScore(Login, Password) + " б.";
            }
            else
            {
                Score_label.Text = "Ви ще не проходили тест.";
            }


        }
        

        private void StartTest_button_Click(object sender, EventArgs e)
        {
            Test test = new Test(Login,Password);
            this.Hide();
            test.Show(this);
        }
    }
}