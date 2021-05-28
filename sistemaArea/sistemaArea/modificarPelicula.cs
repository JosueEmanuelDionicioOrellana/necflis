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
    public partial class modificarPelicula : Form
    {
        public modificarPelicula()
        {
            InitializeComponent();
            leerData();
        }

        string conString = "server= 127.0.0.1; port=3306;username=root;"; //conexion
        int id;

        
        private void leerData() // leer los datos en la tabla 
        {

            string consulta = "select * from proyecto.peliculas";
            MySqlConnection conexion = new MySqlConnection(conString);//conexion a la base de datos
            MySqlCommand command = new MySqlCommand(consulta, conexion);//consultar datos de la base de datos

            try
            {
                conexion.Open();
                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = command;
                DataTable data = new DataTable();
                adaptar.Fill(data);
                tablaPeliculas.DataSource = data;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer data" + ex.Message);
            }
        }




        //------------------boton cancelar----------------
        private void cancelarPelicula_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-------------------limpiar casiñas----------------
        private void limpiar()
        {
            nombrePeliculas.Clear();
            tipoPeliculas.Clear();
            generoPeliculas.Clear();
            sinopsisPeliculas.Clear();
        }

        //-------------------boton registrar----------------
        private void registrarPelicula_Click(object sender, EventArgs e)
        {
            string nombre = nombrePeliculas.Text;//obtener datos
            string tipo = tipoPeliculas.Text;
            string genero = generoPeliculas.Text;
            string sinopsis = sinopsisPeliculas.Text;

            string update = "update proyecto.peliculas " +
                "set Nombre =  '" + nombre + "'," +
                "Tipo = '" + tipo + "'," +
                "Genero = '" + genero + "'," +
                "Sinopsis = '" + sinopsis + "'" +
                "where ID = " + id + ";";

            try
            {
                MySqlConnection conexxion = new MySqlConnection(conString);//establecer conexion
                MySqlCommand command = new MySqlCommand(update, conexxion);//agregar datos
                conexxion.Open();
                command.ExecuteNonQuery();
                limpiar();
                leerData();
                MessageBox.Show("la pelicula ha sido modificada");
                conexxion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar:" + ex.Message);
            }

        }


        //------------------------edicion de cuadros de texto---------------
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
            if (nombrePeliculas.Text == "")
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

        private void sinopsisPeliculas_Leave(object sender, EventArgs e)
        {
            if (generoPeliculas.Text == "")
            {
                generoPeliculas.Text = "Sinopsis";
                generoPeliculas.ForeColor = Color.DimGray;
            }
        }


        //----------------funcion para obtener los datos de la lista seleccionada-------------------
        private void tablaPeliculas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = tablaPeliculas.SelectedRows[0];
            id = int.Parse(row.Cells[0].Value.ToString());
            nombrePeliculas.Text = row.Cells[1].Value.ToString();
            tipoPeliculas.Text = row.Cells[2].Value.ToString();
            generoPeliculas.Text = row.Cells[3].Value.ToString();
            sinopsisPeliculas.Text = row.Cells[4].Value.ToString();
        }
    }
}
