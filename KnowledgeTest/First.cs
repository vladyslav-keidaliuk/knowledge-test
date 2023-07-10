using System;
using System.Drawing;
using System.Windows.Forms;

namespace KnowledgeTest
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
            this.Text = "KnowledgeTest";
            this.Width = 1000;
            this.Height = 1000;
            this.BackColor = ColorPack.DarkBlue;

            this.Load += new EventHandler(First_Load);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
        }

        private void First_Load(object sender, EventArgs e)
        {
            Register_button.Text = "Реєстрація";
            Register_button.Font = new Font("Inter", 24);
            Register_button.BackColor = ColorPack.Orange;
            Register_button.Size = new Size(300, 80);
            Register_button.Location = new Point(130, 850);
            
            Register_button.Click += new EventHandler(Register_button_Click);
            
            Controls.Add(Register_button);
            
            
            Login_button.Text = "Авторизація";
            Login_button.Font = new Font("Inter", 24);
            Login_button.BackColor = ColorPack.Blue;
            Login_button.Size = new Size(250, 80);
            Login_button.Location = new Point(600, 850);
            
            Login_button.Click += new EventHandler(Login_button_Click);
            
            Controls.Add(Login_button);
            
            
            label1.Font = new Font("Arial", 14);
            label1.ForeColor = ColorPack.White;
            label1.Text = @"Вітаємо Вас у додатку для тестування знань з мови C#. Тестування націлене на перевірку знань з наступних тем :

1.	Модифікатори доступу. Управління доступом.

2.	Передача об'єктів методам за посиланням. Методи передачі аргументів методу. Використання модифікаторів параметрів ref та out.

3.	Використання змінної кількості аргументів. Повернення об’єктів з методів. Повернення масиву з методу.

4.	Перевантаження методів. Перевантаження конструкторів.

5.	Ініціалізатори об’єктів. Необов’язкові аргументи, неоднозначність та перевантаження методів. Іменовані аргументи.

6.	Метод Main(). Повернення значень методу Main().Передача аргументів методом Main().

7.	Рекурсія. Застосування ключового слова static. Статичні конструктори. Статичні класи.


Або це Глава 8 Частини 1 книги С# Шилдт 

Будьте уважні, усі завдання різні! Кожне завдання має лише одну відповідь.
При реєстрації вказуйте свою дійсну електрону пошту Google, бо детальні результати тестування прийдуть саме на пошту. 

На кожне завдання відводиться по 2 хвилини. Якщо час вийде і не буде відмічено жодної відповіді, то завдання відповідно не будуть зараховані та автоматичне буде відкрито наступне завдання. 
";


        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp(); 
            this.Hide();
            signUpForm.Show(this);

        }


        private void Login_button_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide(); 
            logIn.Show(this);
        }
        
        
    }
}