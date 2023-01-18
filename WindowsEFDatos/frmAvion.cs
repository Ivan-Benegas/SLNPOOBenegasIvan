using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Dac;
using WindowsEFDatos.Models;

namespace WindowsEFDatos
{
    public partial class frmAvion : Form
    {
        public frmAvion()
        {
            InitializeComponent();
        }

        private void frmAvion_Load(object sender, EventArgs e)
        {
            MostrarTodosAviones();
        }

        private void MostrarTodosAviones()
        {
            gridAvion.DataSource = AdmAvion.Listar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion() { Capacidad = Convert.ToInt32(txtCapacidad.Text), Denominacion = txtDenominacion.Text };

            int filasAfectadas = AdmAvion.Insertar(avion);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Insertar ok.");

                MostrarTodosAviones();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion() { IdAvion = Convert.ToInt32(txtId.Text), Capacidad = Convert.ToInt32(txtCapacidad.Text), Denominacion = txtDenominacion.Text };

            int filasAfectadas = AdmAvion.Editar(avion);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Editar ok.");

                MostrarTodosAviones();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            int filasAfectadas = AdmAvion.Eliminar(id);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Eliminar ok.");

                MostrarTodosAviones();
            }
        }

        private void btnBuscarPorId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            Avion avion = AdmAvion.TraerUno(id);

            MessageBox.Show("El id del avión es " + avion.IdAvion + ".\n" +
                            "La capacidad es de " + avion.Capacidad + ".\n" +
                            "La denominación es " + avion.Denominacion + ".");
        }

    }
}
