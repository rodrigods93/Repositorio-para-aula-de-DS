using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_04_02_20
{
    public partial class FrmMedia : Form
    {
        public FrmMedia()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            double num3;
            double media;

            try
            {

                num1 = double.Parse(txtNum1.Text);
                num2 = double.Parse(txtNum2.Text);
                num3 = double.Parse(txtNum3.Text);
                media = (num1 + num2 + num3) / 3;
                MessageBox.Show("Media: " + media);
                if (media >= 7)
                {
                    MessageBox.Show("Aluno Aprovado");
                }
                else if (media >= 4 && media < 7)
                {
                    MessageBox.Show("Aluno em Recuperação");
                }
                else
                {
                    MessageBox.Show("Aluno Reprovado");
                }

            }
            catch(FormatException)
            {
                MessageBox.Show("Formato Incorreto, por favor digitar somente numeros");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
