namespace Lanches_Maju
{
    partial class GerenciamentoPro
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
            this.button_fechar = new System.Windows.Forms.Button();
            this.button_removerCliente = new System.Windows.Forms.Button();
            this.button_pesquisarCliente = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // button_fechar
            // 
            this.button_fechar.BackColor = System.Drawing.Color.Maroon;
            this.button_fechar.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fechar.ForeColor = System.Drawing.Color.White;
            this.button_fechar.Location = new System.Drawing.Point(598, 397);
            this.button_fechar.Name = "button_fechar";
            this.button_fechar.Size = new System.Drawing.Size(190, 39);
            this.button_fechar.TabIndex = 25;
            this.button_fechar.Text = "Fechar";
            this.button_fechar.UseVisualStyleBackColor = false;
            this.button_fechar.Click += new System.EventHandler(this.button_fechar_Click);
            // 
            // button_removerCliente
            // 
            this.button_removerCliente.BackColor = System.Drawing.Color.Maroon;
            this.button_removerCliente.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_removerCliente.ForeColor = System.Drawing.Color.White;
            this.button_removerCliente.Location = new System.Drawing.Point(598, 202);
            this.button_removerCliente.Name = "button_removerCliente";
            this.button_removerCliente.Size = new System.Drawing.Size(190, 38);
            this.button_removerCliente.TabIndex = 24;
            this.button_removerCliente.Text = "Remover";
            this.button_removerCliente.UseVisualStyleBackColor = false;
            this.button_removerCliente.Click += new System.EventHandler(this.button_removerCliente_Click);
            // 
            // button_pesquisarCliente
            // 
            this.button_pesquisarCliente.BackColor = System.Drawing.Color.Maroon;
            this.button_pesquisarCliente.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisarCliente.ForeColor = System.Drawing.Color.White;
            this.button_pesquisarCliente.Location = new System.Drawing.Point(598, 139);
            this.button_pesquisarCliente.Name = "button_pesquisarCliente";
            this.button_pesquisarCliente.Size = new System.Drawing.Size(190, 38);
            this.button_pesquisarCliente.TabIndex = 23;
            this.button_pesquisarCliente.Text = "Pesquisar";
            this.button_pesquisarCliente.UseVisualStyleBackColor = false;
            this.button_pesquisarCliente.Click += new System.EventHandler(this.button_pesquisarCliente_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 120);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(529, 316);
            this.dgvProdutos.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Niagara Solid", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(255, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 68);
            this.label2.TabIndex = 21;
            this.label2.Text = "Editar Produtos";
            // 
            // GerenciamentoPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_fechar);
            this.Controls.Add(this.button_removerCliente);
            this.Controls.Add(this.button_pesquisarCliente);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.label2);
            this.Name = "GerenciamentoPro";
            this.Text = "GerenciamentoPro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_fechar;
        private System.Windows.Forms.Button button_removerCliente;
        private System.Windows.Forms.Button button_pesquisarCliente;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label label2;
    }
}