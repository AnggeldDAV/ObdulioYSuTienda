using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ObdulioYSuTienda
{
    public class Tienda : IListable
    {
        public int TotalImporte;
        public List<IVendible> Ventas = new();
        public void Add(IVendible elemento) {
            this.Ventas.Add(elemento);
        }
        public int DameTotalImporte()
        {
            TotalImporte = 0;
            Parallel.ForEach(Ventas, number =>
            {
                TotalImporte += number.Precio;
            });
            return TotalImporte;
        }
        public int Count()
        {
            return this.Ventas.Count();
        }
        public int DameOrdenadorMasBarato()
        {
            int Temp = 100000000;
            Parallel.ForEach(Ventas, number =>
            {
                if (number.Precio < Temp)
                {
                    Temp = number.Precio;
                }
            });
            return Temp;

        }        
        public int DameOrdenadorMasCaro()
        {
            int Temp = 0;
            Parallel.ForEach(Ventas, number =>
            {
                if (number.Precio > Temp)
                {
                    Temp = number.Precio;
                }
            });
            return Temp;

        }
        public int DameMediaPrecios()
        {
            return (this.DameTotalImporte()) / this.Count();
        }
        public int DameOrdenadoresPrecioSuperior()
        {
            int Temp = 0;
            Parallel.ForEach(Ventas, number =>
            {
                if (number.Precio > 125)
                {
                    Temp++;
                }
            });
            return Temp;
        }
        public void Muestra()
        {
            Console.WriteLine($"Lista:");
            foreach (IVendible obj in Ventas) {
                Console.WriteLine(obj);
            }
        }
    }
}
