namespace Fibonacci
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
            this.bntMostrar = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.lsbFibonacci = new System.Windows.Forms.ListBox();
            this.lblFibonacci = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntMostrar
            // 
            this.bntMostrar.Location = new System.Drawing.Point(12, 338);
            this.bntMostrar.Name = "bntMostrar";
            this.bntMostrar.Size = new System.Drawing.Size(65, 23);
            this.bntMostrar.TabIndex = 0;
            this.bntMostrar.Text = "Mostrar";
            this.bntMostrar.UseVisualStyleBackColor = true;
            this.bntMostrar.Click += new System.EventHandler(this.bntMostrar_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(12, 367);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(65, 23);
            this.bntLimpar.TabIndex = 1;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(12, 396);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(65, 23);
            this.bntSair.TabIndex = 2;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // lsbFibonacci
            // 
            this.lsbFibonacci.FormattingEnabled = true;
            this.lsbFibonacci.Location = new System.Drawing.Point(12, 68);
            this.lsbFibonacci.Name = "lsbFibonacci";
            this.lsbFibonacci.Size = new System.Drawing.Size(95, 264);
            this.lsbFibonacci.TabIndex = 3;
            // 
            // lblFibonacci
            // 
            this.lblFibonacci.AutoSize = true;
            this.lblFibonacci.Location = new System.Drawing.Point(12, 31);
            this.lblFibonacci.Name = "lblFibonacci";
            this.lblFibonacci.Size = new System.Drawing.Size(95, 13);
            this.lblFibonacci.TabIndex = 4;
            this.lblFibonacci.Text = "Série de Fibonacci";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 422);
            this.Controls.Add(this.lblFibonacci);
            this.Controls.Add(this.lsbFibonacci);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.bntMostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntMostrar;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.ListBox lsbFibonacci;
        private System.Windows.Forms.Label lblFibonacci;
    }
}

