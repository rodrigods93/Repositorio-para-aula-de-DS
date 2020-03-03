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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void cálcularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando o formulario
            FrmMedia fMedia = new FrmMedia();

            //Indica que o formulario que sera aberto
            //é filho do frm principal
            fMedia.MdiParent = this;

            //Exibirá o Formulario filho.
            fMedia.Show();


        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente encerrar o sistema", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Obrigado por utilizar nossos serviços e até mais !", "*** Obrigado ***", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}
