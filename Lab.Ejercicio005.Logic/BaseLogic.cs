using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Ejercicio005.Data;

namespace Lab.Ejercicio005.Logic
{
    public abstract class BaseLogic
    {
        protected NorthwindContext context;
        public BaseLogic()
        {
            context = new NorthwindContext();
            //context.Database.Log = Console.WriteLine;
        }
    }
}
