using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObdulioYSuTienda
{
    public class Menu : IMenuable
    {
        public void DameMenu()
        {

            var Factoria = new Factoria01();

            Console.WriteLine($" Pulsa 1 si quieres crear ordenador Lentorro");
            Console.WriteLine($" Pulsa 2 si quieres crear ordenador Normal");
            Console.WriteLine($" Pulsa 3 si quieres crear ordenador Gamer");

            int numeroPulsado = Int32.Parse(Console.ReadLine()!);
            while (numeroPulsado = 1 | numeroPulsado = 2 | numeroPulsado = 3) { 
                switch (numeroPulsado)
                {
                    case 1:
                        Console.WriteLine($"Creado ordenador Lentorro: {Factoria.Vendible(TipoOrdenador.Lentorro)}");
                        break;
                    case 2:
                        Console.WriteLine($"Creado ordenador Normal: {Factoria.Vendible(TipoOrdenador.Normal)}");
                        break;
                    case 3:
                        Console.WriteLine($"Creado ordenador Gamer: {Factoria.Vendible(TipoOrdenador.Gamer)}");
                        break;
                }
            }
            Console.WriteLine("Saliendo del programa");
        }
    }
}
