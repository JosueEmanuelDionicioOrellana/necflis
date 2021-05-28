using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace sistemaArea
{
    public partial class eliminarPelicula : Form
    {
        public eliminarPelicula()
        {
            InitializeComponent();
            leerData();
        }


        string conString = "server= 127.0.0.1; port=3306;username=root;"; //conexion
        int id;

        //------------------boton cancelar----------------
        private void cancelarPelicula_Click(object sender, EventArgs e) 
        {
            this.Close();
            leerData();
        }

        private void leerData()// leer los datos en la tabla 
        {
            string consulta = "select * from proyecto.peliculas";
            MySqlConnection conexion = new MySqlConnection(conString);//establecer conexion
            MySqlCommand command = new MySqlCommand(consulta, conexion);//consultar datos

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

        //----------------------boton eliminar -----------------

        private void eliminarPeliculas_Click(object sender, EventArgs e)
        {
            string delete = "delete from proyecto.peliculas " +
                "where id = " + id + ";";
            try
            {

                MySqlConnection conexxion = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(delete, conexxion);
                conexxion.Open();
                command.ExecuteNonQuery();

                leerData();
                MessageBox.Show("Eliminado");
                conexxion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar:" + ex.Message);
            }
        }

        //----------------funcion para obtener los datos de la lista seleccionada-------------------
        private void tablaPeliculas_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
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
