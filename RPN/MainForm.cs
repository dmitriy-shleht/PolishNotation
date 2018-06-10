using System;
using System.Windows.Forms;

namespace RPN
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string result = ReversePN.ToRPN(tbIn.Text);
            tbRpn.Text = result;
            tbOut.Text = ReversePN.CalculateRPN(result).ToString();
        }
    }
}
