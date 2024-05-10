using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObdulioYSuTienda
{
    public class Factoria01 : IFactoria
    {
        public IVendible Vendible(TipoOrdenador tipo)
        {
            switch (tipo) {
                case TipoOrdenador.Lentorro:return new OrdenadorLentorro();
                    
                case TipoOrdenador.Normal: return new OrdenadorNormal();
                    
                case TipoOrdenador.Gamer: return new OrdenadorGamer();
                    
                default: return null;

            }
        }
    }
}
