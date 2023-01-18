using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Data
{
    public class DBLineaAereaEFContext : DbContext 
    {
        public DBLineaAereaEFContext() : base("KeyDB") { }

        public DbSet<LineaAerea> LineaAereas { get; set; }
        public DbSet<Avion> Aviones { get; set; }

    }
}
