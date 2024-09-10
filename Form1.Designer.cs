namespace Ejemplo1126
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lbRespuesta = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(370, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(320, 120);
            this.txtNumero1.MaxLength = 5;
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(188, 34);
            this.txtNumero1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Escriba un número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Escriba un número";
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(320, 239);
            this.txtNumero2.MaxLength = 5;
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(188, 34);
            this.txtNumero2.TabIndex = 3;
            // 
            // lbRespuesta
            // 
            this.lbRespuesta.AutoSize = true;
            this.lbRespuesta.Location = new System.Drawing.Point(646, 183);
            this.lbRespuesta.Name = "lbRespuesta";
            this.lbRespuesta.Size = new System.Drawing.Size(0, 29);
            this.lbRespuesta.TabIndex = 5;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(320, 389);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(264, 78);
            this.btCalcular.TabIndex = 6;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btSiguiente
            // 
            this.btSiguiente.Location = new System.Drawing.Point(727, 434);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(139, 53);
            this.btSiguiente.TabIndex = 7;
            this.btSiguiente.Text = "Siguiente";
            this.btSiguiente.UseVisualStyleBackColor = true;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 573);
            this.Controls.Add(this.btSiguiente);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbRespuesta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label lbRespuesta;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btSiguiente;
    }
}

