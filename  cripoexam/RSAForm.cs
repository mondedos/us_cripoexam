using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CriptoExam
{
    public partial class RSAForm : Form
    {
        public RSAForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long p = long.Parse(pTbx.Text);
            long q = long.Parse(qtxb.Text);
            long eK = long.Parse(eTxb.Text);

            long n = q * p;
            long fi = (q - 1) * (p - 1);
            long d = criptoETSI.CriptoUtil.invModN(eK, fi);

            nTxb.Text = n.ToString();
            fiTbx.Text = fi.ToString();
            solTxb.Text = d.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long p = long.Parse(pTbx.Text);
            long q = long.Parse(qtxb.Text);
            long eK = long.Parse(eTxb.Text);

            long n = q * p;
            long fi = (q - 1) * (p - 1);
            long lamda = criptoETSI.CriptoUtil.mcm(p - 1, q - 1);

            long dp = criptoETSI.CriptoUtil.invModN(eK, lamda);

            long totalClaves = (n - dp) / lamda;

            string cad = totalClaves + " => ";

            for (long i = 0; i <= totalClaves; i++)
            {
                long nk = dp + lamda * i;
                cad += nk + ",";
            }

            nTxb.Text = n.ToString();
            fiTbx.Text = fi.ToString();
            solTxb.Text = cad ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            long p = long.Parse(pTbx.Text);
            long q = long.Parse(qtxb.Text);
            long eK = long.Parse(eTxb.Text);

            long n = q * p;
            long fi = (q - 1) * (p - 1);
            long d = criptoETSI.CriptoUtil.invModN(eK, fi);

            nTxb.Text = n.ToString();
            fiTbx.Text = fi.ToString();
            solTxb.Text = d.ToString();


            long x = long.Parse(xTbx.Text);

            solTxb.Text = criptoETSI.CriptoUtil.potenciaRapida(x, eK, n).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            long p = long.Parse(pTbx.Text);
            long q = long.Parse(qtxb.Text);
            long eK = long.Parse(eTxb.Text);

            long n = q * p;
            long fi = (q - 1) * (p - 1);
            long d = criptoETSI.CriptoUtil.invModN(eK, fi);

            nTxb.Text = n.ToString();
            fiTbx.Text = fi.ToString();
            solTxb.Text = d.ToString();


            long y = long.Parse(yTxb.Text);

            solTxb.Text = criptoETSI.CriptoUtil.potenciaRapida(y, eK, n).ToString();
        }
    }
}