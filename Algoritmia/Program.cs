using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algoritmia
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            string texto2;            

            Console.WriteLine("Bienvenido al sistema \n");
            Console.WriteLine("Digite la primera palabra: ");
            texto = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite la segunda palabra: ");
            texto2 = Console.ReadLine();

            //texto = Regex.Replace(texto, @"\s", "");
            //texto2 = Regex.Replace(texto2, @"\s", "");

            string variable = Regex.Replace(texto, " {2,}", " ");
            string variable2 = Regex.Replace(texto2, " {2,}", " ");

            if (string.Compare(variable, variable2, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreCase) == 0)
            {
                Console.WriteLine("\n Ya existe una palabra similar a la que digitó! \n");
                Console.WriteLine("La palabra previa que habia digitado fue: " + texto);
            }

            Console.ReadKey();
        }
    }
}