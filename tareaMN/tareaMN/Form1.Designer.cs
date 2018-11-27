namespace tareaMN
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblR = new System.Windows.Forms.Label();
            this.btnCalcTrapecio = new System.Windows.Forms.Button();
            this.cbMetodos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(447, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 546);
            this.panel1.TabIndex = 0;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(31, 67);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "b";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(31, 125);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "n";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(31, 172);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(28, 411);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(55, 13);
            this.lblR.TabIndex = 8;
            this.lblR.Text = "Resultado";
            // 
            // btnCalcTrapecio
            // 
            this.btnCalcTrapecio.Location = new System.Drawing.Point(31, 311);
            this.btnCalcTrapecio.Name = "btnCalcTrapecio";
            this.btnCalcTrapecio.Size = new System.Drawing.Size(75, 23);
            this.btnCalcTrapecio.TabIndex = 9;
            this.btnCalcTrapecio.Text = "Calcular";
            this.btnCalcTrapecio.UseVisualStyleBackColor = true;
            this.btnCalcTrapecio.Click += new System.EventHandler(this.btnCalcTrapecio_Click);
            // 
            // cbMetodos
            // 
            this.cbMetodos.FormattingEnabled = true;
            this.cbMetodos.Items.AddRange(new object[] {
            "Regla del trapecio",
            "Simpson 1/3"});
            this.cbMetodos.Location = new System.Drawing.Point(294, 12);
            this.cbMetodos.Name = "cbMetodos";
            this.cbMetodos.Size = new System.Drawing.Size(121, 21);
            this.cbMetodos.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Metodo;";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 570);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMetodos);
            this.Controls.Add(this.btnCalcTrapecio);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Button btnCalcTrapecio;
        private System.Windows.Forms.ComboBox cbMetodos;
        private System.Windows.Forms.Label label4;
    }
}

