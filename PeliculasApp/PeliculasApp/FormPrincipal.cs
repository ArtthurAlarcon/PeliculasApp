using System;
using System.Windows.Forms;
using PeliculasApp.Procedimientos;
using PeliculasApp.Clases;


namespace PeliculasApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            CambiarUsuario();
        }

        private void CambiarUsuario()
        {
            //MessageBox.Show("Prueba");
            //LblUsuario.Text = TxtUsuario.Text;

            Pelicula peli = new Pelicula();
            LblUsuario.Text = TxtNombrePelicula.Text;
            peli.NombrePelicula = TxtNombrePelicula.Text;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            RegistrarPelicula();
        }

        public void RegistrarPelicula()
        {
            Pelicula peli = new Pelicula
            {
                NombrePelicula = TxtNombrePelicula.Text,
                Año = TxtAño.Text,
                Genero = TxtGenero.Text
            };

            SPHelper.InsertarPelicula(peli);

            MessageBox.Show("Pelicula registrada");

        }

        private void LblMensaje_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
