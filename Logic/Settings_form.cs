using System;
using System.Windows.Forms;

namespace Logic
{
    public partial class Settings_form : Form
    {
        public Settings_form()
        {
            InitializeComponent();
        }

        string and;
        string or;
        string not;
        string xor;

        private void Settings_form_Load(object sender, EventArgs e)
        {
            and_textBox.Text = LogicEq.And;
            or_textBox.Text = LogicEq.Or;
            not_textBox.Text = LogicEq.Not;
            xor_textBox.Text = LogicEq.Xor;

            and = LogicEq.And;
            or = LogicEq.Or;
            not = LogicEq.Not;
            xor = LogicEq.Xor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LogicEq.And = and_textBox.Text;
                LogicEq.Or = or_textBox.Text;
                LogicEq.Not = not_textBox.Text;
                LogicEq.Xor = xor_textBox.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Settings_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogicEq.And = and;
            LogicEq.Or = or;
            LogicEq.Not = not;
            LogicEq.Xor = xor;
        }
    }
}
