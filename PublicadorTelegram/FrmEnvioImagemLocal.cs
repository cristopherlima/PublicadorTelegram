using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Uso de imagem local
using System.Drawing.Imaging; // Uso de imagem local
using Telegram.Bot; // necessário para uso do Telegram
using Telegram.Bot.Types.Enums; // necessário para uso do Telegram
using System.Net; // Usado para correção de Erro SSL


namespace PublicadorTelegram
{
    public partial class FrmEnvioImagemLocal : Form
    {
        public FrmEnvioImagemLocal()
        {
            InitializeComponent();

            // Configuração de TLS (correção do erro "Could not create SSL/TLS secure channel")
            // Colocar em Todos os Forms
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.DefaultConnectionLimit = 9999;
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                 | SecurityProtocolType.Tls11
                                                 | SecurityProtocolType.Tls12
                                                 | SecurityProtocolType.Ssl3;
        }

        private void btnBscImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = @"C:\imagens\"; // pasta inicial
                ofd.Filter = "Imagens (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png"; // formato de origem: extensões possíveis (lado esquerdo do pipe aparece ao usuário) (lado direito do pipe é o filtro)
                ofd.Multiselect = false; // só permite selecionar uma imagem por vez


                if (ofd.ShowDialog() == DialogResult.OK)
                    txtCaminhoImagem.Text = ofd.FileName;                
            }
        }

        // Metodo para transformar imagem em Stream
        private Stream ToStream(Image imagem, ImageFormat formato)
        {
            var stream = new MemoryStream();
            imagem.Save(stream, formato);
            stream.Position = 0;
            return stream;
        }


        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtCaminhoImagem.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Selecione uma imagem!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            try
            {
                var telegramBot = new TelegramBotClient("1874683221:AAHP3NNZfDs7zjBvDj1mc6wZKIGjmshqaMQ");

                using (var imgEnvio = Image.FromFile(txtCaminhoImagem.Text.Trim()))
                {
                    var stream = ToStream(imgEnvio, ImageFormat.Jpeg); // método para chamar imagem e definir formato de destino da imagem

                    await telegramBot.SendPhotoAsync(chatId: "-1001454414840", photo: stream, caption: txtMensagem.Text.Trim().ToString(), parseMode: ParseMode.Html);

                }

                MessageBox.Show("Mensagem enviada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao enviar Mensagem: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                txtCaminhoImagem.Text = string.Empty;
                txtMensagem.Text = string.Empty;

            }
        }
    }
}
