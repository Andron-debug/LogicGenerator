
namespace Logic
{
    partial class Settings_form
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.and_textBox = new System.Windows.Forms.TextBox();
            this.or_textBox = new System.Windows.Forms.TextBox();
            this.no_textBox = new System.Windows.Forms.TextBox();
            this.xor_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "И";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Или";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Не";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(10, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Xor";
            // 
            // and_textBox
            // 
            this.and_textBox.Location = new System.Drawing.Point(60, 11);
            this.and_textBox.Name = "and_textBox";
            this.and_textBox.Size = new System.Drawing.Size(100, 22);
            this.and_textBox.TabIndex = 5;
            // 
            // or_textBox
            // 
            this.or_textBox.Location = new System.Drawing.Point(60, 41);
            this.or_textBox.Name = "or_textBox";
            this.or_textBox.Size = new System.Drawing.Size(100, 22);
            this.or_textBox.TabIndex = 6;
            // 
            // no_textBox
            // 
            this.no_textBox.Location = new System.Drawing.Point(60, 71);
            this.no_textBox.Name = "no_textBox";
            this.no_textBox.Size = new System.Drawing.Size(100, 22);
            this.no_textBox.TabIndex = 7;
            // 
            // xor_textBox
            // 
            this.xor_textBox.Location = new System.Drawing.Point(60, 101);
            this.xor_textBox.Name = "xor_textBox";
            this.xor_textBox.Size = new System.Drawing.Size(100, 22);
            this.xor_textBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 155);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xor_textBox);
            this.Controls.Add(this.no_textBox);
            this.Controls.Add(this.or_textBox);
            this.Controls.Add(this.and_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Settings_form";
            this.Text = "Settings_form";
            this.Load += new System.EventHandler(this.Settings_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox and_textBox;
        private System.Windows.Forms.TextBox or_textBox;
        private System.Windows.Forms.TextBox no_textBox;
        private System.Windows.Forms.TextBox xor_textBox;
        private System.Windows.Forms.Button button1;
    }
}