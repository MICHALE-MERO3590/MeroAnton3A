using System;

namespace TDA_PilaCola
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos pilita = new Metodos();
            Metodos colita = new Metodos();

            int uno;
            int dos = 0;
            int tres = 0;

            do
            {
                Console.WriteLine("1. TDA PILA");
                    Console.WriteLine("2. TDA COLA");
                        Console.WriteLine("3. SALIR");
                
                Console.WriteLine();

                Console.Write("Escoja una opcion: ");
                uno = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch (uno)
                {
                    case 1:
                        Console.WriteLine("Ejecucion de una Pila");

                        do
                        {
                            Console.WriteLine("Menu de Pila"); Console.WriteLine("1. Apilar valor, Push");
                            Console.WriteLine("2. Eliminar valor, Pop"); Console.WriteLine("3. Imprimir de Pila");
                            Console.WriteLine("4. Salir de Pila");Console.WriteLine();

                            Console.Write("Escoja una opcion: ");
                            dos = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine();

                            switch (dos)
                            {
                            case 1:  pilita.push(); break;
                                case 2: pilita.pop(); break;
                                    case 3:  pilita.imprimirPila(); break;
                                        case 4: Console.WriteLine("Fin del programa"); break;
                                            default: Console.WriteLine("Opcion no valida" + "\n"); break;
                        }
                        } while (dos != 4);
                        break;

                    case 2:
                        Console.WriteLine("Ejecucion de una Cola");
                        do
                        {
                            Console.WriteLine("Menu de Pila"); Console.WriteLine("1. Encolar valor, Enqueue");
                            Console.WriteLine("2. Desencolando valor, Dequeue"); Console.WriteLine("3. Imprimir Cola");
                            Console.WriteLine("4. Fin del programa"); Console.WriteLine();

                            Console.Write("Escoja una opcion: ");
                            tres = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine();

                            switch (tres)
                            {
                                case 1: colita.enqueue(); break;
                                    case 2: colita.dequeue(); break;
                                        case 3: colita.imprimirCola(); break;
                                            case 4: Console.WriteLine("Fin del programa"); break;
                                                default: Console.WriteLine("Opcion no valida" + "\n"); break;
                            }
                        } while (tres != 4);
                        break;

                    case 3:
                        Console.WriteLine("Fin del programa");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida" + "\n");
                        break;
                } 
            } while (uno != 3);
            Console.ReadKey();
        } 
    }
}
