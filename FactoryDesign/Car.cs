using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class Car :IProduct
    {
        public string TypeOfProduct()
        {
            return "CAr";
        }

        public void Save()
        {
            Console.WriteLine("IN car Saving");
        }


        public void Book()
        {
            Console.WriteLine("IN car booking");
        }
    }
}
