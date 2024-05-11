using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObdulioYSuTienda
{
    internal class Validador01 : IValidable
    {
        public bool IsValid(int Precio, int TiempoGarantia)
        {
            return (Precio >0 && TiempoGarantia >0);
        }
    }
}
