using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Telegram.Bot; // necessário para uso do Telegram
using Telegram.Bot.Types.Enums; // necessário para uso do Telegram
using System.Net; // Usado para correção de Erro SSL

namespace PublicadorTelegram
{
    public partial class FrmEnviocomTemporizador : Form
    {
        private List<string> lstMensagens; // Declarando lista (GLOBAL) que será usada no Carregamento de Mensagens
        private int posicaoEnvio; // Contador para indicar posição atual no envio (em qual mensagem está)

        public FrmEnviocomTemporizador() // Aqui instânciamos os objetos globais
        {
            InitializeComponent();

            lstMensagens = new List<string>(); // Instância lista
            btnEnviar.Enabled = false; // Desabilita o botão no momento em que o formulário for carregado

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

        private void PrepararEnvio()
        {
            posicaoEnvio = 0;
            InicializarProgressBar();
            InicializarTimerControle();

        }

        private void InicializarProgressBar()
        {
            prbStatusEnvio.Value = 0;
            prbStatusEnvio.Maximum = lstMensagens.Count;
        }


        private void InicializarTimerControle()
        {
            var segundos = Convert.ToInt32(txtTempo.Text.Trim());

            //timerControle.Interval = segundos * 60 * 1000; // Se for minutos (alterar o nome da variável também, para minutos)
            timerControle.Interval = segundos * 1000;
            timerControle.Enabled = true;

            // Atribuir (+=) método ao evento Tick do Timer
            this.timerControle.Tick += new EventHandler(timerControle_Tick);

            // Alterar a cor de fundo do formulário (somente para indicar visualmente que o timer foi inicializado)
            this.BackColor = Color.Red; 

        }

        private void PararTimerControle()
        {
            timerControle.Enabled = false;

            // Remover método do envento Tick do Timer
            timerControle.Tick -= new EventHandler(timerControle_Tick);

            // Voltar Cor Padrão do Formulário (indicando que a execução do Timer parou)
            this.BackColor = SystemColors.Control;

            // Habilitar o botão Enviar, de novo.
            btnEnviar.Enabled = true;            

        }

        private void AtualizarProgressoEnvio()
        {
            prbStatusEnvio.Value++; // Atualizar Barra de Progresso            
            lblStatusEnvio.Text = string.Format("Enviando {0} de {1}...", posicaoEnvio, lstMensagens.Count);  //Atualizar label abaixo da barra de progresso

            
        }

        // Mètodo para o Evento Tick do Timer -- O que será executado a cada acionamento do timer
        private async void timerControle_Tick(object sender, EventArgs e)
        {
            try
            {            
                
                    var telegramBot = new TelegramBotClient("1874683221:AAHP3NNZfDs7zjBvDj1mc6wZKIGjmshqaMQ");

                    // Pega mensagem da linha que está sendo lida no momento
                    var mensagemAtual = lstMensagens[posicaoEnvio];

                    // chamar Método da Classe para tratamento dos Emojis                
                    mensagemAtual = EmojiConfig.Config(mensagemAtual);

                    await telegramBot.SendTextMessageAsync(chatId: "-1001454414840", text: mensagemAtual, parseMode: ParseMode.Html);
                             
                    posicaoEnvio++; //Incrementa para poder pegar a próxima posição do lstMensagens
                    // Atualizar ProgressBar
                    AtualizarProgressoEnvio();
                                          

                    // Verificar se chegou à última linha do lstMensagens
                    if (posicaoEnvio == lstMensagens.Count)
                    PararTimerControle();
                

            }
            catch (Exception ex)
            {
                PararTimerControle();              
                MessageBox.Show("Erro ao enviar mensagem: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }           
            
        }



        private void btnCarregarMensagens_Click(object sender, EventArgs e)
        {
            try
            {
                btnCarregarMensagens.Enabled = false; // para evitar que se clique mais de uma vez no botão
                var arquivoMensagens = "Mensagens.txt";

                // Limpar lista e listbox, antes de carregar
                lstMensagens.Clear();
                lbMensagens.Items.Clear();

                using (StreamReader sr = new StreamReader(arquivoMensagens)) // leitura do arquivo (Mensagens.txt)
                {
                    var strLinha = string.Empty; // inicialização da variável para ler cada linha do arquivo de texto

                    while ((strLinha = sr.ReadLine()) != null) // Enquanto houverem linhas no arquivo (enquanto não chegar no final do arquivo)
                    {
                        if (!strLinha.Trim().Equals(string.Empty)) // Se a linha não estiver vazia (ignora linhas em branco) (Um Enter, por exemplo)
                        {
                            lstMensagens.Add(strLinha.Trim()); // Adiciona linhas do arquivo na lista
                            lbMensagens.Items.Add(strLinha.Trim()); // Adiciona linhas do arquivo no list Box


                        }
                    }
                }

                // Habilitar botão "Enviar Mensagens" somente se houverem dados na lista
                if (lstMensagens.Count > 0)
                    btnEnviar.Enabled = true;             

            }
            catch (Exception ex)
            {
                btnCarregarMensagens.Enabled = true; // Habilita novamente o botão, para nova tentativa
                btnEnviar.Enabled = false; // Habilita Novamente botão de envio

                // Limpa lista e listbox
                lstMensagens.Clear();
                lbMensagens.Items.Clear();

                MessageBox.Show("Erro ao carregar o arquivo: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtTempo.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve informar o tempo!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            btnEnviar.Enabled = false;

            // Testar se existe alguma linha no arquivo de texto
            if (lstMensagens.Count == 0)
                MessageBox.Show("Nenhuma linha carregada do arquivo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                PrepararEnvio();


        }

        private void txtTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Evento par validar o que está sendo digitado em txtTempo (para permitir somente números (caracter decimal) e backspace (para poder apagar)


            // Se não for dígito decimal ou backpace
            // 8 é o valor decimal pata bacskape (pegar em uma tabela ascII)

            //https://web.fe.up.pt/~ee96100/projecto/Tabela%20ascii.htm
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true; // Cancelar o Evento

        }

        private void FrmEnviocomTemporizador_Load(object sender, EventArgs e)
        {

        }
    }
}
