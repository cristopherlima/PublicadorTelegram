namespace PublicadorTelegram
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.envioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarMsgSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarMsgCImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagemDaWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagemLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarMsgCEmojiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarMsgCTemporizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.envioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // envioToolStripMenuItem
            // 
            this.envioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enviarMsgSimplesToolStripMenuItem,
            this.enviarMsgCImagemToolStripMenuItem,
            this.enviarMsgCEmojiToolStripMenuItem,
            this.enviarMsgCTemporizadorToolStripMenuItem});
            this.envioToolStripMenuItem.Name = "envioToolStripMenuItem";
            this.envioToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.envioToolStripMenuItem.Text = "Envio";
            // 
            // enviarMsgSimplesToolStripMenuItem
            // 
            this.enviarMsgSimplesToolStripMenuItem.Name = "enviarMsgSimplesToolStripMenuItem";
            this.enviarMsgSimplesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.enviarMsgSimplesToolStripMenuItem.Text = "Enviar Msg Simples";
            this.enviarMsgSimplesToolStripMenuItem.Click += new System.EventHandler(this.enviarMsgSimplesToolStripMenuItem_Click);
            // 
            // enviarMsgCImagemToolStripMenuItem
            // 
            this.enviarMsgCImagemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagemDaWebToolStripMenuItem,
            this.imagemLocalToolStripMenuItem});
            this.enviarMsgCImagemToolStripMenuItem.Name = "enviarMsgCImagemToolStripMenuItem";
            this.enviarMsgCImagemToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.enviarMsgCImagemToolStripMenuItem.Text = "Enviar Msg c/ Imagem";
            // 
            // imagemDaWebToolStripMenuItem
            // 
            this.imagemDaWebToolStripMenuItem.Name = "imagemDaWebToolStripMenuItem";
            this.imagemDaWebToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.imagemDaWebToolStripMenuItem.Text = "Imagem da Web";
            this.imagemDaWebToolStripMenuItem.Click += new System.EventHandler(this.imagemDaWebToolStripMenuItem_Click);
            // 
            // imagemLocalToolStripMenuItem
            // 
            this.imagemLocalToolStripMenuItem.Name = "imagemLocalToolStripMenuItem";
            this.imagemLocalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.imagemLocalToolStripMenuItem.Text = "Imagem Local";
            this.imagemLocalToolStripMenuItem.Click += new System.EventHandler(this.imagemLocalToolStripMenuItem_Click);
            // 
            // enviarMsgCEmojiToolStripMenuItem
            // 
            this.enviarMsgCEmojiToolStripMenuItem.Name = "enviarMsgCEmojiToolStripMenuItem";
            this.enviarMsgCEmojiToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.enviarMsgCEmojiToolStripMenuItem.Text = "Enviar Msg c/ Emoji";
            this.enviarMsgCEmojiToolStripMenuItem.Click += new System.EventHandler(this.enviarMsgCEmojiToolStripMenuItem_Click);
            // 
            // enviarMsgCTemporizadorToolStripMenuItem
            // 
            this.enviarMsgCTemporizadorToolStripMenuItem.Name = "enviarMsgCTemporizadorToolStripMenuItem";
            this.enviarMsgCTemporizadorToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.enviarMsgCTemporizadorToolStripMenuItem.Text = "Enviar Msg c/ Temporizador";
            this.enviarMsgCTemporizadorToolStripMenuItem.Click += new System.EventHandler(this.enviarMsgCTemporizadorToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(583, 428);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Publicador Telegram";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarMsgSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarMsgCImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagemDaWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagemLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarMsgCEmojiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarMsgCTemporizadorToolStripMenuItem;
    }
}

