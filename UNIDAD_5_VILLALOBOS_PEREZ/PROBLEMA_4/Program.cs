using System;

namespace PROBLEMA_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //En base a la jerarquía de el abecedario ordene 
            //    la siguiente frase: " Lorem ipsum dolor sit amet,
            //    consectetur adipiscing elit. Fusce varius, augue vitae 
            //    tincidunt viverra, sem felis bibendum nisl, id cursus diam 
            //    leo sit amet urna. Duis ac massa est." Nota: Comprendiendo 
            //    que la primera letra del abecedario es 1, A = 1, B = 2, C = 3..etc.
            int valor = 0;   //INICIO EL ARREGLO 
            int[] arreglo = new int[] {12,16,19,5,13,9,17,20,23,13,4,16,12,16,19,20,9,21,1,13,5,21};
            Console.Write("\nINICIO : L  O  R  E  M  I  P  S  U  M  D  O  L  O  R  S  I  T  A  M  E  T ");
            Console.Write("\nINICIO : 12 16 19 5  13 9  17 20 23 13 4  16 12 16 19 20 9  21 1  13 5  21 ");
            //
            for (int contador = 1; contador < arreglo.Length; contador++)
            // EL CICLO  SE EJECUTARA A LO LARGO DE LOS ELEMENTOS DEL ARREGLO
            {
                for (int contar = 0; contar < (arreglo.Length - 1); contar++)
                { // AQUI SE INTERCAMBIA LOS NUMERO DEL ARREGLO 
                    if (arreglo[contador] < arreglo[contar])
                    { // SE ALMACENAN EN UNA VARIABLE TEMPORAL 
                        valor = arreglo[contador];
                        arreglo[contador] = arreglo[contar];
                        arreglo[contar] = valor;
                    }   //UNA VEZ QUE SE ALMACENAN SE AÑADEN AL ARREGLO
                }
            }
            // IMPRIME EL ERREGLO FINAL 
            Console.Write("\nORDEN  :");
            for (int cont = 0; cont < 15; cont++)
                Console.Write("  " + arreglo[cont]);
            Console.ReadKey();
        }
    }
}
