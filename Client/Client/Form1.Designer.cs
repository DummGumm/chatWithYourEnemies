namespace Client
{
    partial class Client
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdSenden = new System.Windows.Forms.Button();
            this.txtBoxZuServer = new System.Windows.Forms.TextBox();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.cmdVerbinden = new System.Windows.Forms.Button();
            this.cmdTrennen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSenden
            // 
            this.cmdSenden.Enabled = false;
            this.cmdSenden.Location = new System.Drawing.Point(197, 234);
            this.cmdSenden.Name = "cmdSenden";
            this.cmdSenden.Size = new System.Drawing.Size(75, 23);
            this.cmdSenden.TabIndex = 0;
            this.cmdSenden.Text = "Senden";
            this.cmdSenden.UseVisualStyleBackColor = true;
            this.cmdSenden.Click += new System.EventHandler(this.cmdSenden_Click);
            // 
            // txtBoxZuServer
            // 
            this.txtBoxZuServer.Location = new System.Drawing.Point(8, 208);
            this.txtBoxZuServer.Name = "txtBoxZuServer";
            this.txtBoxZuServer.Size = new System.Drawing.Size(264, 20);
            this.txtBoxZuServer.TabIndex = 1;
            this.txtBoxZuServer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxZuServer_KeyDown);
            // 
            // lbChat
            // 
            this.lbChat.FormattingEnabled = true;
            this.lbChat.Location = new System.Drawing.Point(8, 12);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(264, 186);
            this.lbChat.TabIndex = 2;
            this.lbChat.TabStop = false;
            // 
            // cmdVerbinden
            // 
            this.cmdVerbinden.Location = new System.Drawing.Point(8, 234);
            this.cmdVerbinden.Name = "cmdVerbinden";
            this.cmdVerbinden.Size = new System.Drawing.Size(75, 23);
            this.cmdVerbinden.TabIndex = 3;
            this.cmdVerbinden.Text = "Verbinden";
            this.cmdVerbinden.UseVisualStyleBackColor = true;
            this.cmdVerbinden.Click += new System.EventHandler(this.cmdVerbinden_Click);
            // 
            // cmdTrennen
            // 
            this.cmdTrennen.Enabled = false;
            this.cmdTrennen.Location = new System.Drawing.Point(104, 234);
            this.cmdTrennen.Name = "cmdTrennen";
            this.cmdTrennen.Size = new System.Drawing.Size(75, 23);
            this.cmdTrennen.TabIndex = 4;
            this.cmdTrennen.Text = "Trennen";
            this.cmdTrennen.UseVisualStyleBackColor = true;
            this.cmdTrennen.Click += new System.EventHandler(this.cmdTrennen_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmdTrennen);
            this.Controls.Add(this.cmdVerbinden);
            this.Controls.Add(this.lbChat);
            this.Controls.Add(this.txtBoxZuServer);
            this.Controls.Add(this.cmdSenden);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSenden;
        private System.Windows.Forms.TextBox txtBoxZuServer;
        private System.Windows.Forms.ListBox lbChat;
        private System.Windows.Forms.Button cmdVerbinden;
        private System.Windows.Forms.Button cmdTrennen;
    }
}

