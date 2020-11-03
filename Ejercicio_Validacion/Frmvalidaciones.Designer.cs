namespace Ejercicio_Validacion
{
    partial class Frmvalidaciones
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Txtnombre = new System.Windows.Forms.TextBox();
            this.Txtcodigo = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.Btnvalidar = new System.Windows.Forms.Button();
            this.LblMostrarResultado = new System.Windows.Forms.Label();
            this.ErrorMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.Txtcontraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo ";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(119, 134);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(38, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Correo";
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(189, 35);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(271, 20);
            this.Txtnombre.TabIndex = 3;
            // 
            // Txtcodigo
            // 
            this.Txtcodigo.Location = new System.Drawing.Point(189, 80);
            this.Txtcodigo.Name = "Txtcodigo";
            this.Txtcodigo.Size = new System.Drawing.Size(271, 20);
            this.Txtcodigo.TabIndex = 4;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(189, 131);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(271, 20);
            this.TxtCorreo.TabIndex = 5;
            // 
            // Btnvalidar
            // 
            this.Btnvalidar.Location = new System.Drawing.Point(242, 232);
            this.Btnvalidar.Name = "Btnvalidar";
            this.Btnvalidar.Size = new System.Drawing.Size(150, 46);
            this.Btnvalidar.TabIndex = 6;
            this.Btnvalidar.Text = "Validar";
            this.Btnvalidar.UseVisualStyleBackColor = true;
            this.Btnvalidar.Click += new System.EventHandler(this.Btnvalidar_Click);
            // 
            // LblMostrarResultado
            // 
            this.LblMostrarResultado.AutoSize = true;
            this.LblMostrarResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMostrarResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblMostrarResultado.Location = new System.Drawing.Point(312, 312);
            this.LblMostrarResultado.Name = "LblMostrarResultado";
            this.LblMostrarResultado.Size = new System.Drawing.Size(2, 18);
            this.LblMostrarResultado.TabIndex = 7;
            // 
            // ErrorMensaje
            // 
            this.ErrorMensaje.ContainerControl = this;
            // 
            // Txtcontraseña
            // 
            this.Txtcontraseña.Location = new System.Drawing.Point(189, 179);
            this.Txtcontraseña.Name = "Txtcontraseña";
            this.Txtcontraseña.PasswordChar = '*';
            this.Txtcontraseña.Size = new System.Drawing.Size(271, 20);
            this.Txtcontraseña.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña";
            // 
            // Frmvalidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 382);
            this.Controls.Add(this.Txtcontraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblMostrarResultado);
            this.Controls.Add(this.Btnvalidar);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.Txtcodigo);
            this.Controls.Add(this.Txtnombre);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frmvalidaciones";
            this.Text = "Validaciones";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMensaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox Txtnombre;
        private System.Windows.Forms.TextBox Txtcodigo;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Button Btnvalidar;
        private System.Windows.Forms.Label LblMostrarResultado;
        private System.Windows.Forms.ErrorProvider ErrorMensaje;
        private System.Windows.Forms.TextBox Txtcontraseña;
        private System.Windows.Forms.Label label4;
    }
}

