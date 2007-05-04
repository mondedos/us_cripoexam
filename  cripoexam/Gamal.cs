using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using criptoETSI;

namespace CriptoExam
{
    public partial class Gamal : Form
    {
        public Gamal()
        {
            InitializeComponent();
        }

        private void calcularM_Click(object sender, EventArgs e)
        {
            long p = long.Parse(pTxb.Text);
            long par1 = long.Parse(textBox1.Text);
            long par2 = long.Parse(textBox2.Text);

            long x = long.Parse(xTxb.Text);

            long res = (par1 * CriptoUtil.potenciaRapida(par2, x, p)) % p;

            mTxb.Text = res.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_ParentChanged(object sender, EventArgs e)
        {

        }

        private void label3_ParentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long p = long.Parse(pTxb.Text);
            long g = long.Parse(gTxb.Text);
            long x = long.Parse(xTxb.Text);

            long res = CriptoUtil.potenciaRapida(g, x, p);

            textBox1.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long p = long.Parse(pTxb.Text);
            long k = long.Parse(kTxb.Text);
            long y = long.Parse(textBox1.Text);

            long m = long.Parse(mTxb.Text);

            long res = (m * CriptoUtil.potenciaRapida(y, k, p)) % p;

            textBox2.Text = res.ToString();
        }
    }
}