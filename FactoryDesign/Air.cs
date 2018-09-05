using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class Air:IProduct
    {
        public string TypeOfProduct()
        {
            return "AIR";
        }

        public void Save()
        {
            Console.WriteLine("IN air saving");
        }


        public void Book()
        {
            Console.WriteLine("IN air booking");
        }
    }
}
