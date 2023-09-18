namespace FormComplejosG2_2024
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtbReal1 = new System.Windows.Forms.TextBox();
            this.txtbImaginario1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSigno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSuma = new System.Windows.Forms.Label();
            this.txtbReal2 = new System.Windows.Forms.TextBox();
            this.txtbImaginario2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnConjugar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complejo 1";
            // 
            // txtbReal1
            // 
            this.txtbReal1.Location = new System.Drawing.Point(25, 96);
            this.txtbReal1.Name = "txtbReal1";
            this.txtbReal1.Size = new System.Drawing.Size(100, 20);
            this.txtbReal1.TabIndex = 1;
            // 
            // txtbImaginario1
            // 
            this.txtbImaginario1.Location = new System.Drawing.Point(169, 96);
            this.txtbImaginario1.Name = "txtbImaginario1";
            this.txtbImaginario1.Size = new System.Drawing.Size(100, 20);
            this.txtbImaginario1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "i";
            // 
            // lbSigno
            // 
            this.lbSigno.AutoSize = true;
            this.lbSigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSigno.Location = new System.Drawing.Point(326, 85);
            this.lbSigno.Name = "lbSigno";
            this.lbSigno.Size = new System.Drawing.Size(30, 31);
            this.lbSigno.TabIndex = 0;
            this.lbSigno.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(680, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "=";
            // 
            // lbSuma
            // 
            this.lbSuma.AutoSize = true;
            this.lbSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuma.Location = new System.Drawing.Point(731, 84);
            this.lbSuma.Name = "lbSuma";
            this.lbSuma.Size = new System.Drawing.Size(60, 31);
            this.lbSuma.TabIndex = 0;
            this.lbSuma.Text = "0+0";
            // 
            // txtbReal2
            // 
            this.txtbReal2.Location = new System.Drawing.Point(404, 93);
            this.txtbReal2.Name = "txtbReal2";
            this.txtbReal2.Size = new System.Drawing.Size(100, 20);
            this.txtbReal2.TabIndex = 1;
            // 
            // txtbImaginario2
            // 
            this.txtbImaginario2.Location = new System.Drawing.Point(535, 93);
            this.txtbImaginario2.Name = "txtbImaginario2";
            this.txtbImaginario2.Size = new System.Drawing.Size(100, 20);
            this.txtbImaginario2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Complejo 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(641, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "i";
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(554, 135);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 40);
            this.btnSuma.TabIndex = 2;
            this.btnSuma.Text = "Sumar";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnConjugar
            // 
            this.btnConjugar.Location = new System.Drawing.Point(716, 135);
            this.btnConjugar.Name = "btnConjugar";
            this.btnConjugar.Size = new System.Drawing.Size(75, 40);
            this.btnConjugar.TabIndex = 2;
            this.btnConjugar.Text = "Conjugar";
            this.btnConjugar.UseVisualStyleBackColor = true;
            this.btnConjugar.Click += new System.EventHandler(this.btnConjugar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(473, 135);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 40);
            this.btnMultiplicar.TabIndex = 2;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(635, 135);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(75, 40);
            this.btnRestar.TabIndex = 3;
            this.btnRestar.Text = "Restar";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 197);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnConjugar);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtbImaginario2);
            this.Controls.Add(this.txtbReal2);
            this.Controls.Add(this.txtbImaginario1);
            this.Controls.Add(this.lbSuma);
            this.Controls.Add(this.txtbReal1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSigno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbReal1;
        private System.Windows.Forms.TextBox txtbImaginario1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSigno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSuma;
        private System.Windows.Forms.TextBox txtbReal2;
        private System.Windows.Forms.TextBox txtbImaginario2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnConjugar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnRestar;
    }
}

