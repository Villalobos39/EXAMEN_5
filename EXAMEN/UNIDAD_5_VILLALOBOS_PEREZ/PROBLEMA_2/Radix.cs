using System;
using System.Collections.Generic;
using System.Text;

namespace PROBLEMA_2
{
    class Radix
    { 
        //Genere un método int que obtenga el valor de 80 
          //números random positivos, y ordenelos con el 
          //método radix, en cada ejecución del programa 
          //los números no deben ser iguales(ya que son random).

        static void RSort(int[] arr)
        {
            int comienzo, final;//DECLARO LAS VARIABLES DEL METODO 
            int[] tmp = new int[arr.Length]; //EL ARREGLO ALMACENA UNA VARIABLE TEMPORAL 
            //CON UN FOR COMIENZO EL ACOMODO DE LOS NUMERO DE FORMA ORDENADA 
            for (int cambio = 31; cambio > -1; --cambio)
            {// PARA ESO LA COVERSION DE 31 AYUUDAD ALL CAMBIO DE POSICION 
                //QUE SE EFECTUA DENTRO DEL ARREGLO 
                final = 0;
                for (comienzo = 0; comienzo < arr.Length; ++comienzo)
                {//ASI LLEGAMOS A LA COMPARACION EN UN CICLO DE NUMEROS 
                    bool move = (arr[comienzo] << cambio) >= 0;
                    if (cambio == 0 ? !move : move)
                        //SI LA POCISION DE ESTE EXISTE SE MUEVE A LA QUE NO 
                        arr[comienzo - final] = arr[comienzo];
                    else //DEPENDE DEL VALOR QUE TIENE SI ESTE YA ESTA ACOMODADO O NO 
                        tmp[final++] = arr[comienzo];
                } //ASI CADA UNO SE VA ORDENANDO 
                Array.Copy(tmp, 0, arr, arr.Length - final, final);
            }
        }

        public void Metod1()
        {
            int[] arreglo = new int[80];
            Random rand = new Random(); // DE FORMA ALEATORIA SE ACOMODAN LOS 80  ELEMENTOS 
            for (int cont = 0; cont < arreglo.Length; cont++)
            { // SE MUESTRAN COMO SE ENCUENTRAN ANTES DE ACOMODARLOS 
                arreglo[cont] = rand.Next(0, 80);
            } //`PARA ESO SE DESPLEGAN CON UN FOR DE 0 AL 80 LO NUMERO PUEN VARIAR 
            Console.Write("\nNUMEROS RANDOM  : \n");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(" " + arreglo[i]);
            }

            Console.Write("\n");
          
            //se imprime el acomodo final del preceso
            RSort(arreglo);
            Console.WriteLine("\nRADIX : ");
            foreach (var item in arreglo)
            {
                Console.Write(" " + item);
            }

        }
    }
}
