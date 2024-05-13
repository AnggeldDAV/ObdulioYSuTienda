using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ObdulioYSuTienda
{
    public class Menu : IMenuable
    {
        public IFactoria Factoria = new Factoria01();
        public void Listado()
        {
            
             Factoria.Mostrable();
        }
        public static void DameMensajes() {
            Console.WriteLine($"Pulsa 1 si quieres crear ordenador Lentorro \n" +
            $"Pulsa 2 si quieres crear ordenador Normal \n" +
            $"Pulsa 3 si quieres crear ordenador Gamer \n" +
            $"Pulsa 4 si quieres mostrar una lista de los ordenadores vendidos \n \n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Si pulsas otro numero se cerrara el programa");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void DameMenu()
        {
            
            DameMensajes();

            int numeroPulsado = Int32.Parse(Console.ReadLine()!);
            while (numeroPulsado == 1 | numeroPulsado == 2 | numeroPulsado == 3 || numeroPulsado == 4)
            {
                switch (numeroPulsado)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Creado ordenador Lentorro: {(Factoria.Vendible(TipoOrdenador.Lentorro, 0, 0))}\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Creado ordenador Normal: {Factoria.Vendible(TipoOrdenador.Normal, 0, 0)}\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Creado ordenador Gamer: {Factoria.Vendible(TipoOrdenador.Gamer, 0, 0)} \n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 4:
                        Console.Clear();
                        Listado();
                        Console.WriteLine($"\n");
                        break;
                }
                DameMensajes();
                numeroPulsado = Int32.Parse(Console.ReadLine()!);
            }
            Console.WriteLine($"\n\nSaliendo del programa");
        }
    }
}
