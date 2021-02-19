
namespace PeliculasApp
{
    partial class FormPrincipal
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
            this.TxtNombrePelicula = new System.Windows.Forms.TextBox();
            this.LblNombrePelicula = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblAnio = new System.Windows.Forms.Label();
            this.TxtAño = new System.Windows.Forms.TextBox();
            this.LblGenero = new System.Windows.Forms.Label();
            this.TxtGenero = new System.Windows.Forms.TextBox();
            this.BtnCrearUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtNombrePelicula
            // 
            this.TxtNombrePelicula.Location = new System.Drawing.Point(422, 59);
            this.TxtNombrePelicula.Name = "TxtNombrePelicula";
            this.TxtNombrePelicula.Size = new System.Drawing.Size(100, 20);
            this.TxtNombrePelicula.TabIndex = 0;
            this.TxtNombrePelicula.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // LblNombrePelicula
            // 
            this.LblNombrePelicula.AutoSize = true;
            this.LblNombrePelicula.Location = new System.Drawing.Point(287, 61);
            this.LblNombrePelicula.Name = "LblNombrePelicula";
            this.LblNombrePelicula.Size = new System.Drawing.Size(109, 13);
            this.LblNombrePelicula.TabIndex = 1;
            this.LblNombrePelicula.Text = "Nombre de la pelicula";
            this.LblNombrePelicula.Click += new System.EventHandler(this.LblMensaje_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(721, 92);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(0, 13);
            this.LblUsuario.TabIndex = 3;
            // 
            // LblAnio
            // 
            this.LblAnio.AutoSize = true;
            this.LblAnio.Location = new System.Drawing.Point(287, 88);
            this.LblAnio.Name = "LblAnio";
            this.LblAnio.Size = new System.Drawing.Size(91, 13);
            this.LblAnio.TabIndex = 5;
            this.LblAnio.Text = "Año de la pelicula";
            this.LblAnio.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtAño
            // 
            this.TxtAño.Location = new System.Drawing.Point(422, 85);
            this.TxtAño.Name = "TxtAño";
            this.TxtAño.Size = new System.Drawing.Size(100, 20);
            this.TxtAño.TabIndex = 4;
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.Location = new System.Drawing.Point(287, 118);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(107, 13);
            this.LblGenero.TabIndex = 7;
            this.LblGenero.Text = "Genero de la pelicula";
            this.LblGenero.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtGenero
            // 
            this.TxtGenero.Location = new System.Drawing.Point(422, 115);
            this.TxtGenero.Name = "TxtGenero";
            this.TxtGenero.Size = new System.Drawing.Size(100, 20);
            this.TxtGenero.TabIndex = 6;
            // 
            // BtnCrearUsuario
            // 
            this.BtnCrearUsuario.Location = new System.Drawing.Point(354, 172);
            this.BtnCrearUsuario.Name = "BtnCrearUsuario";
            this.BtnCrearUsuario.Size = new System.Drawing.Size(136, 23);
            this.BtnCrearUsuario.TabIndex = 8;
            this.BtnCrearUsuario.Text = "Registrar pelicula";
            this.BtnCrearUsuario.UseVisualStyleBackColor = true;
            this.BtnCrearUsuario.Click += new System.EventHandler(this.BtnCrearUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "REGISTRAR PELICULA";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FormPrincipal
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCrearUsuario);
            this.Controls.Add(this.LblGenero);
            this.Controls.Add(this.TxtGenero);
            this.Controls.Add(this.LblAnio);
            this.Controls.Add(this.TxtAño);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblNombrePelicula);
            this.Controls.Add(this.TxtNombrePelicula);
            this.Name = "FormPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombrePelicula;
        private System.Windows.Forms.Label LblNombrePelicula;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblAnio;
        private System.Windows.Forms.TextBox TxtAño;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.TextBox TxtGenero;
        private System.Windows.Forms.Button BtnCrearUsuario;
        private System.Windows.Forms.Label label1;
    }
}

