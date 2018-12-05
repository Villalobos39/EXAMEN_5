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

            QUICK qUICK = new QUICK();
            qUICK.C1();
            Console.ReadKey();
        }
    }
}
