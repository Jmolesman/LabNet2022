using Lab.Ejercicio004.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Ejercicio004.EF.Logic
{
    class OrderDetailsLogic : BaseLogic<Order_Details>
    {
        public override string Add(Order_Details itemToAdd)
        {
            throw new NotImplementedException();
        }

        public override string Del(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Order_Details> GetAll()
        {
            return _context.Order_Details.ToList();
        }

        public override Order_Details GetEntityByID(int id)
        {
            Order_Details oOrderDetail;
            try
            {
                oOrderDetail = _context.Order_Details.Find(id);
                return oOrderDetail;
            }
            catch (Exception)
            {
            }
            return null;
        }

        public override string Update(Order_Details itemToChange)
        {
            try
            {
                var orderDetailToUpdate = _context.Order_Details.Find(itemToChange.OrderID);
                _context.Entry(orderDetailToUpdate).CurrentValues.SetValues(itemToChange);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return $"Error to update order detail {ex.Message}";
            }
            return "All data modify successfully";
        }
    }
}
