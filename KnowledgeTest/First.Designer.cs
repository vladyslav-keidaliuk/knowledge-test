using System.ComponentModel;

namespace KnowledgeTest
{
    partial class First
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
            this.Register_button = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Register_button
            // 
            this.Register_button.Location = new System.Drawing.Point(211, 1030);
            this.Register_button.Margin = new System.Windows.Forms.Padding(4);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(348, 123);
            this.Register_button.TabIndex = 0;
            this.Register_button.Text = "button1";
            this.Register_button.UseVisualStyleBackColor = true;
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(784, 1030);
            this.Login_button.Margin = new System.Windows.Forms.Padding(4);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(348, 123);
            this.Login_button.TabIndex = 1;
            this.Login_button.Text = "button2";
            this.Login_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(40, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1232, 727);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 1183);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Register_button);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "First";
            this.Text = "First";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.Button Login_button;

        #endregion
    }
}