using System.ComponentModel;

namespace KnowledgeTest
{
    partial class AfterLogin
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
            this.Top_label = new System.Windows.Forms.Label();
            this.FIO_label = new System.Windows.Forms.Label();
            this.Score_label = new System.Windows.Forms.Label();
            this.StartTest_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Top_label
            // 
            this.Top_label.Location = new System.Drawing.Point(72, 196);
            this.Top_label.Name = "Top_label";
            this.Top_label.Size = new System.Drawing.Size(628, 384);
            this.Top_label.TabIndex = 0;
            this.Top_label.Text = "label1";
            // 
            // FIO_label
            // 
            this.FIO_label.Location = new System.Drawing.Point(72, 53);
            this.FIO_label.Name = "FIO_label";
            this.FIO_label.Size = new System.Drawing.Size(628, 42);
            this.FIO_label.TabIndex = 1;
            this.FIO_label.Text = "Ваше ФІО";
            // 
            // Score_label
            // 
            this.Score_label.Location = new System.Drawing.Point(72, 125);
            this.Score_label.Name = "Score_label";
            this.Score_label.Size = new System.Drawing.Size(628, 42);
            this.Score_label.TabIndex = 2;
            this.Score_label.Text = "На скільки пройшов";
            // 
            // StartTest_button
            // 
            this.StartTest_button.Location = new System.Drawing.Point(276, 596);
            this.StartTest_button.Name = "StartTest_button";
            this.StartTest_button.Size = new System.Drawing.Size(239, 61);
            this.StartTest_button.TabIndex = 3;
            this.StartTest_button.Text = "Почати тест";
            this.StartTest_button.UseVisualStyleBackColor = true;
            this.StartTest_button.Click += new System.EventHandler(this.StartTest_button_Click);
            // 
            // AfterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 757);
            this.Controls.Add(this.StartTest_button);
            this.Controls.Add(this.Score_label);
            this.Controls.Add(this.FIO_label);
            this.Controls.Add(this.Top_label);
            this.Name = "AfterLogin";
            this.Text = "AfterLogin";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button StartTest_button;

        private System.Windows.Forms.Label Score_label;

        private System.Windows.Forms.Label FIO_label;

        private System.Windows.Forms.Label Top_label;

        #endregion
    }
}