using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObdulioYSuTienda
{
    public class Factoria01 : IFactoria
    {
        public IValidable Validador = new Validador01();
        public IListable Lista = new Tienda();
        public IVendible Vendible(TipoOrdenador tipo, int precio, int tiempoGarantia)
        {
            if (precio == 0 || tiempoGarantia == 0)
            {
                switch (tipo)
                {
                    case TipoOrdenador.Lentorro:
                        var OrdL = new OrdenadorLentorro();
                        Lista.Add(OrdL);
                        return OrdL;

                    case TipoOrdenador.Normal:
                        var OrdN = new OrdenadorNormal();
                        Lista.Add(OrdN);
                        return OrdN;

                    case TipoOrdenador.Gamer:
                        var OrdG = new OrdenadorGamer();
                        Lista.Add(OrdG);
                        return OrdG;

                    default: return null;

                }
            }else if (Validador.IsValid(precio, tiempoGarantia))
            { 
                switch (tipo)
                {
                    case TipoOrdenador.Lentorro: 
                        var OrdL = new OrdenadorLentorro() { Precio = precio, TiempoGarantia = tiempoGarantia };
                        Lista.Add(OrdL);
                        return OrdL;
                        

                    case TipoOrdenador.Normal: 
                        var OrdN =new OrdenadorNormal() { Precio = precio, TiempoGarantia = tiempoGarantia };
                        Lista.Add(OrdN);
                        return OrdN;

                    case TipoOrdenador.Gamer: 
                        var OrdG =new OrdenadorGamer() { Precio = precio, TiempoGarantia = tiempoGarantia };
                        Lista.Add(OrdG);
                        return OrdG;

                    default: return null;

                }
            } else
            {
                return null;
            }
        }
        public void Mostrable()
        {
             Lista.Muestra();
        }
    }
}
