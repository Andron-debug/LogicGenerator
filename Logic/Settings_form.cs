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



        private void Settings_form_Load(object sender, EventArgs e)
        {
            and_textBox.Text = LogicEq.And;
            or_textBox.Text = LogicEq.Or;
            no_textBox.Text = LogicEq.Not;
            xor_textBox.Text = LogicEq.Xor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LogicEq.And = and_textBox.Text;
                LogicEq.Or = or_textBox.Text;
                LogicEq.Not = no_textBox.Text;
                LogicEq.Xor = xor_textBox.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DialogResult set()
        {
                LogicEq.And = and_textBox.Text;
                LogicEq.Or = or_textBox.Text;
                LogicEq.Not = no_textBox.Text;
                LogicEq.Xor = xor_textBox.Text;
                return DialogResult.OK;
        }
    }
}
