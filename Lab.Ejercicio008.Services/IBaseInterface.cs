using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Ejercicio008.Services
{
    public interface IBaseInterface <T>
    {
        List<T> GetAll();
        T GetByID(int id);
        void Add(T newItem);
        void Del(T newItem);
    }
}
