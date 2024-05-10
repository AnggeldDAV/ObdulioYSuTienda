using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObdulioYSuTienda
{
    public class OrdenadorGamer : IVendible
    {
        public int Precio = 1000;
        public int TiempoGarantia = 4;
        public double TiempoMedio()
        {
            return Precio / TiempoGarantia;
        }
        public override string ToString()
        {
            return $"Ordenador Gamer de precio {Precio} y Tiempo de garantia {TiempoGarantia}. Tiempo medio {TiempoMedio()}";
        }
    }
}
