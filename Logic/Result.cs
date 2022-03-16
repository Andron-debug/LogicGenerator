using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            result_textBox.Text = $"СДНФ{nl}{eq.ToPDF()}{nl}СКНФ{nl}{eq.ToPCF()}{nl}СПНФ{nl}{eq.ToPolinom()}";
        }
        private void Result_Load(object sender, System.EventArgs e)
        {

        }
    }
}
