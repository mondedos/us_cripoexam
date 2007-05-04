namespace CriptoExam
{
    partial class Gamal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.pTxb = new System.Windows.Forms.TextBox();
            this.gTxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.xTxb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kTxb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.calcularM = new System.Windows.Forms.Button();
            this.mTxb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.Text = "P";
            // 
            // pTxb
            // 
            this.pTxb.Location = new System.Drawing.Point(24, 5);
            this.pTxb.Name = "pTxb";
            this.pTxb.Size = new System.Drawing.Size(88, 21);
            this.pTxb.TabIndex = 1;
            // 
            // gTxb
            // 
            this.gTxb.Location = new System.Drawing.Point(139, 5);
            this.gTxb.Name = "gTxb";
            this.gTxb.Size = new System.Drawing.Size(88, 21);
            this.gTxb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(118, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.Text = "g";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 21);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.Text = "g^x % p";
            this.label3.ParentChanged += new System.EventHandler(this.label3_ParentChanged);
            // 
            // xTxb
            // 
            this.xTxb.Location = new System.Drawing.Point(25, 32);
            this.xTxb.Name = "xTxb";
            this.xTxb.Size = new System.Drawing.Size(88, 21);
            this.xTxb.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.Text = "x";
            // 
            // kTxb
            // 
            this.kTxb.Location = new System.Drawing.Point(140, 32);
            this.kTxb.Name = "kTxb";
            this.kTxb.Size = new System.Drawing.Size(88, 21);
            this.kTxb.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(119, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.Text = "k";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(77, 21);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(122, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.Text = "(M*y^k) % p";
            this.label6.ParentChanged += new System.EventHandler(this.label6_ParentChanged);
            // 
            // calcularM
            // 
            this.calcularM.Location = new System.Drawing.Point(119, 122);
            this.calcularM.Name = "calcularM";
            this.calcularM.Size = new System.Drawing.Size(72, 20);
            this.calcularM.TabIndex = 17;
            this.calcularM.Text = "Calc M";
            this.calcularM.Click += new System.EventHandler(this.calcularM_Click);
            // 
            // mTxb
            // 
            this.mTxb.Location = new System.Drawing.Point(24, 122);
            this.mTxb.Name = "mTxb";
            this.mTxb.Size = new System.Drawing.Size(88, 21);
            this.mTxb.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.Text = "M";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 20);
            this.button1.TabIndex = 21;
            this.button1.Text = "Calc";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 20);
            this.button2.TabIndex = 22;
            this.button2.Text = "Calc";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Gamal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mTxb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.calcularM);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kTxb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.xTxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gTxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pTxb);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "Gamal";
            this.Text = "Gamal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pTxb;
        private System.Windows.Forms.TextBox gTxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xTxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kTxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calcularM;
        private System.Windows.Forms.TextBox mTxb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}