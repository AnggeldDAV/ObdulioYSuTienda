using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObdulioYSuTienda
{
    public interface IValidable
    {
        public bool IsValid(int Precio, int TiempoGarantia);
    }
}
