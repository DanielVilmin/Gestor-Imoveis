
namespace Gestor_de_imoveis
{
    partial class FrmImoveis
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
            this.listBoxImoveis = new System.Windows.Forms.ListBox();
            this.btnAtribuir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxImoveis
            // 
            this.listBoxImoveis.FormattingEnabled = true;
            this.listBoxImoveis.Location = new System.Drawing.Point(121, 38);
            this.listBoxImoveis.Name = "listBoxImoveis";
            this.listBoxImoveis.Size = new System.Drawing.Size(291, 95);
            this.listBoxImoveis.TabIndex = 0;
            // 
            // btnAtribuir
            // 
            this.btnAtribuir.Location = new System.Drawing.Point(180, 173);
            this.btnAtribuir.Name = "btnAtribuir";
            this.btnAtribuir.Size = new System.Drawing.Size(158, 51);
            this.btnAtribuir.TabIndex = 1;
            this.btnAtribuir.Text = "Atribuir";
            this.btnAtribuir.UseVisualStyleBackColor = true;
            this.btnAtribuir.Click += new System.EventHandler(this.btnAtribuir_Click);
            // 
            // FrmImoveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 260);
            this.Controls.Add(this.btnAtribuir);
            this.Controls.Add(this.listBoxImoveis);
            this.Name = "FrmImoveis";
            this.Text = "FrmImoveis";
            this.Load += new System.EventHandler(this.FrmImoveis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxImoveis;
        private System.Windows.Forms.Button btnAtribuir;
    }
}