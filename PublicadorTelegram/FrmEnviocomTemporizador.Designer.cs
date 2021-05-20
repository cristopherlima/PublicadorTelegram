namespace PublicadorTelegram
{
    partial class FrmEnviocomTemporizador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbMensagens = new System.Windows.Forms.ListBox();
            this.btnCarregarMensagens = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.prbStatusEnvio = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatusEnvio = new System.Windows.Forms.Label();
            this.timerControle = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbMensagens
            // 
            this.lbMensagens.BackColor = System.Drawing.SystemColors.Info;
            this.lbMensagens.FormattingEnabled = true;
            this.lbMensagens.Location = new System.Drawing.Point(17, 59);
            this.lbMensagens.Name = "lbMensagens";
            this.lbMensagens.Size = new System.Drawing.Size(605, 238);
            this.lbMensagens.TabIndex = 0;
            // 
            // btnCarregarMensagens
            // 
            this.btnCarregarMensagens.Location = new System.Drawing.Point(352, 303);
            this.btnCarregarMensagens.Name = "btnCarregarMensagens";
            this.btnCarregarMensagens.Size = new System.Drawing.Size(132, 23);
            this.btnCarregarMensagens.TabIndex = 1;
            this.btnCarregarMensagens.Text = "Carregar Mensagens";
            this.btnCarregarMensagens.UseVisualStyleBackColor = true;
            this.btnCarregarMensagens.Click += new System.EventHandler(this.btnCarregarMensagens_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(490, 303);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(132, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar Mensagens";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // prbStatusEnvio
            // 
            this.prbStatusEnvio.Location = new System.Drawing.Point(17, 345);
            this.prbStatusEnvio.Name = "prbStatusEnvio";
            this.prbStatusEnvio.Size = new System.Drawing.Size(605, 49);
            this.prbStatusEnvio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mensagens:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status de Envio:";
            // 
            // lblStatusEnvio
            // 
            this.lblStatusEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusEnvio.Location = new System.Drawing.Point(14, 397);
            this.lblStatusEnvio.Name = "lblStatusEnvio";
            this.lblStatusEnvio.Size = new System.Drawing.Size(608, 23);
            this.lblStatusEnvio.TabIndex = 6;
            this.lblStatusEnvio.Text = "Aguardando Envio...";
            this.lblStatusEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerControle
            // 
            this.timerControle.Tick += new System.EventHandler(this.timerControle_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tempo (segundos):";
            // 
            // txtTempo
            // 
            this.txtTempo.BackColor = System.Drawing.SystemColors.Info;
            this.txtTempo.Location = new System.Drawing.Point(573, 13);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(49, 20);
            this.txtTempo.TabIndex = 8;
            this.txtTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempo_KeyPress);
            // 
            // FrmEnviocomTemporizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 430);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStatusEnvio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prbStatusEnvio);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnCarregarMensagens);
            this.Controls.Add(this.lbMensagens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEnviocomTemporizador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temporizador";
            this.Load += new System.EventHandler(this.FrmEnviocomTemporizador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMensagens;
        private System.Windows.Forms.Button btnCarregarMensagens;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ProgressBar prbStatusEnvio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatusEnvio;
        private System.Windows.Forms.Timer timerControle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTempo;
    }
}