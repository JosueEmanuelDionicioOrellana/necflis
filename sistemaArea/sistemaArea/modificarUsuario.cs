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
    public partial class modificarUsuario : Form
    {
        public modificarUsuario()
        {
            InitializeComponent();
            leerData();
        }


        string conString = "server= 127.0.0.1; port=3306;username=root;";//conexion
        int id;

        private void leerData()
        {

            string consulta = "select * from proyecto.usuarios";
            MySqlConnection conexion = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(consulta, conexion);

            try
            {
                conexion.Open();
                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = command;
                DataTable data = new DataTable();
                adaptar.Fill(data);
                tablaUsuarios.DataSource = data;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer data" + ex.Message);
            }
        }


        private void limpiar()
        {
            nombreUsuario.Clear();
            apellidoUsuario.Clear();
            correoUsuario.Clear();
            contraseñaUsuario.Clear();
            ConfirmacionContraseña.Clear();
            TelefonoUsuario.Clear();
        }

        //------------------boton cerrar------------
        private void cancelarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //---------------------boton modificar--------------------
        private void modificarUsuarios_Click(object sender, EventArgs e)
        {
            string nombre = nombreUsuario.Text;//obtener datos de los textbox
            string apellido = apellidoUsuario.Text;
            string correo = correoUsuario.Text;
            string contraseña = contraseñaUsuario.Text;
            string confirmacion = ConfirmacionContraseña.Text;
            string telefono = TelefonoUsuario.Text;

            string update = "update proyecto.usuarios " +
                "set Nombre =  '" + nombre + "'," +
                "Apellido = '" + apellido + "'," +
                "Correo = '" + correo + "'," +
                "Contraseña = '" + contraseña + "'," +
                "Confirmacion = '" + confirmacion + "'," +
                "Telefono = '" + telefono + "'" +
                "where ID = " + id + ";";

            try
            {
                MySqlConnection conexxion = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(update, conexxion);
                conexxion.Open();
                command.ExecuteNonQuery();
                limpiar();
                leerData();
                MessageBox.Show("el perfil ha sido modificado");
                conexxion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar:" + ex.Message);
            }
        }

        //-----------------obtener datos de la casilla selecionada-----------
        private void tablaUsuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = tablaUsuarios.SelectedRows[0];
            id = int.Parse(row.Cells[0].Value.ToString());
            nombreUsuario.Text = row.Cells[1].Value.ToString();
            apellidoUsuario.Text = row.Cells[2].Value.ToString();
            correoUsuario.Text = row.Cells[3].Value.ToString();
            contraseñaUsuario.Text = row.Cells[4].Value.ToString();
            ConfirmacionContraseña.Text = row.Cells[5].Value.ToString();
            TelefonoUsuario.Text = row.Cells[6].Value.ToString();
        }

        //------------------------edicion de cuadros de texto---------------
        private void nombreUsuario_Enter(object sender, EventArgs e)
        {
            if (nombreUsuario.Text == "Nombre")
            {
                nombreUsuario.Text = "";
                nombreUsuario.ForeColor = Color.LightGray;
            }
        }

        private void nombreUsuario_Leave(object sender, EventArgs e)
        {
            if (nombreUsuario.Text == "")
            {
                nombreUsuario.Text = "Nombre";
                nombreUsuario.ForeColor = Color.DimGray;
            }
        }

        private void apellidoUsuario_Enter(object sender, EventArgs e)
        {
            if (apellidoUsuario.Text == "Apellido")
            {
                apellidoUsuario.Text = "";
                apellidoUsuario.ForeColor = Color.LightGray;
            }
        }

        private void apellidoUsuario_Leave(object sender, EventArgs e)
        {
            if (apellidoUsuario.Text == "")
            {
                apellidoUsuario.Text = "Apellido";
                apellidoUsuario.ForeColor = Color.DimGray;
            }
        }

        private void correoUsuario_Enter(object sender, EventArgs e)
        {
            if (correoUsuario.Text == "Correo")
            {
                correoUsuario.Text = "";
                correoUsuario.ForeColor = Color.LightGray;
            }
        }

        private void correoUsuario_Leave(object sender, EventArgs e)
        {
            if (correoUsuario.Text == "")
            {
                correoUsuario.Text = "Correo";
                correoUsuario.ForeColor = Color.DimGray;
            }
        }

        private void contraseñaUsuario_Enter(object sender, EventArgs e)
        {
            if (contraseñaUsuario.Text == "Contraseña")
            {
                contraseñaUsuario.Text = "";
                contraseñaUsuario.ForeColor = Color.LightGray;
            }
        }

        private void contraseñaUsuario_Leave(object sender, EventArgs e)
        {
            if (contraseñaUsuario.Text == "")
            {
                contraseñaUsuario.Text = "Contraseña";
                contraseñaUsuario.ForeColor = Color.DimGray;
            }
        }

        private void ConfirmacionContraseña_Enter(object sender, EventArgs e)
        {
            if (ConfirmacionContraseña.Text == "Confirmacion de Contraseña")
            {
                ConfirmacionContraseña.Text = "";
                ConfirmacionContraseña.ForeColor = Color.LightGray;
            }
        }

        private void ConfirmacionContraseña_Leave(object sender, EventArgs e)
        {
            if (ConfirmacionContraseña.Text == "")
            {
                ConfirmacionContraseña.Text = "Confirmacion de Contraseña";
                ConfirmacionContraseña.ForeColor = Color.DimGray;
            }
        }

        private void TelefonoUsuario_Enter(object sender, EventArgs e)
        {
            if (TelefonoUsuario.Text == "No. de Telefono")
            {
                TelefonoUsuario.Text = "";
                TelefonoUsuario.ForeColor = Color.LightGray;
            }
        }

        private void TelefonoUsuario_Leave(object sender, EventArgs e)
        {
            if (TelefonoUsuario.Text == "")
            {
                TelefonoUsuario.Text = "No. de Telefono";
                TelefonoUsuario.ForeColor = Color.DimGray;
            }
        }
    }
}
