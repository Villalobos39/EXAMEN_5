using System;
using System.Collections.Generic;
using System.Text;

namespace PROBLEMA_3
{
    class OrdenMm
    {
        //Con el método shellsort haga 
        //un algoritmo que le pida al usuario
        //n cantidad de numeros y permita
        //ordenarlos de mayor a menor.
        int num;
        int[] arreglo;
        //declaro variables
        public void Capturar()
        {
            //LE PIDO AL USUARIO QUE INGRESE EL NUMERO TOTAL DE ELEMENTO 
            Console.Write("\nNUMEROS : ");
            num = int.Parse(Console.ReadLine());
            arreglo = new int[num];
            for (int cont = 0; cont < num; cont++)
            {// CAPTURO LOS ELEMENTOS Y LOS INGRESO AL ARREGLO 
                Console.Write("NUMEROS : ");
                arreglo[cont] = int.Parse(Console.ReadLine());
            }// DESPEGO EL ORDEN NORMAL DE LOS NUMEROS 
            Console.Write("\n NUMEROS INGRESADOS : \n");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(" " + arreglo[i]);
            }
            Console.Write("\n");
        }

        public void Ordenacion()
        {// PARA EL ORDENAMIENTO DE SHELL SORT 
            int temp = 0, arreglo2 = arreglo.Length;
            int posicion = arreglo2 / 2;
            //DECLARO VARIABLES TEMPORALES QUE ALMACENAN LOS NUMEROS DEL ARREGLO 
            //Y LA POSICION DEL NUMERO 
            while (posicion >= 1)
            {
                posicion = posicion / 2;
                for (int i = 0; i < arreglo2 - posicion; i++)
                { // PARA QUE EL NUMERO SE ACOMO DE MAYOR A MENOR SE 
                    if (arreglo[i] < arreglo[i + posicion])
                    {//CONDICIONAN SI EL ARREGLO ES MENOR A EL ELEMENTO DE LA SIGUIENTE POSICION 
                        temp = arreglo[i + posicion];
                        arreglo[i + posicion] = arreglo[i];
                        arreglo[i] = temp;
                        //ENTONCES ESTE TOMA SU POCIION EL MAYO 
                    }
                    for (int cont2 = 0; cont2 <= i; cont2++)
                    {
                        //ESTE HACE LO MISMO PERO CON LA SEGUNDA PARTE DEL ARREGLO 
                        if (arreglo[cont2] < arreglo[cont2 + posicion])
                        {
                            temp = arreglo[cont2 + posicion];
                            arreglo[cont2 + posicion] = arreglo[cont2];
                            arreglo[cont2] = temp;
                            //ALMACENANDOLO EN UNA VARIABLE TEMPORAL 
                        }
                    }
                }
            }
            //FINALMENTE IMPRIMO EL ORDEN DE MAYOR A MENOR 
            Console.Write("\nNUMEROS ORDENADOS MAYOR A MENOR: \n");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(" " + arreglo[i]);
            }
            Console.Write("\n\n");
        }
          
    }
}
