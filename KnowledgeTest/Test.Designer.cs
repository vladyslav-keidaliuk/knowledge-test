using System.ComponentModel;

namespace KnowledgeTest
{
    partial class Test
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.Test_textBox = new System.Windows.Forms.TextBox();
            this.Plus_Font_button = new System.Windows.Forms.Button();
            this.Minus_Font_button = new System.Windows.Forms.Button();
            this.Font_label = new System.Windows.Forms.Label();
            this.Theme_label = new System.Windows.Forms.Label();
            this.Question_label = new System.Windows.Forms.Label();
            this.Answer_button_1 = new System.Windows.Forms.RadioButton();
            this.Answer_button_2 = new System.Windows.Forms.RadioButton();
            this.Answer_button_3 = new System.Windows.Forms.RadioButton();
            this.Answer_button_4 = new System.Windows.Forms.RadioButton();
            this.NextQuestion_button = new System.Windows.Forms.Button();
            this.Timer_label = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.Test_textBox);
            this.groupBox.Location = new System.Drawing.Point(11, 85);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(772, 1103);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // Test_textBox
            // 
            this.Test_textBox.Location = new System.Drawing.Point(1, 21);
            this.Test_textBox.Multiline = true;
            this.Test_textBox.Name = "Test_textBox";
            this.Test_textBox.Size = new System.Drawing.Size(771, 1076);
            this.Test_textBox.TabIndex = 0;
            // 
            // Plus_Font_button
            // 
            this.Plus_Font_button.Location = new System.Drawing.Point(1340, 94);
            this.Plus_Font_button.Name = "Plus_Font_button";
            this.Plus_Font_button.Size = new System.Drawing.Size(72, 47);
            this.Plus_Font_button.TabIndex = 1;
            this.Plus_Font_button.Text = "+";
            this.Plus_Font_button.UseVisualStyleBackColor = true;
            this.Plus_Font_button.Click += new System.EventHandler(this.Plus_Font_button_Click);
            // 
            // Minus_Font_button
            // 
            this.Minus_Font_button.Location = new System.Drawing.Point(1262, 94);
            this.Minus_Font_button.Name = "Minus_Font_button";
            this.Minus_Font_button.Size = new System.Drawing.Size(72, 47);
            this.Minus_Font_button.TabIndex = 2;
            this.Minus_Font_button.Text = "-";
            this.Minus_Font_button.UseVisualStyleBackColor = true;
            this.Minus_Font_button.Click += new System.EventHandler(this.Minus_Font_button_Click);
            // 
            // Font_label
            // 
            this.Font_label.Location = new System.Drawing.Point(977, 94);
            this.Font_label.Name = "Font_label";
            this.Font_label.Size = new System.Drawing.Size(265, 47);
            this.Font_label.TabIndex = 3;
            this.Font_label.Text = "Розмір шрифту:";
            // 
            // Theme_label
            // 
            this.Theme_label.Location = new System.Drawing.Point(11, 12);
            this.Theme_label.Name = "Theme_label";
            this.Theme_label.Size = new System.Drawing.Size(1401, 70);
            this.Theme_label.TabIndex = 4;
            this.Theme_label.Text = "label1";
            // 
            // Question_label
            // 
            this.Question_label.Location = new System.Drawing.Point(789, 153);
            this.Question_label.Name = "Question_label";
            this.Question_label.Size = new System.Drawing.Size(623, 228);
            this.Question_label.TabIndex = 5;
            this.Question_label.Text = "label1";
            // 
            // Answer_button_1
            // 
            this.Answer_button_1.Location = new System.Drawing.Point(789, 423);
            this.Answer_button_1.Name = "Answer_button_1";
            this.Answer_button_1.Size = new System.Drawing.Size(623, 93);
            this.Answer_button_1.TabIndex = 6;
            this.Answer_button_1.TabStop = true;
            this.Answer_button_1.Text = "radioButton1";
            this.Answer_button_1.UseVisualStyleBackColor = true;
            // 
            // Answer_button_2
            // 
            this.Answer_button_2.Location = new System.Drawing.Point(789, 547);
            this.Answer_button_2.Name = "Answer_button_2";
            this.Answer_button_2.Size = new System.Drawing.Size(623, 93);
            this.Answer_button_2.TabIndex = 7;
            this.Answer_button_2.TabStop = true;
            this.Answer_button_2.Text = "radioButton1";
            this.Answer_button_2.UseVisualStyleBackColor = true;
            // 
            // Answer_button_3
            // 
            this.Answer_button_3.Location = new System.Drawing.Point(789, 661);
            this.Answer_button_3.Name = "Answer_button_3";
            this.Answer_button_3.Size = new System.Drawing.Size(623, 93);
            this.Answer_button_3.TabIndex = 8;
            this.Answer_button_3.TabStop = true;
            this.Answer_button_3.Text = "radioButton1";
            this.Answer_button_3.UseVisualStyleBackColor = true;
            // 
            // Answer_button_4
            // 
            this.Answer_button_4.Location = new System.Drawing.Point(789, 786);
            this.Answer_button_4.Name = "Answer_button_4";
            this.Answer_button_4.Size = new System.Drawing.Size(623, 93);
            this.Answer_button_4.TabIndex = 9;
            this.Answer_button_4.TabStop = true;
            this.Answer_button_4.Text = "radioButton1";
            this.Answer_button_4.UseVisualStyleBackColor = true;
            // 
            // NextQuestion_button
            // 
            this.NextQuestion_button.Location = new System.Drawing.Point(977, 1103);
            this.NextQuestion_button.Name = "NextQuestion_button";
            this.NextQuestion_button.Size = new System.Drawing.Size(265, 79);
            this.NextQuestion_button.TabIndex = 10;
            this.NextQuestion_button.Text = "button1";
            this.NextQuestion_button.UseVisualStyleBackColor = true;
            this.NextQuestion_button.Click += new System.EventHandler(this.NextQuestion_button_Click);
            // 
            // Timer_label
            // 
            this.Timer_label.Location = new System.Drawing.Point(811, 94);
            this.Timer_label.Name = "Timer_label";
            this.Timer_label.Size = new System.Drawing.Size(115, 47);
            this.Timer_label.TabIndex = 11;
            this.Timer_label.Text = "Timer";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 1200);
            this.Controls.Add(this.Timer_label);
            this.Controls.Add(this.NextQuestion_button);
            this.Controls.Add(this.Answer_button_4);
            this.Controls.Add(this.Answer_button_3);
            this.Controls.Add(this.Answer_button_2);
            this.Controls.Add(this.Answer_button_1);
            this.Controls.Add(this.Question_label);
            this.Controls.Add(this.Theme_label);
            this.Controls.Add(this.Font_label);
            this.Controls.Add(this.Minus_Font_button);
            this.Controls.Add(this.Plus_Font_button);
            this.Controls.Add(this.groupBox);
            this.Name = "Test";
            this.Text = "Test";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label Timer_label;

        private System.Windows.Forms.Button NextQuestion_button;

        private System.Windows.Forms.RadioButton Answer_button_2;
        private System.Windows.Forms.RadioButton Answer_button_3;
        private System.Windows.Forms.RadioButton Answer_button_4;

        private System.Windows.Forms.RadioButton Answer_button_1;

        private System.Windows.Forms.Label Question_label;

        private System.Windows.Forms.Label Theme_label;

        private System.Windows.Forms.Button Plus_Font_button;
        private System.Windows.Forms.Button Minus_Font_button;
        private System.Windows.Forms.Label Font_label;

        private System.Windows.Forms.TextBox Test_textBox;

        private System.Windows.Forms.GroupBox groupBox;

        #endregion
    }
}