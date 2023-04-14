using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diametro;
            double resultado;
            double raiz = 1.41;
            double resultado2;
            double potencia;

            Console.WriteLine("valor do diametro");
            diametro = double.Parse(Console.ReadLine());
            resultado = diametro / raiz;
            Console.WriteLine();
            resultado2 = diametro / raiz;
            Console.WriteLine();

            potencia = resultado * resultado2;
            Console.WriteLine("valor da area {0}", potencia);


            
            

        }
    }
}
