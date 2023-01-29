using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class Camion : Transporte
    {
        public int CantidadRuedas { get; set; }
        public int CapacidadTransporte { get; set; }

        public Remolque Remolque { get; set; }

        public Camion(string modelo, string marca, int cantidadRuedas, int capacidadTransporte, Remolque remolque) : base(modelo, marca)
        {
            CantidadRuedas = cantidadRuedas;
            CapacidadTransporte = capacidadTransporte;
            Remolque = remolque;
        }

        public Camion() { }

        public void QuitarRemolque()
        {
            Remolque = null;
        }

        public override string Acelerar()
        {
            return "El camión acelera a 10km/h";
        }

        public override string Frenar()
        {
            return "El camión frena a 10km/h";
        }

        public override string Imprimir()
        {
            return "El modelo del camión es " + this.Modelo + ".\n" +
                "La marca es " + this.Marca + ".\n" + 
                "La cantidad de ruedas es " + this.CantidadRuedas + ".\n" +
                "La capacidad de transporte es " + this.CapacidadTransporte + " kg.\n" +
                this.Remolque.ToString();
        }

    }
}
