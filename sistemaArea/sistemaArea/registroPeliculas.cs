using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistemaArea
{
    public partial class registroPeliculas : Form
    {
        public registroPeliculas()
        {
            InitializeComponent();
        }

        //----------------------------Botones------------------------


        private void cancelarPelicula_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarPelicula_Click(object sender, EventArgs e)
        {
            if (nombrePeliculas.Text != "Nombre") { errorNombre.Visible = false; }
            else errorMensajeNombre("Ingresar Nombre");

            if (tipoPeliculas.Text != "Tipo") { errorTipo.Visible = false; }
            else errorMensajeTipo("Ingresar Tipo");

            if (generoPeliculas.Text != "Genero") { errorGenero.Visible = false; }
            else errorMensajeGenero("Ingresar Genero");

            if (sinopsisPeliculas.Text != "Sinopsis") { errorSinopsis.Visible = false; }
            else errorMensajeSinopsis("Ingresar Sinopsis");


            if(nombrePeliculas.Text != "Nombre" && tipoPeliculas.Text != "Tipo" && generoPeliculas.Text != "Genero" && sinopsisPeliculas.Text != "Sinopsis")
            {
                string conString = "server= 127.0.0.1; port=3306;username=root;";

                string nombre = nombrePeliculas.Text;
                string tipo = tipoPeliculas.Text;
                string genero = generoPeliculas.Text;
                string sinopsis = sinopsisPeliculas.Text;

                string insert = "insert into proyecto.peliculas(Nombre, Tipo, Genero, Sinopsis)" +
                    "VALUES('" + nombre + "','" + tipo + "','" + genero + "','" + sinopsis + "')";

                try
                {
                    MySqlConnection conexxion = new MySqlConnection(conString);
                    MySqlCommand command = new MySqlCommand(insert, conexxion);
                    conexxion.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("guardado");
                    conexxion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar:" + ex.Message);
                }
                




                this.Close();


            }
        }

        //-------------------------Diseño de los cuadros de texto-----------
        private void nombrePeliculas_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombrePeliculas_Enter(object sender, EventArgs e)
        {
            if (nombrePeliculas.Text == "Nombre")
            {
                nombrePeliculas.Text = "";
                nombrePeliculas.ForeColor = Color.LightGray;
            }
        }

        private void nombrePeliculas_Leave(object sender, EventArgs e)
        {
            if(nombrePeliculas.Text == "")
            {
                nombrePeliculas.Text = "Nombre";
                nombrePeliculas.ForeColor = Color.DimGray;
            }
        }

        private void tipoPeliculas_Enter(object sender, EventArgs e)
        {
            if (tipoPeliculas.Text == "Tipo")
            {
                tipoPeliculas.Text = "";
                tipoPeliculas.ForeColor = Color.LightGray;
            }
        }

        private void tipoPeliculas_Leave(object sender, EventArgs e)
        {
            if (tipoPeliculas.Text == "")
            {
                tipoPeliculas.Text = "Tipo";
                tipoPeliculas.ForeColor = Color.DimGray;
            }
        }

        private void generoPeliculas_Enter(object sender, EventArgs e)
        {
            if (generoPeliculas.Text == "Genero")
            {
                generoPeliculas.Text = "";
                generoPeliculas.ForeColor = Color.LightGray;
            }
        }

        private void generoPeliculas_Leave(object sender, EventArgs e)
        {
            if (generoPeliculas.Text == "")
            {
                generoPeliculas.Text = "Genero";
                generoPeliculas.ForeColor = Color.DimGray;
            }
        }

        private void sinopsisPeliculas_Enter(object sender, EventArgs e)
        {
            if (sinopsisPeliculas.Text == "Sinopsis")
            {
                sinopsisPeliculas.Text = "";
                sinopsisPeliculas.ForeColor = Color.LightGray;
            }
        }





        //-------------------------Errores controlados-------------------
        private void errorMensajeNombre(string mensaje)
        {
            errorNombre.Text = mensaje;
            errorNombre.Visible = true;
        }

        private void errorMensajeTipo(string mensaje)
        {
            errorTipo.Text = mensaje;
            errorTipo.Visible = true;
        }
        private void errorMensajeGenero(string mensaje)
        {
            errorGenero.Text = mensaje;
            errorGenero.Visible = true;
        }
        private void errorMensajeSinopsis(string mensaje)
        {
            errorSinopsis.Text = mensaje;
            errorSinopsis.Visible = true;
        }

        private void sinopsisPeliculas_Leave(object sender, EventArgs e)
        {
            if (generoPeliculas.Text == "")
            {
                generoPeliculas.Text = "Sinopsis";
                generoPeliculas.ForeColor = Color.DimGray;
            }
        }
    }
}
