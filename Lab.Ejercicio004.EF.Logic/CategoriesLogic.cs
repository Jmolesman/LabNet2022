using System;
using System.Collections.Generic;
using System.Linq;
using Lab.Ejercicio004.EF.Entities;
using Lab.Ejercicio004.EF.Utils;

namespace Lab.Ejercicio004.EF.Logic
{
    public class CategoriesLogic : BaseLogic<Categories>
    {
        public override string Add(Categories itemToAdd)
        {
            try
            {
                if (CategoriesValidation.ValidateCategory(itemToAdd.CategoryName, itemToAdd.Description))
                {
                    _context.Categories.Add(itemToAdd);
                    _context.SaveChanges();
                }
                else
                {
                    return "There are errors in the data provided";
                }
            }
            catch (Exception)
            {
                return $"Error to insert Data into Categories";
            }
            return "Data successfully inserted";
        }

        public override string Del(int id)
        {
            try
            {
                Categories categoryToDelete = _context.Categories.Find(id);
                if (categoryToDelete == null)
                {
                    return $"The category you want to delete does not exist {id}";
                }
                else
                {
                    _context.Categories.Remove(categoryToDelete);
                    _context.SaveChanges();
                }
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                return "The category you want to delete is related to another table";
            }
            catch (Exception)
            {
                return "Unknown error detected when trying to delete a category";
            }
            return "Category successfully deleted";
        }

        public override List<Categories> GetAll()
        {
            try
            {
                return _context.Categories.ToList();
            }
            catch (Exception)
            {
                return null;
            }

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
                if (CategoriesValidation.ValidateCategory(itemToChange.CategoryName, itemToChange.Description))
                {
                    var categoryToUpdate = _context.Categories.Find(itemToChange.CategoryID);
                    if (categoryToUpdate == null)
                    {
                        return $"The category you want to update does not exist {itemToChange.CategoryID}";
                    }
                    _context.Entry(categoryToUpdate).CurrentValues.SetValues(itemToChange);
                    _context.SaveChanges();
                }
                else
                {
                    return "There are errors in the data provided";
                }
            }
            catch (Exception)
            {
                return "Unknown error detected when trying to update category";
            }
            return "All data modify successfully";
        }
    }
}
