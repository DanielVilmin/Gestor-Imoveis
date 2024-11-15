
namespace Gestor_de_imoveis
{
    partial class frmInicial
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
            this.imoveisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirImovelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarImoveisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInquilino = new System.Windows.Forms.Button();
            this.btnProprietario = new System.Windows.Forms.Button();
            this.btnCriarCasa = new System.Windows.Forms.Button();
            this.btnCriarApartamento = new System.Windows.Forms.Button();
            this.btnCriarTerreno = new System.Windows.Forms.Button();
            this.btnAtribuirImovelProp = new System.Windows.Forms.Button();
            this.btnAtribuirImovelInq = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imoveisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1073, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imoveisToolStripMenuItem
            // 
            this.imoveisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirImovelToolStripMenuItem,
            this.mostrarImoveisToolStripMenuItem});
            this.imoveisToolStripMenuItem.Name = "imoveisToolStripMenuItem";
            this.imoveisToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.imoveisToolStripMenuItem.Text = "Imoveis";
            // 
            // inserirImovelToolStripMenuItem
            // 
            this.inserirImovelToolStripMenuItem.Name = "inserirImovelToolStripMenuItem";
            this.inserirImovelToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.inserirImovelToolStripMenuItem.Text = "Inserir imovel";
            this.inserirImovelToolStripMenuItem.Click += new System.EventHandler(this.inserirImovelToolStripMenuItem_Click);
            // 
            // mostrarImoveisToolStripMenuItem
            // 
            this.mostrarImoveisToolStripMenuItem.Name = "mostrarImoveisToolStripMenuItem";
            this.mostrarImoveisToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.mostrarImoveisToolStripMenuItem.Text = "Mostrar Imoveis";
            this.mostrarImoveisToolStripMenuItem.Click += new System.EventHandler(this.mostrarImoveisToolStripMenuItem_Click);
            // 
            // btnInquilino
            // 
            this.btnInquilino.Location = new System.Drawing.Point(23, 56);
            this.btnInquilino.Name = "btnInquilino";
            this.btnInquilino.Size = new System.Drawing.Size(139, 28);
            this.btnInquilino.TabIndex = 3;
            this.btnInquilino.Text = "Adicionar Inquilino";
            this.btnInquilino.UseVisualStyleBackColor = true;
            this.btnInquilino.Click += new System.EventHandler(this.btnInquilino_Click);
            // 
            // btnProprietario
            // 
            this.btnProprietario.Location = new System.Drawing.Point(23, 112);
            this.btnProprietario.Name = "btnProprietario";
            this.btnProprietario.Size = new System.Drawing.Size(139, 28);
            this.btnProprietario.TabIndex = 4;
            this.btnProprietario.Text = "Adicionar Proprietario";
            this.btnProprietario.UseVisualStyleBackColor = true;
            this.btnProprietario.Click += new System.EventHandler(this.btnProprietario_Click);
            // 
            // btnCriarCasa
            // 
            this.btnCriarCasa.Location = new System.Drawing.Point(192, 56);
            this.btnCriarCasa.Name = "btnCriarCasa";
            this.btnCriarCasa.Size = new System.Drawing.Size(139, 28);
            this.btnCriarCasa.TabIndex = 5;
            this.btnCriarCasa.Text = "Criar Casa";
            this.btnCriarCasa.UseVisualStyleBackColor = true;
            this.btnCriarCasa.Click += new System.EventHandler(this.btnCriarCasa_Click);
            // 
            // btnCriarApartamento
            // 
            this.btnCriarApartamento.Location = new System.Drawing.Point(192, 112);
            this.btnCriarApartamento.Name = "btnCriarApartamento";
            this.btnCriarApartamento.Size = new System.Drawing.Size(139, 28);
            this.btnCriarApartamento.TabIndex = 6;
            this.btnCriarApartamento.Text = "Criar Apartamento";
            this.btnCriarApartamento.UseVisualStyleBackColor = true;
            this.btnCriarApartamento.Click += new System.EventHandler(this.btnCriarApartamento_Click);
            // 
            // btnCriarTerreno
            // 
            this.btnCriarTerreno.Location = new System.Drawing.Point(192, 164);
            this.btnCriarTerreno.Name = "btnCriarTerreno";
            this.btnCriarTerreno.Size = new System.Drawing.Size(139, 28);
            this.btnCriarTerreno.TabIndex = 7;
            this.btnCriarTerreno.Text = "Criar Terreno";
            this.btnCriarTerreno.UseVisualStyleBackColor = true;
            this.btnCriarTerreno.Click += new System.EventHandler(this.btnCriarTerreno_Click);
            // 
            // btnAtribuirImovelProp
            // 
            this.btnAtribuirImovelProp.Location = new System.Drawing.Point(337, 56);
            this.btnAtribuirImovelProp.Name = "btnAtribuirImovelProp";
            this.btnAtribuirImovelProp.Size = new System.Drawing.Size(139, 28);
            this.btnAtribuirImovelProp.TabIndex = 8;
            this.btnAtribuirImovelProp.Text = "Atribuir Imovel Prop";
            this.btnAtribuirImovelProp.UseVisualStyleBackColor = true;
            this.btnAtribuirImovelProp.Click += new System.EventHandler(this.btnAtribuirImovelProp_Click);
            // 
            // btnAtribuirImovelInq
            // 
            this.btnAtribuirImovelInq.Location = new System.Drawing.Point(337, 102);
            this.btnAtribuirImovelInq.Name = "btnAtribuirImovelInq";
            this.btnAtribuirImovelInq.Size = new System.Drawing.Size(161, 48);
            this.btnAtribuirImovelInq.TabIndex = 9;
            this.btnAtribuirImovelInq.Text = "Atribuir Imovel Inquilino / Contrato";
            this.btnAtribuirImovelInq.UseVisualStyleBackColor = true;
            this.btnAtribuirImovelInq.Click += new System.EventHandler(this.btnAtribuirImovelInq_Click);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 327);
            this.Controls.Add(this.btnAtribuirImovelInq);
            this.Controls.Add(this.btnAtribuirImovelProp);
            this.Controls.Add(this.btnCriarTerreno);
            this.Controls.Add(this.btnCriarApartamento);
            this.Controls.Add(this.btnCriarCasa);
            this.Controls.Add(this.btnProprietario);
            this.Controls.Add(this.btnInquilino);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicial";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmInicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imoveisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirImovelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarImoveisToolStripMenuItem;
        private System.Windows.Forms.Button btnInquilino;
        private System.Windows.Forms.Button btnProprietario;
        private System.Windows.Forms.Button btnCriarCasa;
        private System.Windows.Forms.Button btnCriarApartamento;
        private System.Windows.Forms.Button btnCriarTerreno;
        private System.Windows.Forms.Button btnAtribuirImovelProp;
        private System.Windows.Forms.Button btnAtribuirImovelInq;
    }
}

