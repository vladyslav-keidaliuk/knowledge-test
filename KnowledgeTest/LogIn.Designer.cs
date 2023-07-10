using System.ComponentModel;

namespace KnowledgeTest
{
    partial class LogIn
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
            this.Login_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Back_button = new System.Windows.Forms.Button();
            this.Start_test_button = new System.Windows.Forms.Button();
            this.Error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_label
            // 
            this.Login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_label.Location = new System.Drawing.Point(195, 59);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(288, 60);
            this.Login_label.TabIndex = 0;
            this.Login_label.Text = "Ваш логін";
            // 
            // Password_label
            // 
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_label.Location = new System.Drawing.Point(195, 185);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(288, 62);
            this.Password_label.TabIndex = 1;
            this.Password_label.Text = "Ваш пароль";
            // 
            // Login_textBox
            // 
            this.Login_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_textBox.Location = new System.Drawing.Point(195, 122);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(288, 29);
            this.Login_textBox.TabIndex = 2;
            // 
            // Password_textBox
            // 
            this.Password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_textBox.Location = new System.Drawing.Point(195, 250);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(288, 29);
            this.Password_textBox.TabIndex = 3;
            // 
            // Back_button
            // 
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_button.Location = new System.Drawing.Point(125, 341);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(186, 68);
            this.Back_button.TabIndex = 4;
            this.Back_button.Text = "button1";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Start_test_button
            // 
            this.Start_test_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_test_button.Location = new System.Drawing.Point(388, 341);
            this.Start_test_button.Name = "Start_test_button";
            this.Start_test_button.Size = new System.Drawing.Size(186, 68);
            this.Start_test_button.TabIndex = 5;
            this.Start_test_button.Text = "button1";
            this.Start_test_button.UseVisualStyleBackColor = true;
            this.Start_test_button.Click += new System.EventHandler(this.Start_test_button_Click);
            // 
            // Error_label
            // 
            this.Error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Error_label.Location = new System.Drawing.Point(124, 430);
            this.Error_label.Name = "Error_label";
            this.Error_label.Size = new System.Drawing.Size(449, 35);
            this.Error_label.TabIndex = 6;
            this.Error_label.Text = "label1";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 529);
            this.Controls.Add(this.Error_label);
            this.Controls.Add(this.Start_test_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Login_textBox);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Login_label);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Start_test_button;
        private System.Windows.Forms.Label Error_label;

        #endregion
    }
}