using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObdulioYSuTienda
{
    public class OrdenadorNormal : IVendible
    {
        public int Precio = 300;
        public int TiempoGarantia = 3;
        public double TiempoMedio()
        {
            return Precio / TiempoGarantia;
        }
        public override string ToString()
        {
            return $"Ordenador normal de precio {Precio} y Tiempo de garantia {TiempoGarantia}. Tiempo medio {TiempoMedio()}";
        }
    }
}
