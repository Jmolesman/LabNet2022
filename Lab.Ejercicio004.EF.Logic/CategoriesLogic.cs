using System;
using System.Collections.Generic;
using System.Linq;
using Lab.Ejercicio004.EF.Entities;

namespace Lab.Ejercicio004.EF.Logic
{
    public class CategoriesLogic : BaseLogic<Categories>
    {
        public override string Add(Categories itemToAdd)
        {
            try
            {
                _context.Categories.Add(itemToAdd);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return $"Error to insert Data into Categories {ex.Message}";
            }
            return "Data successfully inserted";
        }

        public override string Del(int id)
        {
            try
            {
                Categories categoryToDelete = _context.Categories.Find(id);
                _context.Categories.Remove(categoryToDelete);
                _context.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException updateException)
            {
                return updateException.InnerException.InnerException.Message;
            }
            catch (Exception ex)
            {
                return $"Error to delete Category {ex.Message} - {ex.GetType()}";
            }
            return "Category Deleted Successfully";
        }

        public override List<Categories> GetAll()
        {
            return _context.Categories.ToList();
        }

        public override Categories GetEntityByID(int id)
        {
            Categories oCategory;
            try
            {
                oCategory = _context.Categories.Find(id);
                return oCategory;
            }
            catch (Exception)
            {
            }
            return null;
        }

        public override string Update(Categories itemToChange)
        {
            try
            {
                var categoryToUpdate = _context.Categories.Find(itemToChange.CategoryID);
                _context.Entry(categoryToUpdate).CurrentValues.SetValues(itemToChange);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return $"Error to update category details {ex.Message}";
            }
            return "All data modify successfully";
        }
    }
}
