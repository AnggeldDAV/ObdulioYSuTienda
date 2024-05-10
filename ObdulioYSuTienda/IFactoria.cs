using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObdulioYSuTienda
{
    public interface IFactoria
    {
       public IVendible Vendible(TipoOrdenador tipo);
    }
}
