using System;
using System.Windows.Forms;
namespace Logic
{
    public partial class Result : Form
    {
        private LogicEq eq;
        public LogicEq ToShow
        {
            set
            {
                eq = value;
                ShowEq();
            }
        }

        public Result()
        {
            InitializeComponent();
        }

        private void Result_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void ShowEq()
        {
            string nl = Environment.NewLine;
            string pdf = eq.ToPDF();
            string pcf = eq.ToPCF();
            string polinom = eq.ToPolinom();
            result_textBox.Text = $"СДНФ{nl}{pdf}{nl}СКНФ{nl}{pcf}{nl}СПНФ{nl}{polinom}{nl}";
            result_textBox.Text += $"Наименьшее количество бинарных операций у ";
            int pdf_count = bin_count(pdf);
            int pcf_count = bin_count(pcf);
            int polinom_count = bin_count(polinom);
            if ((pdf_count <= pcf_count) && (pdf_count <= polinom_count)) result_textBox.Text += "СДНФ ";
            if ((pcf_count <= polinom_count) && (pcf_count <= pdf_count)) result_textBox.Text += "СКНФ ";
            if ((polinom_count <= pdf_count) && (polinom_count <= pcf_count)) result_textBox.Text += "полинома Жегалкина";
        }
        private int bin_count(string e)
        {
            if (e == LogicEq.Non) return int.MaxValue;
            int result = 0;
            result += op_count(e, LogicEq.And);
            result += op_count(e, LogicEq.Or);
            result += op_count(e, LogicEq.Xor);
            return result;
        }
        private int op_count(string e, string op) => (e.Length - e.Replace(op, "").Length) / op.Length;

        private void settings_button_Click(object sender, EventArgs e)
        {
            Form f = new Settings_form();
            if (f.ShowDialog() == DialogResult.OK) ShowEq();
        }

        private void about_button_Click(object sender, EventArgs e)
        {

        }
    }
}
