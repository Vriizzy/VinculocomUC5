namespace VinculocomUC5
{
    partial class Form1
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
            this.btnObterDados = new System.Windows.Forms.Button();
            this.lboDados = new System.Windows.Forms.ListBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnSalvarComo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObterDados
            // 
            this.btnObterDados.Location = new System.Drawing.Point(236, 233);
            this.btnObterDados.Name = "btnObterDados";
            this.btnObterDados.Size = new System.Drawing.Size(75, 23);
            this.btnObterDados.TabIndex = 0;
            this.btnObterDados.Text = "ObterDados";
            this.btnObterDados.UseVisualStyleBackColor = true;
            this.btnObterDados.Click += new System.EventHandler(this.btnObterDados_Click);
            // 
            // lboDados
            // 
            this.lboDados.FormattingEnabled = true;
            this.lboDados.Location = new System.Drawing.Point(96, 12);
            this.lboDados.Name = "lboDados";
            this.lboDados.Size = new System.Drawing.Size(574, 212);
            this.lboDados.TabIndex = 1;
            this.lboDados.SelectedIndexChanged += new System.EventHandler(this.lboDados_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(434, 233);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(330, 233);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnSalvarComo
            // 
            this.btnSalvarComo.Location = new System.Drawing.Point(330, 279);
            this.btnSalvarComo.Name = "btnSalvarComo";
            this.btnSalvarComo.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarComo.TabIndex = 4;
            this.btnSalvarComo.Text = "SalvarComo";
            this.btnSalvarComo.UseVisualStyleBackColor = true;
            this.btnSalvarComo.Click += new System.EventHandler(this.btnSalvarComo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvarComo);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lboDados);
            this.Controls.Add(this.btnObterDados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObterDados;
        private System.Windows.Forms.ListBox lboDados;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnSalvarComo;
    }
}

