using System;
using System.Collections.Generic;
using System.Linq;
using Lab.Ejercicio004.EF.Entities;
using Lab.Ejercicio004.EF.Utils;

namespace Lab.Ejercicio004.EF.Logic
{
    public class ProductsLogic : BaseLogic<Products>
    {
        public override string Add(Products itemToAdd)
        {
            try
            {
                if (ProductsValidation.ValidateProduct(itemToAdd.ProductName,itemToAdd.QuantityPerUnit,itemToAdd.UnitPrice.ToString()))
                {
                    _context.Products.Add(itemToAdd);
                    _context.SaveChanges();
                }
                else
                {
                    return "There are errors in the data provided";
                }
            }
            catch (Exception)
            {
                return $"Error to insert Data into Products";
            }
            return "Data successfully inserted";
        }

        public override string Del(int id)
        {
            try
            {
                Products productToDelete = _context.Products.Find(id);
                if (productToDelete == null)
                {
                    return $"The product you want to delete does not exist {id}";
                }
                else
                {
                    _context.Products.Remove(productToDelete);
                    _context.SaveChanges();
                }
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                return "The product you want to delete is related to another table";
            }
            catch (Exception)
            {
                return "Unknown error detected when trying to delete a Product";
            }
            return "Product Deleted successfully";
        }

        public override List<Products> GetAll()
        {
            try
            {
                return _context.Products.ToList();
            }
            catch (Exception)
            {
                return null;
            }

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

        public override string Update(Products itemToChange)
        {
            try
            {
                if (ProductsValidation.ValidateProduct(itemToChange.ProductName, itemToChange.QuantityPerUnit, itemToChange.UnitPrice.ToString()))
                {
                    var productsToUpdate = _context.Products.Find(itemToChange.ProductID);
                    if (productsToUpdate == null)
                    {
                        return $"The product you want to update does not exist {itemToChange.CategoryID}";
                    }
                    else
                    {
                        _context.Entry(productsToUpdate).CurrentValues.SetValues(itemToChange);
                        _context.SaveChanges();
                    }
                }
                else
                {
                    return "There are errors in the data provided";
                }
            }
            catch (Exception)
            {
                return "Unknown error detected when trying to update product";
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
            catch (Exception)
            {
                return $"Error to set to null to categories ID";
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
            catch (Exception)
            {
                return $"Error to set to null to supplier ID";
            }
            return $"The selected supplier id: {id} is successfully set to null";
        }


    }
}
