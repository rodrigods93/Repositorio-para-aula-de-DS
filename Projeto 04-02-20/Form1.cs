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
    public partial class frmCursos : Form
    {
        public frmCursos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtNumeroCurso.Text == "1")//txtNumero se trata da Textbox .text é o que for digitado pelo usuario.
            {
                MessageBox.Show("Técnico em Informática");
            }
            else if (txtNumeroCurso.Text == "2")
            {
                MessageBox.Show("Técnico em Redes");
            }
            else
            {
                MessageBox.Show("Opção inválida");
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // Para sair do aplicativo.
        }
    }
}
