using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDA_Cola
{
    class claseCola
    {
        static void Main(string[] args)
        {
            metodoCola colita = new metodoCola();

            int num;

            do

            {
                Console.WriteLine("Menu de Cola");
                    Console.WriteLine("1. Encolar valor, Enqueue");
                        Console.WriteLine("2. Desencolar valor, Dequeue");
                            Console.WriteLine("3. Primer valor de la Cola");
                                Console.WriteLine("4. Imprimir Cola");
                                    Console.WriteLine("5. Salir de Cola");

                Console.WriteLine();

                Console.Write("Escoja una opcion: ");
                num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch (num)
                {
                    case 1:
                        colita.enqueue();
                        break;
                    case 2:
                        colita.dequeue();
                        break;
                    case 3:
                        colita.peek();
                        break;
                    case 4:
                        colita.imprimirCola();
                        break;
                    case 5:
                        Console.WriteLine("Fin del programa");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida" + "\n");
                        break;
                }

            } while (num != 5);
        }
    }
}
