using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

using System.Collections;

namespace TDA_Cola
{
    class metodoCola
    {
        Queue cola = new Queue();
        int dat;
        public int enqueue()  //Ingresar elemento a nuestra cola
        {
            Console.Write("Inserte un valor, Encolando: ");
            dat = Convert.ToInt32(Console.ReadLine());
            cola.Enqueue(dat);

            Console.WriteLine("");

            return dat;
        }

        public int dequeue() //Eliminar elementos de nuestra cola
        {
            if (cola.Count == 0)
            {
                //throw new Exception("La cola no tiene valor actual" + "\n");
                Console.WriteLine("La cola no tiene valor actual" + "\n");
            }
            else

                Console.Write("Eliminando valor, Desencolando: " + cola.Dequeue() + "\n");

            return dat;
        }

        public void peek() //Ultimo valor de nuestra pila
        {
            if (cola.Count == 0)
            {
                Console.WriteLine("Cola sin valores actules" + "\n");
            }
            else
                Console.Write("La cabecera o primer valor de nuestra cola es: " + cola.Peek() + "\n");
        }


        public void imprimirCola()
        {
            if (cola.Count == 0)
            {
                Console.WriteLine("Cola sin valores actules" + "\n");
            }
            else
            {
                foreach (int dat in cola)
                    Console.WriteLine("Valores de mi cola: " + dat);
            }
        }

    }
}
