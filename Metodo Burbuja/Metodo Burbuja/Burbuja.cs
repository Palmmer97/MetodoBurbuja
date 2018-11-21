using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_Burbuja
{
    class Burbuja
    {
        public void metodo()
        {
            Console.WriteLine("Metodo Burbuja");
            Console.WriteLine("");
            Console.WriteLine("\nSolo ingrese 4 numeros");

            //Arreglo
            int[] A = new int[5];
            for (int i = 1; i < A.Length; i++)
            {

                Console.WriteLine("Ingrese los  numeros" + i);
                A[i] = int.Parse(Console.ReadLine());
            }
            // Impresion del Array A desordenado
            Console.WriteLine("Sus numeros sin ordenar son: ");
            for (int i = 1; i < A.Length; i++)
            {
                Console.WriteLine("[" + i + "]=" + A[i]);
            }
            //Inicio Metodo Burbuja
            int aux;
            for (int i = 1; i <= A.Length; i++)
            {
                for (int j = 1; j < A.Length - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        aux = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = aux;
                    }
                }
            }
            //Termino del Metodo Burbuja

            // Imprimimos El Array A ordenado 
            Console.WriteLine("\n Los numeros ordenados son: ");
            for (int i = 1; i < A.Length; i++)
            {
                Console.WriteLine("[" + i + "]=" + A[i]);
            }

            Console.ReadKey();
        }


    }
}
