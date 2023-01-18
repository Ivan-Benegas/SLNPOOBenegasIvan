using LibTransportes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionVehiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AutoElectrico autoElectrico = new AutoElectrico("Fiesta", "Ford", 4, 10000);

            Camion camion = new Camion();

            camion.Modelo = "Z10";
            camion.Marca = "Iveco";
            camion.CantidadRuedas = 10;
            camion.CapacidadTransporte = 2000;
            camion.Remolque = new Remolque(10, 1000);

            lblAutoElectrico.Text = autoElectrico.ToString();

            lblCamion.Text = camion.ToString();

        }
    }
}
