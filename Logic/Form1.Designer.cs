
namespace Logic
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.variable_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.true_table = new System.Windows.Forms.TableLayoutPanel();
            this.do_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // variable_comboBox
            // 
            this.variable_comboBox.FormattingEnabled = true;
            this.variable_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.variable_comboBox.Location = new System.Drawing.Point(15, 36);
            this.variable_comboBox.Name = "variable_comboBox";
            this.variable_comboBox.Size = new System.Drawing.Size(121, 24);
            this.variable_comboBox.TabIndex = 1;
            this.variable_comboBox.SelectedIndexChanged += new System.EventHandler(this.variable_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество переменных";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Таблица истинности";
            // 
            // true_table
            // 
            this.true_table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.true_table.AutoSize = true;
            this.true_table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.true_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.true_table.ColumnCount = 2;
            this.true_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.true_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.true_table.Location = new System.Drawing.Point(0, 159);
            this.true_table.Name = "true_table";
            this.true_table.Padding = new System.Windows.Forms.Padding(10);
            this.true_table.RowCount = 2;
            this.true_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.true_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.true_table.Size = new System.Drawing.Size(451, 23);
            this.true_table.TabIndex = 5;
            // 
            // do_button
            // 
            this.do_button.Location = new System.Drawing.Point(15, 71);
            this.do_button.Name = "do_button";
            this.do_button.Size = new System.Drawing.Size(147, 24);
            this.do_button.TabIndex = 6;
            this.do_button.Text = "Построить";
            this.do_button.UseVisualStyleBackColor = true;
            this.do_button.Click += new System.EventHandler(this.do_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(15, 97);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(147, 24);
            this.clear_button.TabIndex = 7;
            this.clear_button.Text = "Чистить";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(482, 194);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.do_button);
            this.Controls.Add(this.true_table);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.variable_comboBox);
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox variable_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel true_table;
        private System.Windows.Forms.Button do_button;
        private System.Windows.Forms.Button clear_button;
    }
}

