namespace CriptoExam
{
    partial class Form1
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
            this.aTexBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mcdButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.resultTbx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.modButton = new System.Windows.Forms.Button();
            this.invModbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.generadores = new System.Windows.Forms.Button();
            this.potenciaRapida = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aTexBox
            // 
            this.aTexBox.Location = new System.Drawing.Point(3, 3);
            this.aTexBox.Name = "aTexBox";
            this.aTexBox.Size = new System.Drawing.Size(200, 21);
            this.aTexBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(210, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "A";
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(3, 30);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(200, 21);
            this.bTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(209, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "B";
            // 
            // mcdButton
            // 
            this.mcdButton.Location = new System.Drawing.Point(3, 57);
            this.mcdButton.Name = "mcdButton";
            this.mcdButton.Size = new System.Drawing.Size(76, 19);
            this.mcdButton.TabIndex = 5;
            this.mcdButton.Text = "mcd";
            this.mcdButton.Click += new System.EventHandler(this.mcdButton_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.Text = "Resultado/n";
            // 
            // resultTbx
            // 
            this.resultTbx.Location = new System.Drawing.Point(70, 131);
            this.resultTbx.Multiline = true;
            this.resultTbx.Name = "resultTbx";
            this.resultTbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTbx.Size = new System.Drawing.Size(167, 86);
            this.resultTbx.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 19);
            this.button1.TabIndex = 8;
            this.button1.Text = "mcm";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(153, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 19);
            this.button2.TabIndex = 9;
            this.button2.Text = "bezout";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // modButton
            // 
            this.modButton.Location = new System.Drawing.Point(4, 83);
            this.modButton.Name = "modButton";
            this.modButton.Size = new System.Drawing.Size(75, 20);
            this.modButton.TabIndex = 10;
            this.modButton.Text = "mod";
            this.modButton.Click += new System.EventHandler(this.modButton_Click);
            // 
            // invModbtn
            // 
            this.invModbtn.Location = new System.Drawing.Point(85, 82);
            this.invModbtn.Name = "invModbtn";
            this.invModbtn.Size = new System.Drawing.Size(62, 21);
            this.invModbtn.TabIndex = 14;
            this.invModbtn.Text = "InvMod";
            this.invModbtn.Click += new System.EventHandler(this.invModbtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(154, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 20);
            this.button3.TabIndex = 18;
            this.button3.Text = "ax=b mod n";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(165, 223);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 20);
            this.button4.TabIndex = 22;
            this.button4.Text = "RSA";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // generadores
            // 
            this.generadores.Location = new System.Drawing.Point(3, 109);
            this.generadores.Name = "generadores";
            this.generadores.Size = new System.Drawing.Size(75, 20);
            this.generadores.TabIndex = 26;
            this.generadores.Text = "Generadores";
            // 
            // potenciaRapida
            // 
            this.potenciaRapida.Location = new System.Drawing.Point(85, 108);
            this.potenciaRapida.Name = "potenciaRapida";
            this.potenciaRapida.Size = new System.Drawing.Size(62, 20);
            this.potenciaRapida.TabIndex = 30;
            this.potenciaRapida.Text = "a^b % n";
            this.potenciaRapida.Click += new System.EventHandler(this.potenciaRapida_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(70, 223);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 20);
            this.button5.TabIndex = 31;
            this.button5.Text = "Gamal";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.potenciaRapida);
            this.Controls.Add(this.generadores);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.invModbtn);
            this.Controls.Add(this.modButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultTbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mcdButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aTexBox);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox aTexBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mcdButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultTbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button modButton;
        private System.Windows.Forms.Button invModbtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button generadores;
        private System.Windows.Forms.Button potenciaRapida;
        private System.Windows.Forms.Button button5;
    }
}

