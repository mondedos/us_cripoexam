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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mcdButton_Click(object sender, EventArgs e)
        {
            long a = long.Parse(aTexBox.Text);
            long b = long.Parse(bTextBox.Text);
            resultTbx.Text = criptoETSI.CriptoUtil.mcd(a, b).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long a = long.Parse(aTexBox.Text);
            long b = long.Parse(bTextBox.Text);
            resultTbx.Text = criptoETSI.CriptoUtil.mcm(a,b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long a = long.Parse(aTexBox.Text);
            long b = long.Parse(bTextBox.Text);
            resultTbx.Text = criptoETSI.CriptoUtil.toStringBezout(a,b);
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            long a = long.Parse(aTexBox.Text);
            long b = long.Parse(bTextBox.Text);
            long r = (a % b);
            if (r < 0)
                r += b;
            resultTbx.Text = r + "";
        }

        private void invModbtn_Click(object sender, EventArgs e)
        {
            long a = long.Parse(aTexBox.Text);
            long b = long.Parse(bTextBox.Text);
            try
            {
                resultTbx.Text = criptoETSI.CriptoUtil.invModN(a, b)+"";
            }
            catch (ArithmeticException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            long a = long.Parse(aTexBox.Text);
            long b = long.Parse(bTextBox.Text);
            long n = long.Parse(resultTbx.Text);
            try
            {

                resultTbx.Text = criptoETSI.CriptoUtil.resolverIncongruencia(a,b,n) + "";
            }
            catch (ArithmeticException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RSAForm formulario= new RSAForm();
            formulario.Show();
        }

        private void potenciaRapida_Click(object sender, EventArgs e)
        {
            long a = long.Parse(aTexBox.Text);
            long b = long.Parse(bTextBox.Text);
            long n = long.Parse(resultTbx.Text);
            resultTbx.Text = criptoETSI.CriptoUtil.potenciaRapida(a, b, n).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new Gamal()).Show();
        }
    }
}