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
    public partial class FrmEnvioTextoComEmoji : Form
    {
        public FrmEnvioTextoComEmoji()
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

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtMensagem.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe a mensagem para envio!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                

                var telegramBot = new TelegramBotClient("1874683221:AAHP3NNZfDs7zjBvDj1mc6wZKIGjmshqaMQ");

                // Tratamento dos Emojis (um a um, pelo código Unicode) - criação de um string para tratar os emojis
                // *** MAIS INFORMAÇÕES NAS ANOTAÇÕES *** 
                // X:\APK DEV\RELATÓRIOS APK\ESTUDO\C# Canal Telegram
                var strMensagem = txtMensagem.Text.Trim();

                // chamar Método da Classe para tratamento dos Emojis                
                strMensagem = EmojiConfig.Config(strMensagem);                                       

                // Enviará a string strMensagem
                await telegramBot.SendTextMessageAsync(chatId: "-1001454414840", text: strMensagem, parseMode: ParseMode.Html);
                MessageBox.Show("Mensagem enviada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar mensagem: "+ ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                txtMensagem.Text = string.Empty;


            }
        }

        private void FrmEnvioTextoComEmoji_Load(object sender, EventArgs e)
        {

        }
    }
}

