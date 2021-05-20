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
    public partial class FrmEnvioTexto : Form
    {
        public FrmEnvioTexto()
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

        // asyng usado em virtude do await
        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            // Verificar se a caixa de texto foi preenchida
            // O Trim ignora espaço antes e depois do texto
            if (txtMensagem.Text.Trim().Equals(string.Empty))
            {
                // Parâmetros da caixa de texto
                // (da esquerda para direita)
                // 1. Texto que irá aparecer na caixa
                // 2. Título da caixa de texto (mesmo título do formulário)
                // 3. Botões que irão aparecer na caixa
                // 4. Ícone que irá aparecer na caixa
                MessageBox.Show("Informe a mensagem para envio!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Fecha após a execução, sem executar o que há abaixo. (usar somente em métodos void)

            }

            try
            {
                // Enviar mensagem para o canal
                var telegramBot = new TelegramBotClient("1874683221:AAHP3NNZfDs7zjBvDj1mc6wZKIGjmshqaMQ");

                // Parâmetros
                // 1.chatID (do canal)
                // 2. text (origem do texto)
                // 3. ParseMode (padrão de envio da mensagem. Deixar html para poder usar tags html)

                //OBS: O uso do await (palavra reservada) é para que a mensagem da caixa texto só seja exibida após a finalização com sucesso do método de envio (para não exibir a mensagem, antes mesmo de enviar)
                await telegramBot.SendTextMessageAsync(chatId: "-1001454414840", text: txtMensagem.Text.Trim().ToString(), parseMode: ParseMode.Html);
                MessageBox.Show("Mensagem enviada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao enviar Mensagem: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                // Limpar Caixa de Texto
                txtMensagem.Text = string.Empty;
            }
        }

        private void FrmEnvioTexto_Load(object sender, EventArgs e)
        {

        }
    }
}
