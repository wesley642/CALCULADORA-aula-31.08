using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA_aula_31._08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            /// testeeeee 222
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtvalor1.Text) || string.IsNullOrEmpty(txtvalor2.Text))
            {
                MessageBox.Show("O campo não pode estar vazio!");
            }
            else
            {

                lblsinal.Text = btndivisao.Text;
                double valor1 = Convert.ToDouble(txtvalor1.Text);
                double valor2 = Convert.ToDouble(txtvalor2.Text);
                double resu = 0;

                resu = (valor1 / valor2);

                lblresultado.Text = resu.ToString();
            }


        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            lblsinal.Text = btnmulti.Text;
            double valor1 = Convert.ToDouble(txtvalor1.Text);
            double valor2 = Convert.ToDouble(txtvalor2.Text);
            double resu = 0;

            resu = (valor1 * valor2);

            lblresultado.Text = resu.ToString();
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            lblsinal.Text = btnmenos.Text;
            double valor1 = Convert.ToDouble(txtvalor1.Text);
            double valor2 = Convert.ToDouble(txtvalor2.Text);
            double resu = 0;

            resu = (valor1 - valor2);

            lblresultado.Text = resu.ToString();
        }

        private void btnmais_Click(object sender, EventArgs e)
        {
            lblsinal.Text = btnmais.Text;
            double valor1 = Convert.ToDouble(txtvalor1.Text);
            double valor2 = Convert.ToDouble(txtvalor2.Text);
            double resu = 0;

            resu = (valor1 + valor2);

            lblresultado.Text = resu.ToString();
        }
    }
}
