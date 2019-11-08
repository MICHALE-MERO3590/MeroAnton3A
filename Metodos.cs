using System;
using System.Collections.Generic;
using System.Text;

using System.Collections;

namespace TDA_PilaCola
{
    class Metodos
    {
        Queue cola = new Queue();
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
