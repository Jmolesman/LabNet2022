using System;
using System.Collections.Generic;
using System.Linq;
using Lab.Ejercicio004.EF.Entities;

namespace Lab.Ejercicio004.EF.Logic
{
    public class ProductsLogic : BaseLogic<Products>
    {
        public override string Add(Products itemToAdd)
        {
            try
            {
                _context.Products.Add(itemToAdd);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return $"Error to insert Data into Products {ex.Message}";
            }
            return "Data successfully inserted";
        }

        public override string Del(int id)
        {
            try
            {
                Products productToDelete = _context.Products.Find(id);
                _context.Products.Remove(productToDelete);
                _context.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException updateException)
            {
                return updateException.InnerException.InnerException.Message;
            }
            catch (Exception ex)
            {
                return $"Error to delete Product {ex.Message} - {ex.GetType()}";
            }
            return "Product Deleted Successfully";
        }

        public override List<Products> GetAll()
        {
            return _context.Products.ToList();
        }

        public override string Update(Products itemToChange)
        {
            try
            {
                var productsToUpdate = _context.Products.Find(itemToChange.ProductID);
                _context.Entry(productsToUpdate).CurrentValues.SetValues(itemToChange);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return $"Error to update product {ex.Message}";
            }
            return "All data modify successfully";
        }

        public string SetCategoryToNull(int id)
        {
            try
            {
                var lst = GetAll();
                foreach (var item in lst)
                {
                    if (item.CategoryID == id)
                    {
                        item.CategoryID = null;
                        Update(item);
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error to set to null to categories ID {ex.Message}";
            }
            return $"The selected category id: {id} is successfully set to null";
        }

        public string SetSupplierToNull(int id)
        {
            try
            {
                var lst = GetAll();
                foreach (var item in lst)
                {
                    if (item.SupplierID == id)
                    {
                        item.SupplierID = null;
                        Update(item);
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error to set to null to supplier ID {ex.Message}";
            }
            return $"The selected supplier id: {id} is successfully set to null";
        }

        public override Products GetEntityByID(int id)
        {
            Products oProduct;
            try
            {
                oProduct = _context.Products.Find(id);
                return oProduct;
            }
            catch (Exception)
            {
            }
            return null;
        }
    }
}
