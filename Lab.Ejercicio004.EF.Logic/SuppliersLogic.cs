using System;
using System.Collections.Generic;
using System.Linq;
using Lab.Ejercicio004.EF.Entities;
using Lab.Ejercicio004.EF.Utils;

namespace Lab.Ejercicio004.EF.Logic
{
    public class SuppliersLogic : BaseLogic<Suppliers>
    {
        public override string Add(Suppliers itemToAdd)
        {
            try
            {
                if (SuppliersValidation.ValidateSupplier(itemToAdd.CompanyName,itemToAdd.ContactName,itemToAdd.ContactTitle))
                {
                    _context.Suppliers.Add(itemToAdd);
                    _context.SaveChanges();
                }
                else
                {
                    return "There are errors in the data provided";
                }
            }
            catch (Exception)
            {
                return $"Error to insert Data into Suppliers";
            }
            return "Data successfully inserted";
        }

        public override string Del(int id)
        {
            try
            {
                Suppliers supplierToDelete = _context.Suppliers.Find(id);
                if (supplierToDelete == null)
                {
                    return $"The supplier you want to delete does not exist {id}";
                }
                else
                {
                    _context.Suppliers.Remove(supplierToDelete);
                    _context.SaveChanges();
                }
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                return "The supplier you want to delete is related to another table";
            }
            catch (Exception)
            {
                return "Unknown error detected when trying to delete a supplier";
            }
            return "Supplier Deleted Successfully";
        }

        public override List<Suppliers> GetAll()
        {
            try
            {
                return _context.Suppliers.ToList();
            }
            catch (Exception)
            {
                return null;
            }

        }

        public override Suppliers GetEntityByID(int id)
        {
            Suppliers oSupplier;
            try
            {
                oSupplier = _context.Suppliers.Find(id);
                return oSupplier;
            }
            catch (Exception)
            {
            }
            return null;
        }

        public override string Update(Suppliers itemToChange)
        {
            try
            {
                if (SuppliersValidation.ValidateSupplier(itemToChange.CompanyName, itemToChange.ContactName, itemToChange.ContactTitle))
                {
                    var supplierToUpdate = _context.Suppliers.Find(itemToChange.SupplierID);
                    if (supplierToUpdate == null)
                    {
                        return $"The supplier you want to update does not exist {itemToChange.SupplierID}";
                    }
                    else
                    {
                        _context.Entry(supplierToUpdate).CurrentValues.SetValues(itemToChange);
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
                 return "Unknown error detected when trying to update supplier";
            }
            return "All data modify successfully";
        }
    }
}
