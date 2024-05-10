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
        public int Precio = 100;
        public int TiempoGarantia = 2;
        public double TiempoMedio()
        {
            return Precio / TiempoGarantia;
        }
        public override string ToString()
        {
            return $"Ordenador lentorro de precio {Precio} y Tiempo de garantia {TiempoGarantia}. Tiempo medio {TiempoMedio()}";
        }
    }
}
