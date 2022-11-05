namespace TP03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtURI = new System.Windows.Forms.TextBox();
            this.gdvDados = new System.Windows.Forms.DataGridView();
            this.btnObterLivros = new System.Windows.Forms.Button();
            this.btnLivrosPorId = new System.Windows.Forms.Button();
            this.btnIncluirLivro = new System.Windows.Forms.Button();
            this.btnAtualizaLivro = new System.Windows.Forms.Button();
            this.btnDeletarLivro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "URI - Web API:";
            // 
            // txtURI
            // 
            this.txtURI.Location = new System.Drawing.Point(102, 6);
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(520, 23);
            this.txtURI.TabIndex = 1;
            // 
            // gdvDados
            // 
            this.gdvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvDados.Location = new System.Drawing.Point(12, 35);
            this.gdvDados.Name = "gdvDados";
            this.gdvDados.RowTemplate.Height = 25;
            this.gdvDados.Size = new System.Drawing.Size(610, 374);
            this.gdvDados.TabIndex = 2;
            // 
            // btnObterLivros
            // 
            this.btnObterLivros.Location = new System.Drawing.Point(12, 415);
            this.btnObterLivros.Name = "btnObterLivros";
            this.btnObterLivros.Size = new System.Drawing.Size(94, 23);
            this.btnObterLivros.TabIndex = 3;
            this.btnObterLivros.Text = "Retornar Livros";
            this.btnObterLivros.UseVisualStyleBackColor = true;
            this.btnObterLivros.Click += new System.EventHandler(this.btnObterLivros_Click);
            // 
            // btnLivrosPorId
            // 
            this.btnLivrosPorId.Location = new System.Drawing.Point(112, 415);
            this.btnLivrosPorId.Name = "btnLivrosPorId";
            this.btnLivrosPorId.Size = new System.Drawing.Size(110, 23);
            this.btnLivrosPorId.TabIndex = 4;
            this.btnLivrosPorId.Text = "Obter Livro por ID";
            this.btnLivrosPorId.UseVisualStyleBackColor = true;
            this.btnLivrosPorId.Click += new System.EventHandler(this.btnLivrosPorId_Click);
            // 
            // btnIncluirLivro
            // 
            this.btnIncluirLivro.Location = new System.Drawing.Point(228, 415);
            this.btnIncluirLivro.Name = "btnIncluirLivro";
            this.btnIncluirLivro.Size = new System.Drawing.Size(78, 23);
            this.btnIncluirLivro.TabIndex = 5;
            this.btnIncluirLivro.Text = "Incluir Livro";
            this.btnIncluirLivro.UseVisualStyleBackColor = true;
            this.btnIncluirLivro.Click += new System.EventHandler(this.btnIncluirLivro_Click);
            // 
            // btnAtualizaLivro
            // 
            this.btnAtualizaLivro.Location = new System.Drawing.Point(312, 415);
            this.btnAtualizaLivro.Name = "btnAtualizaLivro";
            this.btnAtualizaLivro.Size = new System.Drawing.Size(93, 23);
            this.btnAtualizaLivro.TabIndex = 6;
            this.btnAtualizaLivro.Text = "Atualizar Livro";
            this.btnAtualizaLivro.UseVisualStyleBackColor = true;
            this.btnAtualizaLivro.Click += new System.EventHandler(this.btnAtualizaLivro_Click);
            // 
            // btnDeletarLivro
            // 
            this.btnDeletarLivro.Location = new System.Drawing.Point(411, 415);
            this.btnDeletarLivro.Name = "btnDeletarLivro";
            this.btnDeletarLivro.Size = new System.Drawing.Size(81, 23);
            this.btnDeletarLivro.TabIndex = 7;
            this.btnDeletarLivro.Text = "Deletar Livro";
            this.btnDeletarLivro.UseVisualStyleBackColor = true;
            this.btnDeletarLivro.Click += new System.EventHandler(this.btnDeletarLivro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 451);
            this.Controls.Add(this.btnDeletarLivro);
            this.Controls.Add(this.btnAtualizaLivro);
            this.Controls.Add(this.btnIncluirLivro);
            this.Controls.Add(this.btnLivrosPorId);
            this.Controls.Add(this.btnObterLivros);
            this.Controls.Add(this.gdvDados);
            this.Controls.Add(this.txtURI);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SWII6 - TP03";
            ((System.ComponentModel.ISupportInitialize)(this.gdvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtURI;
        private DataGridView gdvDados;
        private Button btnObterLivros;
        private Button btnLivrosPorId;
        private Button btnIncluirLivro;
        private Button btnAtualizaLivro;
        private Button btnDeletarLivro;
    }
}