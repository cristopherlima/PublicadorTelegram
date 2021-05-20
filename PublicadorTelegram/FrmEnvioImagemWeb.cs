using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot; // necessário para uso do Telegram
using Telegram.Bot.Types.Enums; // necessário para uso do Telegram
using System.Net; // Usado para correção de Erro SSL


namespace PublicadorTelegram
{
    public partial class FrmEnvioImagemWeb : Form
    {
        public FrmEnvioImagemWeb()
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

        private void FrmEnvioImagemWeb_Load(object sender, EventArgs e)
        {

        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            
            if (txtUrlImagem.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe a URL da Imagem!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; 

            }

            try
            {
               var telegramBot = new TelegramBotClient("1874683221:AAHP3NNZfDs7zjBvDj1mc6wZKIGjmshqaMQ");

                // requisição para pegar a imagem da Web
                var imagemRequest = WebRequest.Create(txtUrlImagem.Text.Trim());

                // o que fazer com a resposta da requisição
                using (var imagemResponse = imagemRequest.GetResponse())
                {
                    // converte a resposta para objeto do tipo stream
                    var stream = imagemResponse.GetResponseStream();

                    // Parametros
                    // photo: endereço da imagem (no caso é o stream)
                    // caption: Mensagem ou legenda da foto
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
                txtUrlImagem.Text = string.Empty;
                txtMensagem.Text = string.Empty;
                
            }
        }
    }
}
