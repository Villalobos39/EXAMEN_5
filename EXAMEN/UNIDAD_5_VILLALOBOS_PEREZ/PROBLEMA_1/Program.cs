using System;

namespace PROBLEMA_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Construya una aplicación que genere un 
            //    ordenamiento de n números y que solo se puedan introducir 
            //    0,1, 2 de cualquier forma, use el método 
            //    bubble sort para hacer este problema.

            int valor = 0;   //INICIO EL ARREGLO 
            int[] burbuja = new int[] { 1,0,2,1,0,0,2,2,1,1,1,0,2,0,2};
            Console.Write("\nINICIO BURBUJA :  1,0,2,1,0,0,2,2,1,1,1,0,2,0,2 \n ");
            for (int contador = 1; contador < burbuja.Length; contador++)
            // EL CICLO  SE EJECUTARA A LO LARGO DE LOS ELEMENTOS DEL ARREGLO
            {
                for (int contar = 0; contar < (burbuja.Length - 1); contar++)
                { // AQUI SE INTERCAMBIA LOS NUMERO DEL ARREGLO 
                    if (burbuja[contador] < burbuja[contar])
                    { // SE ALMACENAN EN UNA VARIABLE TEMPORAL 
                        valor = burbuja[contador];
                        burbuja[contador] = burbuja[contar];
                        burbuja[contar] = valor;
                    }   //UNA VEZ QUE SE ALMACENAN SE AÑADEN AL ARREGLO
                }
            }
            // IMPRIME EL ERREGLO FINAL 
            Console.Write("\nFINAL BURBUJA : ");
            for (int cont = 0; cont < 15; cont++)
                Console.Write("  " + burbuja[cont]);
            Console.ReadKey();
        }
    }
}

