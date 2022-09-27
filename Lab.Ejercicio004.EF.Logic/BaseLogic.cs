using System.Collections.Generic;
using Lab.Ejercicio004.EF.Data;

namespace Lab.Ejercicio004.EF.Logic
{
    public abstract class BaseLogic <T>
    {
        protected readonly NorthwindContext _context;

        public BaseLogic()
        {
            _context = new NorthwindContext();
        }

        public abstract List<T> GetAll();

        public abstract T GetEntityByID(int id);

        public abstract string Add(T itemToAdd);

        public abstract string Del(int id);

        public abstract string Update(T itemToChange);

    }
}
