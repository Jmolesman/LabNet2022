using Lab.Ejercicio008.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Ejercicio008.Service
{
    public interface IBaseService <T>
    {
        List<T> GetAll();
        T GetItem(int id);
        void AddItem(T newItem);
        T EditItem(T newItemToUpdate);
        void DelItem(int id);
    }
}
