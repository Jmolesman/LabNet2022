using System;
using System.Collections.Generic;
using System.Linq;
using Lab.Ejercicio004.EF.Entities;

namespace Lab.Ejercicio004.EF.Logic
{
    public class SuppliersLogic : BaseLogic<Suppliers>
    {
        public override string Add(Suppliers itemToAdd)
        {
            try
            {
                _context.Suppliers.Add(itemToAdd);
                _context.SaveChanges();
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
                _context.Suppliers.Remove(supplierToDelete);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return "Error to delete Supplier";
            }
            return "Supplier Deleted Successfully";
        }

        public override List<Suppliers> GetAll()
        {
            return _context.Suppliers.ToList();
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
                var supplierToUpdate = _context.Suppliers.Find(itemToChange.SupplierID);
                _context.Entry(supplierToUpdate).CurrentValues.SetValues(itemToChange);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return $"Error to update supplier {ex.Message}";
            }
            return "All data modify successfully";
        }
    }
}
