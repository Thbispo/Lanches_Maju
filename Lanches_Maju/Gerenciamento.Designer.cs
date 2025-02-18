namespace Lanches_Maju
{
    partial class Gerenciamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerenciamento));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCadCliente = new System.Windows.Forms.Button();
            this.buttonEditarCliente = new System.Windows.Forms.Button();
            this.buttonCadProdutos = new System.Windows.Forms.Button();
            this.buttonEditarProduto = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(339, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lanches da Maju";
            // 
            // buttonCadCliente
            // 
            this.buttonCadCliente.BackColor = System.Drawing.Color.Moccasin;
            this.buttonCadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadCliente.Location = new System.Drawing.Point(245, 164);
            this.buttonCadCliente.Name = "buttonCadCliente";
            this.buttonCadCliente.Size = new System.Drawing.Size(162, 54);
            this.buttonCadCliente.TabIndex = 2;
            this.buttonCadCliente.Text = "Cadastrar Cliente";
            this.buttonCadCliente.UseVisualStyleBackColor = false;
            this.buttonCadCliente.Click += new System.EventHandler(this.buttonCadCliente_Click);
            // 
            // buttonEditarCliente
            // 
            this.buttonEditarCliente.BackColor = System.Drawing.Color.Moccasin;
            this.buttonEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarCliente.Location = new System.Drawing.Point(245, 293);
            this.buttonEditarCliente.Name = "buttonEditarCliente";
            this.buttonEditarCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEditarCliente.Size = new System.Drawing.Size(162, 54);
            this.buttonEditarCliente.TabIndex = 3;
            this.buttonEditarCliente.Text = "Editar Clientes";
            this.buttonEditarCliente.UseVisualStyleBackColor = false;
            this.buttonEditarCliente.Click += new System.EventHandler(this.buttonEditarCliente_Click);
            // 
            // buttonCadProdutos
            // 
            this.buttonCadProdutos.BackColor = System.Drawing.Color.Moccasin;
            this.buttonCadProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadProdutos.Location = new System.Drawing.Point(575, 164);
            this.buttonCadProdutos.Name = "buttonCadProdutos";
            this.buttonCadProdutos.Size = new System.Drawing.Size(162, 54);
            this.buttonCadProdutos.TabIndex = 4;
            this.buttonCadProdutos.Text = "Cadastrar Produtos";
            this.buttonCadProdutos.UseVisualStyleBackColor = false;
            this.buttonCadProdutos.Click += new System.EventHandler(this.buttonCadProdutos_Click);
            // 
            // buttonEditarProduto
            // 
            this.buttonEditarProduto.BackColor = System.Drawing.Color.Moccasin;
            this.buttonEditarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarProduto.Location = new System.Drawing.Point(575, 293);
            this.buttonEditarProduto.Name = "buttonEditarProduto";
            this.buttonEditarProduto.Size = new System.Drawing.Size(162, 54);
            this.buttonEditarProduto.TabIndex = 5;
            this.buttonEditarProduto.Text = "Editar Produtos";
            this.buttonEditarProduto.UseVisualStyleBackColor = false;
            this.buttonEditarProduto.Click += new System.EventHandler(this.buttonEditarProduto_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.Color.Maroon;
            this.buttonFechar.ForeColor = System.Drawing.Color.White;
            this.buttonFechar.Location = new System.Drawing.Point(672, 409);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(116, 38);
            this.buttonFechar.TabIndex = 6;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // Gerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonEditarProduto);
            this.Controls.Add(this.buttonCadProdutos);
            this.Controls.Add(this.buttonEditarCliente);
            this.Controls.Add(this.buttonCadCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gerenciamento";
            this.Text = "Gerenciamento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCadCliente;
        private System.Windows.Forms.Button buttonEditarCliente;
        private System.Windows.Forms.Button buttonCadProdutos;
        private System.Windows.Forms.Button buttonEditarProduto;
        private System.Windows.Forms.Button buttonFechar;
    }
}