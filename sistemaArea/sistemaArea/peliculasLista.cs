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
    public partial class peliculasLista : Form
    {
        public peliculasLista()
        {
            InitializeComponent();
            leerData();
        }

        string conString = "server= 127.0.0.1; port=3306;username=root;";//conexion
        private void leerData()//leer datos de la tabla
        {

            string consulta = "select * from proyecto.peliculas";
            MySqlConnection conexion = new MySqlConnection(conString);//conexion a la base de datos
            MySqlCommand command = new MySqlCommand(consulta, conexion);//consultar datos a la base

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


        //-------------------boton cerrar--------------
        private void cerrarListaPeliculas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-----------------Enlace de la pagina de eliminar-------------
        private void eliminarPelicula_Click(object sender, EventArgs e)
        {
            Form formulario = new eliminarPelicula();
            formulario.Show();
            this.Close();
        }

        //--------------------Enlace de la pagina a modificar------------
        private void modificarPelicula_Click(object sender, EventArgs e)
        {
            Form formulario = new modificarPelicula();
            formulario.Show();
            this.Close();
        }
    }
}
