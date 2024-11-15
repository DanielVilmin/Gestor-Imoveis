
namespace Gestor_de_imoveis
{
    partial class FrmLogin
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
            this.Utilizador = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.BtnPessoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Utilizador
            // 
            this.Utilizador.AutoSize = true;
            this.Utilizador.Location = new System.Drawing.Point(12, 58);
            this.Utilizador.Name = "Utilizador";
            this.Utilizador.Size = new System.Drawing.Size(53, 13);
            this.Utilizador.TabIndex = 0;
            this.Utilizador.Text = "Utilizador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Pass:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(71, 55);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(206, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(71, 104);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(206, 20);
            this.txtPass.TabIndex = 3;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(111, 154);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(112, 26);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "Login";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // BtnPessoa
            // 
            this.BtnPessoa.Location = new System.Drawing.Point(257, 12);
            this.BtnPessoa.Name = "BtnPessoa";
            this.BtnPessoa.Size = new System.Drawing.Size(112, 26);
            this.BtnPessoa.TabIndex = 5;
            this.BtnPessoa.Text = "Teste";
            this.BtnPessoa.UseVisualStyleBackColor = true;
            this.BtnPessoa.Click += new System.EventHandler(this.BtnPessoa_Click);
            // 
            // FrmLogin
            // 
            this.ClientSize = new System.Drawing.Size(387, 243);
            this.Controls.Add(this.BtnPessoa);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Utilizador);
            this.Name = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Label Utilizador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button BtnPessoa;
    }
}