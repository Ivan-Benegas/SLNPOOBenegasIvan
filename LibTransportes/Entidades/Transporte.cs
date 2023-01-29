using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public abstract class Transporte
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }

        public Transporte(string modelo, string marca)
        {
            Modelo = modelo;
            Marca = marca;
        }

        public Transporte() { }

        public abstract string Acelerar();

        public abstract string Frenar();

        public virtual string Imprimir()
        {
            return null;
        }

    }
}
