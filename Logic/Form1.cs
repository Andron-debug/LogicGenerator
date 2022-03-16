using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Logic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            variable_comboBox.SelectedIndex = 0;
            f = new Result();
            f.Show();
        }

        private CheckBox[] checkBoxes;
        private Result f;
        private int var_count;
        private string[] var_names;
        private void variable_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            true_table.Controls.Clear();
            var_count = Convert.ToInt32(variable_comboBox.SelectedItem);
            true_table.RowCount = (int)Math.Pow(2, var_count) + 1;
            //Создание подписи
            int a = 97;//ACII
            string fn_text = "";
            string var_text = "";
            var_names = new string[var_count];
            for (int i = a; i < a + var_count; i++)
            {
                fn_text += Convert.ToChar(i);
                var_text += Convert.ToChar(i);
                var_names[i - a] = Convert.ToString(Convert.ToChar(i));
                if (i != a + var_count - 1) fn_text += ",";
            }
            Font top_font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
            Label fn_lable = new Label();
            fn_lable.Text = "F(" + fn_text + ")";
            fn_lable.Font = top_font;
            fn_lable.AutoSize = true;
            true_table.Controls.Add(fn_lable, 1, 0);

            Label var_lable = new Label();
            var_lable.Text = var_text;
            var_lable.Font = top_font;
            true_table.Controls.Add(var_lable, 0, 0);

            //Заполнение строк
            Label row_lable = new Label();
            Font main_font = new Font("Microsoft Sans Serif", 10f);
            checkBoxes = new CheckBox[(int)Math.Pow(2, var_count)];
            for (int i = 0; i < Math.Pow(2, var_count); i++)
            {
                row_lable = new Label();
                row_lable.Font = main_font;
                string row_text = Convert.ToString(i, 2);
                row_lable.Text = string.Concat(Enumerable.Repeat("0", var_count - row_text.Length)) + row_text;
                row_lable.AutoSize = true;
                true_table.Controls.Add(row_lable, 0, i + 1);

                checkBoxes[i] = new CheckBox();
                checkBoxes[i].Text = "";
                checkBoxes[i].CheckedChanged += FValueChanged;
                true_table.Controls.Add(checkBoxes[i], 1, i + 1);
            }
            foreach (ColumnStyle st in true_table.ColumnStyles) st.SizeType = SizeType.AutoSize;
            foreach (RowStyle rs in true_table.RowStyles) rs.SizeType = SizeType.AutoSize;
        }

        private void FValueChanged(object sender, EventArgs e)
        {
            bool[] FValues = new bool[(int)Math.Pow(2, var_count)];
            for (int i = 0; i < (int)Math.Pow(2, var_count); i++) FValues[i] = checkBoxes[i].Checked;
            f.ToShow = new LogicEq(FValues, var_names);
        }
    }
}
