
namespace ProjetoCalc
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
            this.sub = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.potencia = new System.Windows.Forms.Button();
            this.divi = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.boxn1 = new System.Windows.Forms.TextBox();
            this.numero1 = new System.Windows.Forms.Label();
            this.numero2 = new System.Windows.Forms.Label();
            this.boxn2 = new System.Windows.Forms.TextBox();
            this.soma = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sub
            // 
            this.sub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sub.BackgroundImage")));
            this.sub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sub.Location = new System.Drawing.Point(120, 39);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(51, 19);
            this.sub.TabIndex = 1;
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // raiz
            // 
            this.raiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("raiz.BackgroundImage")));
            this.raiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.raiz.Location = new System.Drawing.Point(120, 154);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(51, 20);
            this.raiz.TabIndex = 4;
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // potencia
            // 
            this.potencia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("potencia.BackgroundImage")));
            this.potencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.potencia.Location = new System.Drawing.Point(120, 122);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(51, 26);
            this.potencia.TabIndex = 5;
            this.potencia.UseVisualStyleBackColor = true;
            this.potencia.Click += new System.EventHandler(this.potencia_Click);
            // 
            // divi
            // 
            this.divi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("divi.BackgroundImage")));
            this.divi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.divi.Location = new System.Drawing.Point(120, 90);
            this.divi.Name = "divi";
            this.divi.Size = new System.Drawing.Size(51, 26);
            this.divi.TabIndex = 6;
            this.divi.UseVisualStyleBackColor = true;
            this.divi.Click += new System.EventHandler(this.divi_Click);
            // 
            // mult
            // 
            this.mult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mult.BackgroundImage")));
            this.mult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mult.Location = new System.Drawing.Point(120, 64);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(51, 20);
            this.mult.TabIndex = 7;
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // boxn1
            // 
            this.boxn1.Location = new System.Drawing.Point(2, 68);
            this.boxn1.Name = "boxn1";
            this.boxn1.Size = new System.Drawing.Size(53, 20);
            this.boxn1.TabIndex = 8;
            this.boxn1.TextChanged += new System.EventHandler(this.boxn1_TextChanged);
            // 
            // numero1
            // 
            this.numero1.AutoSize = true;
            this.numero1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero1.Location = new System.Drawing.Point(23, 45);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(19, 13);
            this.numero1.TabIndex = 9;
            this.numero1.Text = "N1";
            this.numero1.Click += new System.EventHandler(this.numero1_Click);
            // 
            // numero2
            // 
            this.numero2.AutoSize = true;
            this.numero2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero2.Location = new System.Drawing.Point(80, 45);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(21, 13);
            this.numero2.TabIndex = 10;
            this.numero2.Text = "N2";
            this.numero2.Click += new System.EventHandler(this.numero2_Click);
            // 
            // boxn2
            // 
            this.boxn2.Location = new System.Drawing.Point(61, 68);
            this.boxn2.Name = "boxn2";
            this.boxn2.Size = new System.Drawing.Size(53, 20);
            this.boxn2.TabIndex = 11;
            this.boxn2.TextChanged += new System.EventHandler(this.boxn2_TextChanged);
            // 
            // soma
            // 
            this.soma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soma.BackgroundImage")));
            this.soma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.soma.Location = new System.Drawing.Point(120, 12);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(49, 21);
            this.soma.TabIndex = 13;
            this.soma.UseVisualStyleBackColor = true;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(12, 122);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 24);
            this.result.TabIndex = 12;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 182);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.result);
            this.Controls.Add(this.boxn2);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.boxn1);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.divi);
            this.Controls.Add(this.potencia);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.sub);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button potencia;
        private System.Windows.Forms.Button divi;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.TextBox boxn1;
        private System.Windows.Forms.Label numero1;
        private System.Windows.Forms.Label numero2;
        private System.Windows.Forms.TextBox boxn2;
        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Label result;
    }
}

