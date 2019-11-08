using System;
using System.Collections.Generic;
using System.Text;

using System.Collections;

namespace TDA_Pila
{
    class metodoPila
    {
        Stack pila = new Stack();
        int dat;

        public int push()  //Ingresar elemento a nuestra pila
        {
            Console.Write("Inserte un valor, Apilando: ");
            dat = Convert.ToInt32(Console.ReadLine());
            pila.Push(dat);
            
            Console.WriteLine("");

            return dat;
        }

        public int pop() //Eliminar elementos de nuestra pila
        {
            if (pila.Count == 0)
            {
                //throw new Exception("La pila no tiene valor actual" + "\n");
                Console.WriteLine("La pila no tiene valor actual" + "\n");
            }
            else

            Console.Write("Eliminando valor, Desapilando: " + pila.Pop() + "\n");

            return dat;
        }

        public void peek() //Ultimo valor de nuestra pila
        {
            if (pila.Count == 0)
            {
                Console.WriteLine("Pila sin valores actules" + "\n");
            }
            else
            Console.Write("La cima o ultimo valor de nuestra pila es: " + pila.Peek() + "\n");
        }


        public void imprimirPila()
        {
            if (pila.Count == 0)
            {
                Console.WriteLine("Pila sin valores actules" + "\n");
            }
            else
            {
                foreach (int dat in pila)
                    Console.WriteLine("Valores de mi pila: " + dat);
            }
        }

    }
}
