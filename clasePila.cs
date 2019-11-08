using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDA_Pila

{
    class clasePila
    {
        static void Main(String[] args)
        {
            metodoPila pilita = new metodoPila();

            int num;

            do

            {
                Console.WriteLine("Menu de Pila");
                    Console.WriteLine("1. Apilar valor, Push");
                        Console.WriteLine("2. Eliminar valor, Pop");
                            Console.WriteLine("3. Ultimo valor de la pila");
                                Console.WriteLine("4. Imprimir Pila");
                                    Console.WriteLine("5. Salir de Pila");

                Console.WriteLine();

                Console.Write("Escoja una opcion: ");
                num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch (num)
                {
                    case 1:
                        pilita.push();
                        break;
                    case 2:
                        pilita.pop();
                        break;
                    case 3:
                        pilita.peek();
                        break;
                    case 4:
                        pilita.imprimirPila();
                        break;
                    case 5:
                        Console.WriteLine("Fin del programa");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida" + "\n");
                        break;
                }

            } while (num != 5);

            Console.ReadKey();
        }
    }
}