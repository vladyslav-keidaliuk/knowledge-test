using System.ComponentModel;

namespace KnowledgeTest
{
    partial class Result
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
            this.Label_Result = new System.Windows.Forms.Label();
            this.Result_Info_label = new System.Windows.Forms.Label();
            this.Top_label = new System.Windows.Forms.Label();
            this.MainPage_button = new System.Windows.Forms.Button();
            this.CloseApp_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Result
            // 
            this.Label_Result.Location = new System.Drawing.Point(283, 9);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(451, 42);
            this.Label_Result.TabIndex = 0;
            this.Label_Result.Text = "label1";
            // 
            // Result_Info_label
            // 
            this.Result_Info_label.Location = new System.Drawing.Point(31, 62);
            this.Result_Info_label.Name = "Result_Info_label";
            this.Result_Info_label.Size = new System.Drawing.Size(811, 99);
            this.Result_Info_label.TabIndex = 1;
            this.Result_Info_label.Text = "label1";
            // 
            // Top_label
            // 
            this.Top_label.Location = new System.Drawing.Point(31, 210);
            this.Top_label.Name = "Top_label";
            this.Top_label.Size = new System.Drawing.Size(811, 377);
            this.Top_label.TabIndex = 2;
            this.Top_label.Text = "label1";
            // 
            // MainPage_button
            // 
            this.MainPage_button.Location = new System.Drawing.Point(31, 659);
            this.MainPage_button.Name = "MainPage_button";
            this.MainPage_button.Size = new System.Drawing.Size(293, 65);
            this.MainPage_button.TabIndex = 3;
            this.MainPage_button.Text = "button1";
            this.MainPage_button.UseVisualStyleBackColor = true;
            this.MainPage_button.Click += new System.EventHandler(this.MainPage_button_Click);
            // 
            // CloseApp_button
            // 
            this.CloseApp_button.Location = new System.Drawing.Point(524, 659);
            this.CloseApp_button.Name = "CloseApp_button";
            this.CloseApp_button.Size = new System.Drawing.Size(293, 65);
            this.CloseApp_button.TabIndex = 4;
            this.CloseApp_button.Text = "button1";
            this.CloseApp_button.UseVisualStyleBackColor = true;
            this.CloseApp_button.Click += new System.EventHandler(this.CloseApp_button_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 758);
            this.Controls.Add(this.CloseApp_button);
            this.Controls.Add(this.MainPage_button);
            this.Controls.Add(this.Top_label);
            this.Controls.Add(this.Result_Info_label);
            this.Controls.Add(this.Label_Result);
            this.Name = "Result";
            this.Text = "Result";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button CloseApp_button;

        private System.Windows.Forms.Button MainPage_button;

        private System.Windows.Forms.Label Top_label;

        private System.Windows.Forms.Label Result_Info_label;

        private System.Windows.Forms.Label Label_Result;

        #endregion
    }
}