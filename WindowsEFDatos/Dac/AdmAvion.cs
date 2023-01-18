﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Data;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Dac
{
    public class AdmAvion
    {
        private static DBLineaAereaEFContext context = new DBLineaAereaEFContext();

        public static List<Avion> Listar()
        {
            return context.Aviones.ToList();
        }

        public static Avion TraerUno(int id)
        {
            return context.Aviones.Find(id);
        }

        public static int Insertar(Avion avion)
        {
            context.Aviones.Add(avion);

            return context.SaveChanges();
        }

        public static int Editar(Avion avion)
        {
            Avion avionOrigen = context.Aviones.Find(avion.IdAvion);

            avionOrigen.Capacidad = avion.Capacidad;
            avionOrigen.Denominacion = avion.Denominacion;

            return context.SaveChanges();
        }

        public static int Eliminar(int id)
        {
            Avion avionOrigen = context.Aviones.Find(id);

            if (avionOrigen != null)
            {
                context.Aviones.Remove(avionOrigen);

                return context.SaveChanges();
            }

            return 0;
        }



    }
}
