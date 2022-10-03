using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Ejercicio005.Entities;

namespace Lab.Ejercicio005.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public IQueryable<Customers> Ejercicio001()
        {
            /*
             * 1. Query para devolver objeto customer
             *     SQL = Select TOP(* (poner cada columna))
             *           From Customer
            */
            //context.Database.Log = Console.WriteLine;

            var query1Syntax = (from customer in context.Customers
                                select customer).Take(1);

            var query1Method = (context.Customers.Select( c => c)).Take(1);
            return query1Method;
        }

        public IQueryable<Customers> Ejercicio004()
        {
            /*
             *  4. Query para devolver todos los customers de la Región WA
             *  SQL = SELECT * FROM COSTUMERS
             *  WHERE Region = "WA"
             */

            var query4Syntax = from costumer in context.Customers
                               where costumer.Region == "WA"
                               select costumer;

            var query4Method = context.Customers.Where(c => c.Region == "WA")
                                                .Select(c => c);
            return query4Syntax;
        }

        public IQueryable<string> Ejercicio006()
        {
            /*
             * 6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.
             *  SQL = select CompanyName from customers
             */

            var query6Syntax = from customer in context.Customers
                               select (customer.CompanyName);


            var query6Method = context.Customers.Select(c => c.CompanyName);

            return query6Syntax;
        }

        public IEnumerable<CustomerOrder> Ejercicio007()
        {
            /*
             * 7. Query para devolver Join entre Customers y Orders donde los customers sean de la 
             * Región WA y la fecha de orden sea mayor a 1/1/1997.
             * SQL = SELECT * FROM CUSTOMERS c
             * JOIN Orders o
             * ON c.CustomerID = o.CustomerID
             * WHERE c.Region = 'WA'
             * AND o.OrderDate > '01-01-1997'
             */

            var query7Syntax = from customer in context.Customers
                               join order in context.Orders
                               on customer.CustomerID equals order.CustomerID
                               where (customer.Region == "WA" && order.OrderDate > new DateTime(1997, 01, 01))
                               select new { customer, order };

            return query7Syntax.ToList().Select(r => new CustomerOrder(r.customer,r.order));
        }

        public IQueryable<Customers> Ejercicio008()
        {
            /*
             * 8. Query para devolver los primeros 3 Customers de la  Región WA
             * SQL = SELECT TOP 3 COMPANY NAME
             *      FROM CUSTOMERS
             *      WHERE Region = 'WA'
             */

            var query8Syntax = (from customers in context.Customers
                                where customers.Region == "WA"
                                select customers).Take(3);

            var query8Method = (context.Customers.Where(c => c.Region == "WA")
                                                .Select(c => c)).Take(3);


            return query8Method;
        }

        public IQueryable<IGrouping<string,Customers>> Ejercicio013()
        {
            /*
             * 13. Query para devolver los customer con la cantidad de ordenes asociadas
             * SQL = SELECT TOP 3 COMPANY NAME
             *      FROM CUSTOMERS
             *      WHERE Region = 'WA'
             */

            var query13Syntax = from customer in context.Customers
                                join order in context.Orders
                                on customer.CustomerID equals order.CustomerID
                                group customer by customer.CustomerID;

            return query13Syntax;
        }
    }
}
