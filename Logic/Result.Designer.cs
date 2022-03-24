
namespace Logic
{
    partial class Result
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.settings_button = new System.Windows.Forms.Button();
            this.about_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Результат";
            // 
            // result_textBox
            // 
            this.result_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.result_textBox.Location = new System.Drawing.Point(12, 36);
            this.result_textBox.Multiline = true;
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.result_textBox.Size = new System.Drawing.Size(451, 226);
            this.result_textBox.TabIndex = 1;
            // 
            // settings_button
            // 
            this.settings_button.Location = new System.Drawing.Point(205, 10);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(104, 23);
            this.settings_button.TabIndex = 2;
            this.settings_button.Text = "Настройки";
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // about_button
            // 
            this.about_button.Location = new System.Drawing.Point(315, 12);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(104, 23);
            this.about_button.TabIndex = 3;
            this.about_button.Text = "О программе";
            this.about_button.UseVisualStyleBackColor = true;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 273);
            this.Controls.Add(this.about_button);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.label1);
            this.Name = "Result";
            this.Text = "Result";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Result_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox result_textBox;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button about_button;
    }
}