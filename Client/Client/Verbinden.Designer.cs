namespace Client
{
    partial class Verbinden
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
            this.cmdVerbinden = new System.Windows.Forms.Button();
            this.cmdclose = new System.Windows.Forms.Button();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdVerbinden
            // 
            this.cmdVerbinden.Location = new System.Drawing.Point(12, 64);
            this.cmdVerbinden.Name = "cmdVerbinden";
            this.cmdVerbinden.Size = new System.Drawing.Size(75, 23);
            this.cmdVerbinden.TabIndex = 0;
            this.cmdVerbinden.Text = "Verbinden";
            this.cmdVerbinden.UseVisualStyleBackColor = true;
            this.cmdVerbinden.Click += new System.EventHandler(this.cmdVerbinden_Click);
            // 
            // cmdclose
            // 
            this.cmdclose.Location = new System.Drawing.Point(127, 64);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 23);
            this.cmdclose.TabIndex = 1;
            this.cmdclose.Text = "Schließen";
            this.cmdclose.UseVisualStyleBackColor = true;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(75, 12);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(127, 20);
            this.txtAdresse.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 20);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adresse:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // Verbinden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 94);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.cmdclose);
            this.Controls.Add(this.cmdVerbinden);
            this.Name = "Verbinden";
            this.Text = "Verbinden";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Verbinden_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdVerbinden;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}