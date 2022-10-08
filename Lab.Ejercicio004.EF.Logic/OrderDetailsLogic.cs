using Lab.Ejercicio004.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Ejercicio004.EF.Logic
{
    public class OrderDetailsLogic : BaseLogic<Order_Details>
    {
        public override string Add(Order_Details itemToAdd)
        {
            throw new NotImplementedException();
        }

        public override string Del(int id)
        {
            try
            {
                Order_Details orderToDelete = _context.Order_Details.Find(id);
                _context.Order_Details.Remove(orderToDelete);
                _context.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException updateException)
            {
                return updateException.InnerException.InnerException.Message;
            }
            catch (Exception ex)
            {
                return $"Error to delete Order ID {ex.Message} - {ex.GetType()}";
            }
            return "The Order Detail is Successfully deleted";
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
            throw new NotImplementedException();
        }

        public string DeleteProductIDFromOrder(int id)
        {
            try
            {
                var lst = GetAll();
                foreach (var item in lst)
                {
                    if (item.ProductID == id)
                    {
                        Del(item.OrderID);
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error to delete fk of order details {ex.Message}";
            }
            return $"The selected product id: {id} is successfully deleted from orders details";
        }
    }
}
