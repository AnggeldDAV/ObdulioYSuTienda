using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObdulioYSuTienda
{
    public class OrdenadorGamer : IVendible
    {
        public int Precio { get; set; }
        public int TiempoGarantia { get; set; }

        public OrdenadorGamer(int precio = 1000, int tiempoGarantia = 4)
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
