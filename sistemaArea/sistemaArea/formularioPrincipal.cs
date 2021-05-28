using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaArea
{
    public partial class formularioPrincipal : Form
    {
        public formularioPrincipal()
        {
            InitializeComponent();
        }

        //----------------------creacion de formulario multiple-------------------
        private void abrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();

            }
            else
            {
                formulario.BringToFront();
            }
        }



        //------------------enlaces a los formularios--------------------
        private void botonInicio_Click(object sender, EventArgs e)
        {
            abrirFormulario<inicio>();//llamar el formulario seleccionado

        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirFormulario<usuariosLista>();
        }

        private void registroPeliculas_Click(object sender, EventArgs e)
        {
            abrirFormulario<registroPeliculas>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormulario<peliculasLista>();
        }

        // ---------------------Botones de acceso---------------------
        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
