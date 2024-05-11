using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ObdulioYSuTienda
{
    public class OrdenadorLentorro : IVendible
    {
        public int Precio {get;set;}
        public int TiempoGarantia { get; set; }

        public OrdenadorLentorro(int precio = 100, int tiempoGarantia = 2)
        {
            this.Precio = precio;
            this.TiempoGarantia = tiempoGarantia;
        }

        public double TiempoMedio()
        {
            return Precio / TiempoGarantia;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}, {this.Precio}, {this.TiempoGarantia}, {this.TiempoMedio()}";
        }
    }
}
