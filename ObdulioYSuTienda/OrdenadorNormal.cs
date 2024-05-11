using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObdulioYSuTienda
{
    public class OrdenadorNormal : IVendible
    {
        public int Precio { get; set; }
        public int TiempoGarantia { get; set; }
        public OrdenadorNormal(int precio = 300, int tiempoGarantia= 3)
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
