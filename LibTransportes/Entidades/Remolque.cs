using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class Remolque
    {
        public int Largo { get; set; }
        public int CapacidadTransporte { get; set; }

        public Remolque(int largo, int capacidadTransporte)
        {
            Largo = largo;
            CapacidadTransporte = capacidadTransporte;
        }

        public Remolque() { }

        public override string ToString()
        {
            return "El largo del remolque es " + this.Largo + " metros.\n" +
                "La capacidad de transporte del remolque es " + this.CapacidadTransporte + " kg.";
        }

    }
}
