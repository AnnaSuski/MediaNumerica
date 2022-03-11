namespace projetomedianumerica
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCalcularMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o valor de A: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.Color.Black;
            this.txtA.Location = new System.Drawing.Point(261, 13);
            this.txtA.MaxLength = 10;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(102, 23);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "0";
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite o valor de B: ";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.White;
            this.txtB.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.ForeColor = System.Drawing.Color.Black;
            this.txtB.Location = new System.Drawing.Point(261, 61);
            this.txtB.MaxLength = 10;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(102, 23);
            this.txtB.TabIndex = 2;
            this.txtB.Text = "0";
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCalcularMedia
            // 
            this.btnCalcularMedia.BackColor = System.Drawing.Color.IndianRed;
            this.btnCalcularMedia.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularMedia.ForeColor = System.Drawing.Color.White;
            this.btnCalcularMedia.Location = new System.Drawing.Point(74, 117);
            this.btnCalcularMedia.Name = "btnCalcularMedia";
            this.btnCalcularMedia.Size = new System.Drawing.Size(243, 44);
            this.btnCalcularMedia.TabIndex = 3;
            this.btnCalcularMedia.Text = "Calcular Média Númerica";
            this.btnCalcularMedia.UseVisualStyleBackColor = false;
            this.btnCalcularMedia.Click += new System.EventHandler(this.btnCalcularMedia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(393, 176);
            this.Controls.Add(this.btnCalcularMedia);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROGRAMA DA MEDIA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCalcularMedia;
    }
}

