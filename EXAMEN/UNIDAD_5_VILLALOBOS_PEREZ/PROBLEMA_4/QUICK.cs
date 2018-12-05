using System;
using System.Collections.Generic;
using System.Text;

namespace PROBLEMA_4
{
    class QUICK
    {

        private static void QuickSortD(int[] arreglo, int primero, int ultimo)
        {// // EL METODO QUICKsort RECIBE 3 PARAMETROS POR DEFECTO QUE REPRESENTA 
            int cont1 = (int)primero, cont2 = (int)ultimo;
            int pilar = ((cont1 + cont2) / 2); // EL ARREGLO CON TODOS LOS ELEMENTOS YA INTEGRADOS 
            int pivote = arreglo[pilar];
            do
            {// Y EL PRIMER Y SEGUNDO VALOR QUE SERAN LOS QUE SE COMPARAM 
                while (arreglo[cont1] < pivote) cont1++;
                while (arreglo[cont2] > pivote) cont2--;
                // ESTOS CICLOS DICEN QUE SI EL ELEMTO DEL ARREGLO ES MAYOR O MENOR QUE EL PIVOTE 
                // SE ACOMODAN EN EL PRINCIPIO O FINAL DEPENDIENDO DE SU VALOR
                if (cont1 <= cont2)
                {// CUANDO EL VALOR DEL PRIMERO ES MENOR IGUAL AL ULTIMO
                    int temp = arreglo[cont1];
                    // SE ASIGNA A UNA VARIABLE TEMPORAL CON EL VALOR ASIGNADO 
                    arreglo[cont1] = arreglo[cont2];
                    // ESE VALOR SE INTERCAMBIA DEL LADO ANTES O DESPUES DEL PIVOTE
                    arreglo[cont2] = temp;
                    cont1++; // DEPENDIENDO DE SU EJECUCION LOS VALORES SE 
                    cont2--; // ACOMODAN DE MENOR A MAYOR 
                }
            }
            while (cont1 <= cont2); // EL CICLO TERMINA SI EL PRIMER VAOLOR ES MENOR O IGUAL AL ULTIMO
            if (primero < cont2) QuickSortD(arreglo, primero, cont2); // SI EL PRIMERO VALOR ES MORO O IGUAL AL ULTIMO 
            if (cont1 < ultimo) QuickSortD(arreglo, cont1, ultimo); // SE MANDA A EJECUTAR EL MISMO METODO 
        }

        public void C1()// ARREGLO 1 
        {
            //INICIO EL ARREGLO 
            int[] dato = new int[] { 12, 16, 19, 5, 13, 9, 17, 20, 23, 13, 4, 16, 12, 16, 19, 20, 9, 21, 1, 13, 5, 21 };
            Console.Write("\nINICIO : L  O  R  E  M  I  P  S  U  M  D  O  L  O  R  S  I  T  A  M  E  T ");
            Console.Write("\nINICIO : 12 16 19 5  13 9  17 20 23 13 4  16 12 16 19 20 9  21 1  13 5  21 \n");
            //
            // MANDO A LLAMAR AL METODO QUICK SORT 
            QuickSortD(dato, 0, dato.Length - 1);
            for (int cont = 0; cont < dato.Length; cont++)
                Console.Write(dato[cont].ToString() +" ");
            // PARA DARLE FORMATO A ALA IMPRESION 
        }
    }
}
