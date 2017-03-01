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
            this.cmdTrennen = new System.Windows.Forms.Button();
            this.btnInsertBoar = new System.Windows.Forms.Button();
            this.btnInsertPeach = new System.Windows.Forms.Button();
            this.btnInsertAubergine = new System.Windows.Forms.Button();
            this.btnInsertMonkey = new System.Windows.Forms.Button();
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
            // cmdTrennen
            // 
            this.cmdTrennen.Enabled = false;
            this.cmdTrennen.Location = new System.Drawing.Point(12, 234);
            this.cmdTrennen.Name = "cmdTrennen";
            this.cmdTrennen.Size = new System.Drawing.Size(75, 23);
            this.cmdTrennen.TabIndex = 4;
            this.cmdTrennen.Text = "Trennen";
            this.cmdTrennen.UseVisualStyleBackColor = true;
            this.cmdTrennen.Click += new System.EventHandler(this.cmdTrennen_Click);
            // 
            // btnInsertBoar
            // 
            this.btnInsertBoar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertBoar.Location = new System.Drawing.Point(279, 13);
            this.btnInsertBoar.Name = "btnInsertBoar";
            this.btnInsertBoar.Size = new System.Drawing.Size(47, 33);
            this.btnInsertBoar.TabIndex = 5;
            this.btnInsertBoar.Text = "🐗";
            this.btnInsertBoar.UseVisualStyleBackColor = true;
            this.btnInsertBoar.Click += new System.EventHandler(this.emojiButtonPressed);
            // 
            // btnInsertPeach
            // 
            this.btnInsertPeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertPeach.Location = new System.Drawing.Point(279, 52);
            this.btnInsertPeach.Name = "btnInsertPeach";
            this.btnInsertPeach.Size = new System.Drawing.Size(47, 33);
            this.btnInsertPeach.TabIndex = 5;
            this.btnInsertPeach.Text = "🍆";
            this.btnInsertPeach.UseVisualStyleBackColor = true;
            this.btnInsertPeach.Click += new System.EventHandler(this.emojiButtonPressed);
            // 
            // btnInsertAubergine
            // 
            this.btnInsertAubergine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertAubergine.Location = new System.Drawing.Point(278, 91);
            this.btnInsertAubergine.Name = "btnInsertAubergine";
            this.btnInsertAubergine.Size = new System.Drawing.Size(47, 33);
            this.btnInsertAubergine.TabIndex = 5;
            this.btnInsertAubergine.Text = "🍑";
            this.btnInsertAubergine.UseVisualStyleBackColor = true;
            this.btnInsertAubergine.Click += new System.EventHandler(this.emojiButtonPressed);
            // 
            // btnInsertMonkey
            // 
            this.btnInsertMonkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertMonkey.Location = new System.Drawing.Point(278, 130);
            this.btnInsertMonkey.Name = "btnInsertMonkey";
            this.btnInsertMonkey.Size = new System.Drawing.Size(47, 33);
            this.btnInsertMonkey.TabIndex = 5;
            this.btnInsertMonkey.Text = "🙈";
            this.btnInsertMonkey.UseVisualStyleBackColor = true;
            this.btnInsertMonkey.Click += new System.EventHandler(this.emojiButtonPressed);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 261);
            this.Controls.Add(this.btnInsertMonkey);
            this.Controls.Add(this.btnInsertAubergine);
            this.Controls.Add(this.btnInsertPeach);
            this.Controls.Add(this.btnInsertBoar);
            this.Controls.Add(this.cmdTrennen);
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
        private System.Windows.Forms.Button cmdTrennen;
        private System.Windows.Forms.Button btnInsertBoar;
        private System.Windows.Forms.Button btnInsertPeach;
        private System.Windows.Forms.Button btnInsertAubergine;
        private System.Windows.Forms.Button btnInsertMonkey;
    }
}

