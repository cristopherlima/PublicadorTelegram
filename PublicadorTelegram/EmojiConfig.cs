namespace PublicadorTelegram
{

    // Classe estática (não precisa instanciar para usar os métodos presentes nela
    // Essa clase será usada para o tratamento dos Emojis (para não ter que ficar criando os if's toda hora que precisar
    public static class EmojiConfig
    {
        public static string Config(string strMensagem)
        {

            if (strMensagem.Contains(":blush:")) // Código do Emoji (pego no Telegram Web)
                strMensagem = strMensagem.Replace(":blush:", char.ConvertFromUtf32(0x1F60A)); //Converte para código Unicode (Sempre inicia com 0x e depois colocar o valor copiado do site (depois do +)
                        
            // Caso tenha mais emojis, criar mais if's (sem usar else, porque pode ter vários emojis no texto) 
            // if...


            return strMensagem;
        }
    }
}
