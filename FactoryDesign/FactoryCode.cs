using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace FactoryDesign
{
    class FactoryCode
    {
      public  IProduct Type(string input)
        {
           
            if (input=="Car")
            {
                return new Car();
            }
            else if (input=="Air")
            {
                return new Air();
            }
            return null;

            //public static IProduct Type<T>() where T : IProduct
            //{
            //    return Activator.CreateInstance<T>();
            //}
        }
    }
}
