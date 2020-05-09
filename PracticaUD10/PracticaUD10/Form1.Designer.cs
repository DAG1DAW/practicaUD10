namespace PracticaUD10
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
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tApellidos = new System.Windows.Forms.TextBox();
            this.tTelefono = new System.Windows.Forms.TextBox();
            this.tListaSocios = new System.Windows.Forms.TextBox();
            this.lListaSocios = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lApellidos = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(103, 53);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(127, 20);
            this.tNombre.TabIndex = 0;
            // 
            // tApellidos
            // 
            this.tApellidos.Location = new System.Drawing.Point(331, 53);
            this.tApellidos.Name = "tApellidos";
            this.tApellidos.Size = new System.Drawing.Size(127, 20);
            this.tApellidos.TabIndex = 1;
            // 
            // tTelefono
            // 
            this.tTelefono.Location = new System.Drawing.Point(590, 53);
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(127, 20);
            this.tTelefono.TabIndex = 2;
            // 
            // tListaSocios
            // 
            this.tListaSocios.Location = new System.Drawing.Point(69, 185);
            this.tListaSocios.Multiline = true;
            this.tListaSocios.Name = "tListaSocios";
            this.tListaSocios.ReadOnly = true;
            this.tListaSocios.Size = new System.Drawing.Size(666, 222);
            this.tListaSocios.TabIndex = 3;
            // 
            // lListaSocios
            // 
            this.lListaSocios.AutoSize = true;
            this.lListaSocios.Location = new System.Drawing.Point(66, 169);
            this.lListaSocios.Name = "lListaSocios";
            this.lListaSocios.Size = new System.Drawing.Size(79, 13);
            this.lListaSocios.TabIndex = 4;
            this.lListaSocios.Text = "Lista de Socios";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(53, 56);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 5;
            this.lNombre.Text = "Nombre";
            // 
            // lApellidos
            // 
            this.lApellidos.AutoSize = true;
            this.lApellidos.Location = new System.Drawing.Point(276, 56);
            this.lApellidos.Name = "lApellidos";
            this.lApellidos.Size = new System.Drawing.Size(49, 13);
            this.lApellidos.TabIndex = 6;
            this.lApellidos.Text = "Apellidos";
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Location = new System.Drawing.Point(535, 56);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(32, 13);
            this.lTelefono.TabIndex = 7;
            this.lTelefono.Text = "Movil";
            this.lTelefono.Click += new System.EventHandler(this.lTelefono_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lTelefono);
            this.Controls.Add(this.lApellidos);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.lListaSocios);
            this.Controls.Add(this.tListaSocios);
            this.Controls.Add(this.tTelefono);
            this.Controls.Add(this.tApellidos);
            this.Controls.Add(this.tNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tApellidos;
        private System.Windows.Forms.TextBox tTelefono;
        private System.Windows.Forms.TextBox tListaSocios;
        private System.Windows.Forms.Label lListaSocios;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lApellidos;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Button button1;
    }
}

