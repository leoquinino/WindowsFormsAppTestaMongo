namespace WindowsFormsAppTestaMongo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btListaProdutos = new System.Windows.Forms.Button();
            this.lbConexao = new System.Windows.Forms.Label();
            this.txtURLConexao = new System.Windows.Forms.TextBox();
            this.lbBaseDados = new System.Windows.Forms.Label();
            this.txtBancoDados = new System.Windows.Forms.TextBox();
            this.ComboConexao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btListaProdutos
            // 
            this.btListaProdutos.Location = new System.Drawing.Point(2, 150);
            this.btListaProdutos.Name = "btListaProdutos";
            this.btListaProdutos.Size = new System.Drawing.Size(293, 23);
            this.btListaProdutos.TabIndex = 0;
            this.btListaProdutos.Text = "Listar Produtos";
            this.btListaProdutos.UseVisualStyleBackColor = true;
            this.btListaProdutos.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbConexao
            // 
            this.lbConexao.AutoSize = true;
            this.lbConexao.Location = new System.Drawing.Point(-1, 8);
            this.lbConexao.Name = "lbConexao";
            this.lbConexao.Size = new System.Drawing.Size(85, 13);
            this.lbConexao.TabIndex = 1;
            this.lbConexao.Text = "String  Conexão:";
            this.lbConexao.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtURLConexao
            // 
            this.txtURLConexao.Location = new System.Drawing.Point(2, 107);
            this.txtURLConexao.Name = "txtURLConexao";
            this.txtURLConexao.Size = new System.Drawing.Size(665, 20);
            this.txtURLConexao.TabIndex = 2;
            // 
            // lbBaseDados
            // 
            this.lbBaseDados.AutoSize = true;
            this.lbBaseDados.Location = new System.Drawing.Point(2, 52);
            this.lbBaseDados.Name = "lbBaseDados";
            this.lbBaseDados.Size = new System.Drawing.Size(72, 13);
            this.lbBaseDados.TabIndex = 3;
            this.lbBaseDados.Text = "Banco Dados";
            // 
            // txtBancoDados
            // 
            this.txtBancoDados.Location = new System.Drawing.Point(2, 69);
            this.txtBancoDados.Name = "txtBancoDados";
            this.txtBancoDados.Size = new System.Drawing.Size(93, 20);
            this.txtBancoDados.TabIndex = 4;
            this.txtBancoDados.Text = "DigisatServer";
            // 
            // ComboConexao
            // 
            this.ComboConexao.FormattingEnabled = true;
            this.ComboConexao.Items.AddRange(new object[] {
            resources.GetString("ComboConexao.Items"),
            "mongodb://localhost:12220/?serverSelectionTimeoutMS=5000&connectTimeoutMS=10000&a" +
                "uthSource=DigisatServer"});
            this.ComboConexao.Location = new System.Drawing.Point(2, 24);
            this.ComboConexao.Name = "ComboConexao";
            this.ComboConexao.Size = new System.Drawing.Size(760, 21);
            this.ComboConexao.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComboConexao);
            this.Controls.Add(this.txtBancoDados);
            this.Controls.Add(this.lbBaseDados);
            this.Controls.Add(this.txtURLConexao);
            this.Controls.Add(this.lbConexao);
            this.Controls.Add(this.btListaProdutos);
            this.Name = "Form1";
            this.Text = "Conector MongoDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btListaProdutos;
        private System.Windows.Forms.Label lbConexao;
        private System.Windows.Forms.TextBox txtURLConexao;
        private System.Windows.Forms.Label lbBaseDados;
        private System.Windows.Forms.TextBox txtBancoDados;
        private System.Windows.Forms.ComboBox ComboConexao;
    }
}

