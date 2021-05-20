using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicadorTelegram
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Percorre todos os controles do Form
            // Se o controle estiver marcado como MdiClient
                // atribui a imagem de fundo
            foreach (Control controle in this.Controls)
            {
                if(controle is MdiClient)
                {
                    controle.BackgroundImage = Properties.Resources.wallpaper_azul_papel_de_parede_azul_fundo;
                    break;
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enviarMsgSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnvioTexto();
            frm.MdiParent = this; // indica que o formulário FrmEnvioTexto é filho deste formulário (FrmPrincipal)
            frm.Show();
        }

        private void imagemDaWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnvioImagemWeb();
            frm.MdiParent = this;
            frm.Show();
        }

        private void imagemLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnvioImagemLocal();
            frm.MdiParent = this;
            frm.Show();
        }

        private void enviarMsgCEmojiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnvioTextoComEmoji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void enviarMsgCTemporizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnviocomTemporizador();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
