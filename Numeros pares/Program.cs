using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_pares {
    class Program {
        static void Main(string[] args) {

            int n, i, pares;

            Console.Write("Quatos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            int[] numeros = new int[n];

            for (i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("NUMEROS PARES:");
            for (i = 0; i < n; i++) {
                if (numeros[i] % 2 == 0) {
                    Console.Write(numeros[i] + "  ");
                }
            }

            pares = 0;
            for (i = 0; i < n; i++) {
                if (numeros[i] % 2 == 0) {
                    pares = pares + 1;
                }    
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("QUANTIDADE DE PARES = " + pares);
        }
    }
}
