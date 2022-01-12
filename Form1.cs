using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class calc : Form
    {
        double val1 = 0, val2 = 0, result = 0;

        private void salvaValores()
        {
            val1 = Convert.ToDouble(txtVal1.Text);
            val2 = Convert.ToDouble(txtVal2.Text);
        }

        public calc()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            salvaValores();
            result = val1 + val2;
            exibeResult();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            salvaValores();
            result = val1 - val2;
            exibeResult();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            salvaValores();
            result = val1 * val2;
            exibeResult();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            salvaValores();
            result = val1 / val2;
            exibeResult();
        }

        private void exibeResult()
        {
            lblResult.Text = Convert.ToString(result);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
