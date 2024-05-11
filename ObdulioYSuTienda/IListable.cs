using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObdulioYSuTienda
{
    public interface IListable
    {
        public void Add(IVendible elemento);
        public int DameTotalImporte();
        public int Count();
        public int DameOrdenadorMasBarato();
        public int DameOrdenadorMasCaro();
        public int DameMediaPrecios();
        public void Muestra();


    }
}
