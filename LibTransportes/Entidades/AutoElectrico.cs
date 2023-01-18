using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class AutoElectrico : Transporte
    {
        public int CantidadPuertas { get; set; }

        public int BateriaCapacidad { get; set; }

        public AutoElectrico(string modelo, string marca, int cantidadPuertas, int bateriaCapacidad) : base(modelo, marca)
        {
            CantidadPuertas = cantidadPuertas;
            BateriaCapacidad = bateriaCapacidad;
        }

        public AutoElectrico() { }

        public override string Acelerar()
        {
            return "El auto eléctrico acelera a 20km/h";
        }

        public override string Frenar()
        {
            return "El auto eléctrico frena a 20km/h";
        }

        public override string ToString()
        {
            return "El modelo del auto eléctrico es " + this.Modelo + ".\n" +
                "La marca es " + this.Marca + ".\n" +
                "La cantidad de puertas es " + this.CantidadPuertas + ".\n" +
                "La capacidad de la batería es " + this.BateriaCapacidad + ".";
        }

    }
}
