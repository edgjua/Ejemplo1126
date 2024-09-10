namespace Ejemplo1126
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btModulo = new System.Windows.Forms.Button();
            this.btPotencia = new System.Windows.Forms.Button();
            this.btRaizCuadrada = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.lbRespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Escriba un número";
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(386, 234);
            this.txtNumero2.MaxLength = 5;
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(188, 30);
            this.txtNumero2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Escriba un número";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(386, 154);
            this.txtNumero1.MaxLength = 5;
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(188, 30);
            this.txtNumero1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(259, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 59);
            this.label1.TabIndex = 5;
            this.label1.Text = "Operaciones varias";
            // 
            // btModulo
            // 
            this.btModulo.Location = new System.Drawing.Point(45, 375);
            this.btModulo.Name = "btModulo";
            this.btModulo.Size = new System.Drawing.Size(164, 49);
            this.btModulo.TabIndex = 10;
            this.btModulo.Text = "Módulo";
            this.btModulo.UseVisualStyleBackColor = true;
            this.btModulo.Click += new System.EventHandler(this.btModulo_Click);
            // 
            // btPotencia
            // 
            this.btPotencia.Location = new System.Drawing.Point(282, 375);
            this.btPotencia.Name = "btPotencia";
            this.btPotencia.Size = new System.Drawing.Size(164, 49);
            this.btPotencia.TabIndex = 11;
            this.btPotencia.Text = "Potencia";
            this.btPotencia.UseVisualStyleBackColor = true;
            this.btPotencia.Click += new System.EventHandler(this.btPotencia_Click);
            // 
            // btRaizCuadrada
            // 
            this.btRaizCuadrada.Location = new System.Drawing.Point(519, 375);
            this.btRaizCuadrada.Name = "btRaizCuadrada";
            this.btRaizCuadrada.Size = new System.Drawing.Size(164, 49);
            this.btRaizCuadrada.TabIndex = 12;
            this.btRaizCuadrada.Text = "Raíz cuadrada";
            this.btRaizCuadrada.UseVisualStyleBackColor = true;
            this.btRaizCuadrada.Click += new System.EventHandler(this.btRaizCuadrada_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(737, 375);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(164, 49);
            this.btLimpiar.TabIndex = 13;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // lbRespuesta
            // 
            this.lbRespuesta.AutoSize = true;
            this.lbRespuesta.Location = new System.Drawing.Point(654, 202);
            this.lbRespuesta.Name = "lbRespuesta";
            this.lbRespuesta.Size = new System.Drawing.Size(0, 31);
            this.lbRespuesta.TabIndex = 14;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 497);
            this.Controls.Add(this.lbRespuesta);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btRaizCuadrada);
            this.Controls.Add(this.btPotencia);
            this.Controls.Add(this.btModulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Ejemplo2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btModulo;
        private System.Windows.Forms.Button btPotencia;
        private System.Windows.Forms.Button btRaizCuadrada;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label lbRespuesta;
    }
}