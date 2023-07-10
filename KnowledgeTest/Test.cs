using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KnowledgeTest
{
    public partial class Test : Form
    {
        private Timer timer;
        private int remainingTime; // Оставшееся время в секундах 

        
        private string Login;
        private string Password;
        private int currentQuestionIndex = 0;
        private int correctAnswersCount = 0;

        private int Questions_At_Test = 20;// Отвечает за количество заданий в тестах 
        
        static List<int> numbers = new List<int>();
        List<Question> result = new List<Question>();
        
        public Test(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
            InitializeComponent();
            this.Text = "Тест";
            this.FormClosing += Test_Closing;
            this.Load += Test_Load;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            timer = new Timer();
            timer.Interval = 1000; // 1 секунда
            timer.Tick += Timer_Tick;

            remainingTime = 2 * 60; // 2 минуты в секундах
            // remainingTime = 60;

            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            remainingTime--;

            if (remainingTime <= 30)
            {
                Timer_label.ForeColor = Color.Black;
                List<Color> colorList = new List<Color>
                {
                    ColorPack.Violet,
                    ColorPack.Green,
                    ColorPack.Magenta,
                    ColorPack.Yellow,
                    ColorPack.White,
                    ColorPack.Orange,
                    ColorPack.Aquamarine,
                    ColorPack.Blue
                };
                
                Random random = new Random();
                Color randomColor = colorList[random.Next(colorList.Count)];
                Timer_label.BackColor = randomColor;
            }
            
            if (remainingTime <= 0)
            {
                string did_not_make_it = "Ви не встигли відповісти :(";
                
                if (Answer_button_1.Checked || Answer_button_2.Checked ||
                    Answer_button_3.Checked || Answer_button_4.Checked)
                {

                    string[] task;
                    task = DB_Operations.GetTaskByNumber(numbers[currentQuestionIndex]);

                    string selectedAnswer = "";
                    if (Answer_button_1.Checked)
                    {
                        Question question = new Question()
                        {
                            QuestionText = task[3],
                            Code = task[2],
                            UserAnswer = task[4],
                            CorrectAnswer = task[8]
                        };
                        result.Add(question);

                        selectedAnswer = Answer_button_1.Text;
                    }
                    else if (Answer_button_2.Checked)
                    {
                        
                        Question question = new Question()
                        {
                            QuestionText = task[3],
                            Code = task[2],
                            UserAnswer = task[5],
                            CorrectAnswer = task[8]
                        };
                        result.Add(question);
                        
                        selectedAnswer = Answer_button_2.Text;
                    }
                    else if (Answer_button_3.Checked)
                    {
                        Question question = new Question()
                        {
                            QuestionText = task[3],
                            Code = task[2],
                            UserAnswer = task[6],
                            CorrectAnswer = task[8]
                        };
                        result.Add(question);
                        
                        selectedAnswer = Answer_button_3.Text;
                    }
                    else if (Answer_button_4.Checked)
                    {
                        Question question = new Question()
                        {
                            QuestionText = task[3],
                            Code = task[2],
                            UserAnswer = task[7],
                            CorrectAnswer = task[8]
                        };
                        
                        result.Add(question);
                        selectedAnswer = Answer_button_4.Text;
                    }
                  

                    if (selectedAnswer == task[8])
                    {
                        correctAnswersCount++;
                    }
                    currentQuestionIndex++;
                    remainingTime = 2 * 60;
                    
                }
                    
                else if (!(Answer_button_1.Checked || Answer_button_2.Checked ||
                         Answer_button_3.Checked || Answer_button_4.Checked))
                {
                    string[] task;
                    task = DB_Operations.GetTaskByNumber(numbers[currentQuestionIndex]);
                    Question question1 = new Question()
                    {
                        QuestionText = task[3],
                        Code = task[2],
                        UserAnswer = did_not_make_it,
                        CorrectAnswer = task[8]
                    };
                    result.Add(question1);
                    currentQuestionIndex++;
                }
                
                    
                
                
                
                if (currentQuestionIndex < Questions_At_Test)
                {
                    remainingTime = 2 * 60;
                    ShowQuestion(numbers[currentQuestionIndex]);
                }
                else
                {
                    timer.Stop();
                    string result_of_test = "";
                    int counter = 1;
                    foreach (Question question in result)
                    {
                        if (question.UserAnswer == question.CorrectAnswer)
                        {
                            result_of_test += $"\nЗавдання № {counter}: {question.QuestionText}";
                            result_of_test += $"\nВи правильно відповіли )";
                            result_of_test += $"\nВаша відповідь: {question.UserAnswer}";
                            result_of_test += $"\nПравильна відповідь: {question.CorrectAnswer}" ;
                            result_of_test += "\n\n";
                            counter++;
                        }
                        else
                        {
                            result_of_test += $"\nЗавдання № {counter}: {question.QuestionText}";
                            result_of_test += $"\nКод до завдання: {question.Code}";
                            result_of_test += $"\nВаша відповідь: {question.UserAnswer}";
                            result_of_test += $"\nПравильна відповідь: {question.CorrectAnswer}" ;
                            result_of_test += "\n\n";
                            counter++; 
                        }
                       
                    }
                
                    DB_Operations.UpdateScore(correctAnswersCount,Login,Password);
                
                    result_of_test = $"Ви набрали {correctAnswersCount} балів з {Questions_At_Test} можливих.\n" +
                                     $"Більш детальна інформація:\n\n" + result_of_test;
                    Result resulting = new Result(Login,Password,correctAnswersCount,Questions_At_Test,result_of_test);
                    this.Hide();
                    resulting.Show(this);
                
                }
               
            }

            Timer_label.Text = FormatTime(remainingTime); // Обновить значение Label
        }
        private string FormatTime(int timeInSeconds)
        {
            int minutes = timeInSeconds / 60;
            int seconds = timeInSeconds % 60;
            return $"{minutes:D2}:{seconds:D2}";
        }

        public static void GenerateRandomNumbers(int number)
        {
            Random random = new Random();

            while (numbers.Count < number)
            {
                int randomNumber = random.Next(1, 45);// (потом когда доделаю тесты, поставить (1,100)
                if (!numbers.Contains(randomNumber))
                {
                    numbers.Add(randomNumber);
                }
            }
        }

        private void Test_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorPack.DarkBlue;
            
            Font_label.Text = $"Розмір шрифту: {14}";
            Font_label.Font = new Font("Arial", 14);
            Font_label.ForeColor = ColorPack.Aquamarine;
            groupBox.Font = new Font("Arial", 14);
            groupBox.ForeColor = ColorPack.Aquamarine;
            groupBox.Text = "Код";

            Test_textBox.ScrollBars = ScrollBars.Vertical;
            Test_textBox.Dock = DockStyle.Left;
            Test_textBox.ReadOnly = true;
            Test_textBox.TabStop =false;
            Test_textBox.ShortcutsEnabled = false;
            Test_textBox.Font = new Font("Arial", 14);
            Test_textBox.BackColor = ColorPack.DarkBlue;
            Test_textBox.ForeColor = ColorPack.White;

            Plus_Font_button.Font = new Font("Arial", 14);
            Plus_Font_button.BackColor = ColorPack.Magenta;
            Plus_Font_button.ForeColor = ColorPack.White;

            Minus_Font_button.Font = new Font("Arial", 14);
            Minus_Font_button.BackColor = ColorPack.Yellow;
            Minus_Font_button.ForeColor = ColorPack.DarkGray;

            NextQuestion_button.Text = "Наступне завдання";
            NextQuestion_button.ForeColor = ColorPack.White;
            NextQuestion_button.BackColor = ColorPack.Blue;
            NextQuestion_button.Font = new Font("Arial", 14);

            Timer_label.ForeColor = ColorPack.Magenta;
            Timer_label.Font = new Font("Arial", 20);
            
            Theme_label.ForeColor = ColorPack.White;
            Theme_label.BackColor = ColorPack.Blue;
            Theme_label.Text = "Пример текст темы";
            Theme_label.Font = new Font("Arial", 14,FontStyle.Bold);

            Question_label.ForeColor = ColorPack.White;
            Question_label.Font = new Font("Arial", 14);

            Answer_button_1.ForeColor = ColorPack.White;
            Answer_button_1.Font = new Font("Arial", 14);

            Answer_button_2.ForeColor = ColorPack.White;
            Answer_button_2.Font = new Font("Arial", 14);

            Answer_button_3.ForeColor = ColorPack.White;
            Answer_button_3.Font = new Font("Arial", 14);

            Answer_button_4.ForeColor = ColorPack.White;
            Answer_button_4.Font = new Font("Arial", 14);

            
            groupBox.Controls.Add(Test_textBox);
            this.Controls.Add(groupBox);
            GenerateRandomNumbers(Questions_At_Test);
            
            
            
            ShowQuestion(numbers[0]);
            
            timer.Start(); // Запуск таймера



        }

        private void Test_Closing(object sender, FormClosingEventArgs e)
        {
            if (this == Form.ActiveForm) // Проверяем, является ли текущая форма активной формой
            {
                Application.Exit(); // Закрываем всё приложение
            }
        }


        private void Plus_Font_button_Click(object sender, EventArgs e)
        {
            float fontSize = Test_textBox.Font.Size;
            int fontSizeInt = Convert.ToInt32(fontSize);
            if (fontSizeInt < 40)
            {
                fontSizeInt++;
                Test_textBox.Font = new Font("Arial", fontSizeInt);
                string txt = $"Розмір шрифту: {fontSizeInt}";
                Font_label.Text = txt;
            }
        }

        private void Minus_Font_button_Click(object sender, EventArgs e)
        {
            float fontSize = Test_textBox.Font.Size;
            int fontSizeInt = Convert.ToInt32(fontSize);
            if (fontSizeInt>1)
            {
                fontSizeInt--;
                Test_textBox.Font = new Font("Arial", fontSizeInt);
                Font_label.Text = $"Розмір шрифту: {fontSizeInt}";
            }
           
        }
        
        
        private void ShowQuestion(int task_Index)
        {
            
            Timer_label.BackColor = Color.Transparent;
            Timer_label.ForeColor = ColorPack.Magenta;
            
            string[] task;
            task = DB_Operations.GetTaskByNumber(task_Index);

            Theme_label.Text = "Тема: "+ task[1];
            
            if (task[2] != "null")
            {
                Test_textBox.Text = task[2];
            }
            else
            {
                Test_textBox.Text = "Код не передбачено для цього завдання";
            }
            
            if ((currentQuestionIndex+1)==Questions_At_Test)
            {
                NextQuestion_button.BackColor = ColorPack.Yellow;
                NextQuestion_button.ForeColor = ColorPack.DarkGray;
                NextQuestion_button.Text = "Закінчити тестування";
            }
            Question_label.Text =  $"Завдання №{currentQuestionIndex+1}/{Questions_At_Test}.\n" + task[3];
            
            Answer_button_1.Visible = true;
            Answer_button_2.Visible = true;
            Answer_button_3.Visible = true;
            Answer_button_4.Visible = true;
            
            
            if (task[4] != "null")
            {
                Answer_button_1.Text = task[4];
            }
            else Answer_button_1.Visible = false;
            if (task[5] != "null")
            {
                Answer_button_2.Text = task[5];
            }
            else Answer_button_2.Visible = false;
            if (task[6] != "null")
            {
                Answer_button_3.Text = task[6];
            }
            else Answer_button_3.Visible = false;
            if (task[7] != "null")
            {
                Answer_button_4.Text = task[7];
            }
            else Answer_button_4.Visible = false;
            
            
            Answer_button_1.Checked = false;
            Answer_button_2.Checked = false;
            Answer_button_3.Checked = false;
            Answer_button_4.Checked = false;
            
        }


        private void NextQuestion_button_Click(object sender, EventArgs e)
        {
            if (Answer_button_1.Checked || Answer_button_2.Checked ||
                Answer_button_3.Checked || Answer_button_4.Checked)
            {

                string[] task;
                task = DB_Operations.GetTaskByNumber(numbers[currentQuestionIndex]);

                string selectedAnswer = "";
                if (Answer_button_1.Checked)
                {
                    Question question = new Question()
                    {
                        QuestionText = task[3],
                        Code = task[2],
                        UserAnswer = task[4],
                        CorrectAnswer = task[8]
                    };
                    result.Add(question);

                    selectedAnswer = Answer_button_1.Text;
                }
                else if (Answer_button_2.Checked)
                {
                    
                    Question question = new Question()
                    {
                        QuestionText = task[3],
                        Code = task[2],
                        UserAnswer = task[5],
                        CorrectAnswer = task[8]
                    };
                    result.Add(question);
                    
                    selectedAnswer = Answer_button_2.Text;
                }
                else if (Answer_button_3.Checked)
                {
                    Question question = new Question()
                    {
                        QuestionText = task[3],
                        Code = task[2],
                        UserAnswer = task[6],
                        CorrectAnswer = task[8]
                    };
                    result.Add(question);
                    
                    selectedAnswer = Answer_button_3.Text;
                }
                else if (Answer_button_4.Checked)
                {
                    Question question = new Question()
                    {
                        QuestionText = task[3],
                        Code = task[2],
                        UserAnswer = task[7],
                        CorrectAnswer = task[8]
                    };
                    
                    result.Add(question);
                    selectedAnswer = Answer_button_4.Text;
                }

                if (selectedAnswer == task[8])
                {
                    correctAnswersCount++;
                }
                currentQuestionIndex++;
                remainingTime = 2 * 60;
            }
            
            if (currentQuestionIndex < Questions_At_Test)
            {
                ShowQuestion(numbers[currentQuestionIndex]);
            }
            
            else
            {
                timer.Stop();
                string result_of_test = "";
                int counter = 1;
                foreach (Question question in result)
                { 
                    if (question.UserAnswer == question.CorrectAnswer)
                    {
                        result_of_test += $"\nЗавдання № {counter}: {question.QuestionText}";
                        result_of_test += $"\nВи правильно відповіли )";
                        result_of_test += $"\nВаша відповідь: {question.UserAnswer}";
                        result_of_test += $"\nПравильна відповідь: {question.CorrectAnswer}" ;
                        result_of_test += "\n\n";
                        counter++;
                    }
                    else
                    {
                        result_of_test += $"\nЗавдання № {counter}: {question.QuestionText}";
                        result_of_test += $"\nКод до завдання: {question.Code}";
                        result_of_test += $"\nВаша відповідь: {question.UserAnswer}";
                        result_of_test += $"\nПравильна відповідь: {question.CorrectAnswer}" ;
                        result_of_test += "\n\n";
                        counter++; 
                    }
                }
                
                DB_Operations.UpdateScore(correctAnswersCount,Login,Password);
                
                result_of_test = $"Ви набрали {correctAnswersCount} балів з {Questions_At_Test} можливих.\n" +
                                 $"Більш детальна інформація:\n\n" + result_of_test;
                Result resulting = new Result(Login,Password,correctAnswersCount,Questions_At_Test,result_of_test);
                this.Hide();
                resulting.Show(this);
                
            }
        }
        
    }
}