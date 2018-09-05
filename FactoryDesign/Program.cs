using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            //string def = "FactoryDesign.";
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            input = Console.ReadLine();
            input =textInfo.ToTitleCase(input);
            FactoryCode prod = new FactoryCode();
            IProduct product = prod.Type(input);
            product.Book();
            product.Save();
            Console.ReadKey();
        }
    }
}
