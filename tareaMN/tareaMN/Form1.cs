using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tareaMN
{
    public partial class Form1 : Form
    {
        TextBox[] ss;
        
        
        int k = 0;
        

        public Form1()
        {
            InitializeComponent();
            
        }
        

        public void CreateFields(double a, double b, double n)
        {
            double incremento = (b - a) / n;
            int y = 10;

            
            ss = new TextBox[Convert.ToInt32(n) + 1];
            
            
            for (int i = 0; a <= b; a += incremento)
            {
                var lbl = new Label();
                lbl.AutoSize = true;
                lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbl.Location = new System.Drawing.Point(20, y);
                lbl.Text = Convert.ToString(Math.Round(a, 4));

                var txt = new TextBox();
                ss[i++] = txt;
                txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txt.Location = new System.Drawing.Point(lbl.Width, y);
                txt.Width = panel1.Width - txt.Location.X - 300;

                panel1.Controls.Add(txt);
                panel1.Controls.Add(lbl);

                y += 60;
                
                
            }
            panel1.PerformLayout();

            
        }
       
        
        public void calcularTrapecio()
        {
            try
            {
                double r = 0;
                double sumT = 0;
                //fx0
                sumT += double.Parse(ss[0].Text);

                //sumatoria
                double enmedio = 0;
                for (int i = 1; i < ss.Length - 1; i++)
                {
                    enmedio += double.Parse(ss[i].Text);
                }
                sumT += 2 * enmedio;

                //fxn

                sumT += double.Parse(ss[ss.Length - 1].Text);

                double a = Convert.ToDouble(txtA.Text),
                b = Convert.ToDouble(txtB.Text),
                n = Convert.ToDouble(txtN.Text);
                r = (b - a) * (sumT / (2 * n));

                lblR.Text = "I = " + Convert.ToString(Math.Round(r, 4));
            }
            catch(FormatException e)
            {
                MessageBox.Show("Ponga valores");
            }
            
        }

        public void calcularSimpson13()
        {

            try
            {
                double r = 0;
                double sumSp = 0;
                //fx0
                sumSp += double.Parse(ss[0].Text);


                double enmedioI = 0;
                double enmedioP = 0;

                //sum impares
                for (int i = 1 + k; i < ss.Length - 1; i++)
                {
                    enmedioI += double.Parse(ss[i].Text);
                    k += i++;
                }
                sumSp += 4 * enmedioI;
                k = 0;
                for (int i = 2 + k; i < ss.Length - 1; i++)
                {
                    enmedioP += double.Parse(ss[i].Text);
                    k += i++ - 2;
                }
                sumSp += 2 * enmedioP;

                //fxn
                sumSp += double.Parse(ss[ss.Length - 1].Text);

                double a = Convert.ToDouble(txtA.Text),
                b = Convert.ToDouble(txtB.Text),
                n = Convert.ToDouble(txtN.Text);

                r = (b - a) * (sumSp / (3 * n));

                lblR.Text = "I = " + Convert.ToString(Math.Round(r, 4));
            }
            catch (FormatException e)
            {
                MessageBox.Show("Ponga valores");
            }
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CreateFields(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text), Convert.ToDouble(txtN.Text));
            }
            catch
            {
                MessageBox.Show("Inserte los valores para crear los campos");
            }
            
            
        }

        private void btnCalcTrapecio_Click(object sender, EventArgs e)
        {
            
            

            if((string)cbMetodos.SelectedItem == "Regla del trapecio")
            {
                calcularTrapecio();
            }
            else if((string)cbMetodos.SelectedItem == "Simpson 1/3")
            {
                calcularSimpson13();
            }
            else
            {
                MessageBox.Show("Elija un metodo");
            }
        }
    }
}
