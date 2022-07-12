

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1DePeraltaFacundoo
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarparalelo, dolaroficial;
            double dolares, pesos, peso, euro, euros;

            Console.WriteLine(" ingrese cantidad de dolares");
            dolares = double.Parse(Console.ReadLine());

            dolaroficial = 230;
            dolarparalelo = 280;

            pesos = (dolares * dolaroficial);
            peso = (dolares * dolarparalelo);

            Console.Write($" Con la cantidad de {dolares} dolares, compras {pesos} pesos en el Mercado Oficial");
             Console.Write($" Con la cantidad de {dolares} dolares, compras {peso} pesos en el Mercado Paralelo");

            euro = 1.17;
            euros = dolares * euro;

            Console.Write($" La cantidad de {dolares} dolares, equivalen a {euros} euros");

            Console.ReadLine();
        }

    }
}
