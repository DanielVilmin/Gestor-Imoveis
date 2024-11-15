
namespace Gestor_de_imoveis
{
    partial class FrmImovelInquilino
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
            this.btnContrato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxImoveis
            // 
            this.listBoxImoveis.FormattingEnabled = true;
            this.listBoxImoveis.Location = new System.Drawing.Point(102, 36);
            this.listBoxImoveis.Name = "listBoxImoveis";
            this.listBoxImoveis.Size = new System.Drawing.Size(283, 108);
            this.listBoxImoveis.TabIndex = 0;
            // 
            // btnContrato
            // 
            this.btnContrato.Location = new System.Drawing.Point(149, 163);
            this.btnContrato.Name = "btnContrato";
            this.btnContrato.Size = new System.Drawing.Size(183, 55);
            this.btnContrato.TabIndex = 1;
            this.btnContrato.Text = "Contrato";
            this.btnContrato.UseVisualStyleBackColor = true;
            this.btnContrato.Click += new System.EventHandler(this.btnContrato_Click);
            // 
            // FrmImovelInquilino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 289);
            this.Controls.Add(this.btnContrato);
            this.Controls.Add(this.listBoxImoveis);
            this.Name = "FrmImovelInquilino";
            this.Text = "FrmImovelInquilino";
            this.Load += new System.EventHandler(this.FrmImovelInquilino_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxImoveis;
        private System.Windows.Forms.Button btnContrato;
    }
}