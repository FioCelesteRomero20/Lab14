using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal class Pantalla
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int opcion = Pantallas.pantallaPrincipal();
                do
                {
                    Console.Clear();
                    switch (opcion)
                    {
                        case 1:
                            opcion = Pantallas.encuestaCovid();
                            break;
                        case 2:
                            opcion = Pantallas.DatosDeLaEncuesta();
                            break;
                        case 3:
                            opcion = Pantallas.ResultadosDeLaEncuesta();
                            break;
                        case 4:
                            opcion = Pantallas.BuscarPersonasPorEdad();
                            break;
                        case 0:
                        default:
                            opcion = Pantallas.pantallaPrincipal();
                            break;
                    }
                } while (opcion != 5);
                Console.ReadLine();
            }
        }
    }
}
