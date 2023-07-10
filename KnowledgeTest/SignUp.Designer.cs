using System.ComponentModel;

namespace KnowledgeTest
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FIO_label = new System.Windows.Forms.Label();
            this.Login_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Email_label = new System.Windows.Forms.Label();
            this.FIO_textBox = new System.Windows.Forms.TextBox();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.Error_label = new System.Windows.Forms.Label();
            this.SignUp_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FIO_label
            // 
            this.FIO_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIO_label.Location = new System.Drawing.Point(81, 55);
            this.FIO_label.Name = "FIO_label";
            this.FIO_label.Size = new System.Drawing.Size(388, 28);
            this.FIO_label.TabIndex = 0;
            this.FIO_label.Text = "ФІО";
            // 
            // Login_label
            // 
            this.Login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_label.Location = new System.Drawing.Point(81, 169);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(313, 28);
            this.Login_label.TabIndex = 1;
            this.Login_label.Text = "Логін";
            // 
            // Password_label
            // 
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_label.Location = new System.Drawing.Point(81, 264);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(313, 28);
            this.Password_label.TabIndex = 2;
            this.Password_label.Text = "Пароль";
            // 
            // Email_label
            // 
            this.Email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email_label.Location = new System.Drawing.Point(81, 368);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(313, 28);
            this.Email_label.TabIndex = 3;
            this.Email_label.Text = "Пошта";
            // 
            // FIO_textBox
            // 
            this.FIO_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIO_textBox.Location = new System.Drawing.Point(81, 86);
            this.FIO_textBox.Name = "FIO_textBox";
            this.FIO_textBox.Size = new System.Drawing.Size(388, 29);
            this.FIO_textBox.TabIndex = 4;
            // 
            // Login_textBox
            // 
            this.Login_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_textBox.Location = new System.Drawing.Point(81, 200);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(388, 29);
            this.Login_textBox.TabIndex = 5;
            // 
            // Password_textBox
            // 
            this.Password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_textBox.Location = new System.Drawing.Point(81, 295);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(388, 29);
            this.Password_textBox.TabIndex = 6;
            // 
            // Email_textBox
            // 
            this.Email_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email_textBox.Location = new System.Drawing.Point(81, 399);
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(388, 29);
            this.Email_textBox.TabIndex = 7;
            // 
            // Error_label
            // 
            this.Error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Error_label.Location = new System.Drawing.Point(81, 470);
            this.Error_label.Name = "Error_label";
            this.Error_label.Size = new System.Drawing.Size(388, 83);
            this.Error_label.TabIndex = 8;
            this.Error_label.Text = "Помилка";
            // 
            // SignUp_button
            // 
            this.SignUp_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUp_button.Location = new System.Drawing.Point(253, 568);
            this.SignUp_button.Name = "SignUp_button";
            this.SignUp_button.Size = new System.Drawing.Size(216, 54);
            this.SignUp_button.TabIndex = 9;
            this.SignUp_button.Text = "Зареєструватись";
            this.SignUp_button.UseVisualStyleBackColor = true;
            this.SignUp_button.Click += new System.EventHandler(this.SignUp_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_button.Location = new System.Drawing.Point(81, 568);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(138, 54);
            this.Back_button.TabIndex = 10;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 715);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.SignUp_button);
            this.Controls.Add(this.Error_label);
            this.Controls.Add(this.Email_textBox);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Login_textBox);
            this.Controls.Add(this.FIO_textBox);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.FIO_label);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button Back_button;

        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.TextBox FIO_textBox;
        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox Email_textBox;
        private System.Windows.Forms.Label Error_label;
        private System.Windows.Forms.Button SignUp_button;

        private System.Windows.Forms.Label Password_label;

        private System.Windows.Forms.Label Login_label;

        private System.Windows.Forms.Label FIO_label;

        #endregion
    }
}