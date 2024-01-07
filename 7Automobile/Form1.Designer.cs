namespace _7Automobile
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttn_AccSpe = new System.Windows.Forms.Button();
            this.bttn_Accelera = new System.Windows.Forms.Button();
            this.bttn_Amarcia = new System.Windows.Forms.Button();
            this.txt_AccSpe = new System.Windows.Forms.TextBox();
            this.txt_Accelera = new System.Windows.Forms.TextBox();
            this.txt_Amarcia = new System.Windows.Forms.TextBox();
            this.txt_Smarcia = new System.Windows.Forms.TextBox();
            this.bttn_Smarcia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttn_AccSpe
            // 
            this.bttn_AccSpe.Location = new System.Drawing.Point(80, 176);
            this.bttn_AccSpe.Name = "bttn_AccSpe";
            this.bttn_AccSpe.Size = new System.Drawing.Size(132, 42);
            this.bttn_AccSpe.TabIndex = 0;
            this.bttn_AccSpe.Text = "Accendi/Spegni";
            this.bttn_AccSpe.UseVisualStyleBackColor = true;
            this.bttn_AccSpe.Click += new System.EventHandler(this.bttn_AccSpe_Click);
            // 
            // bttn_Accelera
            // 
            this.bttn_Accelera.Location = new System.Drawing.Point(234, 176);
            this.bttn_Accelera.Name = "bttn_Accelera";
            this.bttn_Accelera.Size = new System.Drawing.Size(132, 42);
            this.bttn_Accelera.TabIndex = 1;
            this.bttn_Accelera.Text = "Accelera";
            this.bttn_Accelera.UseVisualStyleBackColor = true;
            // 
            // bttn_Amarcia
            // 
            this.bttn_Amarcia.Location = new System.Drawing.Point(393, 176);
            this.bttn_Amarcia.Name = "bttn_Amarcia";
            this.bttn_Amarcia.Size = new System.Drawing.Size(132, 42);
            this.bttn_Amarcia.TabIndex = 2;
            this.bttn_Amarcia.Text = "Aumenta marcia";
            this.bttn_Amarcia.UseVisualStyleBackColor = true;
            // 
            // txt_AccSpe
            // 
            this.txt_AccSpe.Location = new System.Drawing.Point(80, 140);
            this.txt_AccSpe.Name = "txt_AccSpe";
            this.txt_AccSpe.Size = new System.Drawing.Size(132, 22);
            this.txt_AccSpe.TabIndex = 3;
            // 
            // txt_Accelera
            // 
            this.txt_Accelera.Location = new System.Drawing.Point(234, 140);
            this.txt_Accelera.Name = "txt_Accelera";
            this.txt_Accelera.Size = new System.Drawing.Size(132, 22);
            this.txt_Accelera.TabIndex = 4;
            // 
            // txt_Amarcia
            // 
            this.txt_Amarcia.Location = new System.Drawing.Point(393, 140);
            this.txt_Amarcia.Name = "txt_Amarcia";
            this.txt_Amarcia.Size = new System.Drawing.Size(132, 22);
            this.txt_Amarcia.TabIndex = 5;
            // 
            // txt_Smarcia
            // 
            this.txt_Smarcia.Location = new System.Drawing.Point(553, 140);
            this.txt_Smarcia.Name = "txt_Smarcia";
            this.txt_Smarcia.Size = new System.Drawing.Size(132, 22);
            this.txt_Smarcia.TabIndex = 7;
            // 
            // bttn_Smarcia
            // 
            this.bttn_Smarcia.Location = new System.Drawing.Point(553, 176);
            this.bttn_Smarcia.Name = "bttn_Smarcia";
            this.bttn_Smarcia.Size = new System.Drawing.Size(132, 42);
            this.bttn_Smarcia.TabIndex = 6;
            this.bttn_Smarcia.Text = "Scala marcia";
            this.bttn_Smarcia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Smarcia);
            this.Controls.Add(this.bttn_Smarcia);
            this.Controls.Add(this.txt_Amarcia);
            this.Controls.Add(this.txt_Accelera);
            this.Controls.Add(this.txt_AccSpe);
            this.Controls.Add(this.bttn_Amarcia);
            this.Controls.Add(this.bttn_Accelera);
            this.Controls.Add(this.bttn_AccSpe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_AccSpe;
        private System.Windows.Forms.Button bttn_Accelera;
        private System.Windows.Forms.Button bttn_Amarcia;
        private System.Windows.Forms.TextBox txt_AccSpe;
        private System.Windows.Forms.TextBox txt_Accelera;
        private System.Windows.Forms.TextBox txt_Amarcia;
        private System.Windows.Forms.TextBox txt_Smarcia;
        private System.Windows.Forms.Button bttn_Smarcia;
    }
}

