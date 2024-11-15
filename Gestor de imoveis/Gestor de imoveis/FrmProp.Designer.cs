
namespace Gestor_de_imoveis
{
    partial class FrmProp
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
            this.listBoxProprietarios = new System.Windows.Forms.ListBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxProprietarios
            // 
            this.listBoxProprietarios.FormattingEnabled = true;
            this.listBoxProprietarios.Location = new System.Drawing.Point(83, 42);
            this.listBoxProprietarios.Name = "listBoxProprietarios";
            this.listBoxProprietarios.Size = new System.Drawing.Size(242, 43);
            this.listBoxProprietarios.TabIndex = 0;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(133, 108);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(109, 32);
            this.btnSelecionar.TabIndex = 1;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // FrmProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 167);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.listBoxProprietarios);
            this.Name = "FrmProp";
            this.Text = "FrmProp";
            this.Load += new System.EventHandler(this.FrmProp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProprietarios;
        private System.Windows.Forms.Button btnSelecionar;
    }
}