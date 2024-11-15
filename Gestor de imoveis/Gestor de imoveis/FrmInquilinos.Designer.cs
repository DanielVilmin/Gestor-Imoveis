
namespace Gestor_de_imoveis
{
    partial class FrmInquilinos
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
            this.listBoxInquilinos = new System.Windows.Forms.ListBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxInquilinos
            // 
            this.listBoxInquilinos.FormattingEnabled = true;
            this.listBoxInquilinos.Location = new System.Drawing.Point(75, 23);
            this.listBoxInquilinos.Name = "listBoxInquilinos";
            this.listBoxInquilinos.Size = new System.Drawing.Size(343, 121);
            this.listBoxInquilinos.TabIndex = 0;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(174, 168);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(183, 49);
            this.btnSelecionar.TabIndex = 1;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // FrmInquilinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 305);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.listBoxInquilinos);
            this.Name = "FrmInquilinos";
            this.Text = "FrmInquilinos";
            this.Load += new System.EventHandler(this.FrmInquilinos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxInquilinos;
        private System.Windows.Forms.Button btnSelecionar;
    }
}