using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Ejercicio005.Entities;
using Lab.Ejercicio005.Logic;

namespace Lab.Ejercicio005.Logic
{
    public class ProductsLogic : BaseLogic
    {
        public IQueryable<Products> Ejercicio002()
        {
            /*
             * 2. Query para devolver todos los productos sin stock
             *  SQL = SELECT * FROM PRODUCTS
             *  WHERE UnitsInStock is NULL
             *  OR UnitsInStock = 0
            */

            var query2Syntax = from product in context.Products
                               where product.UnitsInStock == null || product.UnitsInStock == 0
                               select product;

            var query2Method = context.Products.Where(p => p.UnitsInStock == null || p.UnitsInStock == 0)
                                                .Select(p => p);
            return query2Syntax;
        }

        public IQueryable<Products> Ejercicio003()
        {
            /*
             * 3. Query para devolver todos los productos que tienen stock y que cuestan 
             * más de 3 por unidad
             * SQL = SELECT * FROM PRODUCTS
             *  WHERE (UnitsInStock is not NULL
             *  OR UnitsInStock > 0)
             *  AND UnitPrice > 3
            */

            var query3Syntax = from products in context.Products
                                where (products.UnitsInStock != null || products.UnitsInStock > 0) && products.UnitPrice > 3
                                select products;

            var query3Method = context.Products.Where (p => (p.UnitsInStock != null 
                                                || p.UnitsInStock >0) && p.UnitPrice >3)
                                                .Select(p => p);
            return query3Method;
        }

        public IQueryable<Products> Ejercicio005()
        {
            /*
             * 5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID
             * de producto sea igual a 789
             * 
             * SQL = SELECT TOP FROM PRODUCTS
             * WHERE PRODUCTID = 789
             */

            var query5Syntax = from product in context.Products
                               where product.ProductID == 789
                               select product;


            var query5Method = context.Products.Where(p => p.ProductID == 789)
                                                .Select(p => p);
            return query5Syntax;
        }

        public IQueryable<Products> Ejercicio009()
        {
            /*
             * 9. Query para devolver lista de productos ordenados por nombre
             * 
             * SQL = SELECT * FROM Products
             * ORDER BY [ProductName]
             */

            var query9Syntax = from products in context.Products
                               orderby products.ProductName
                               select products;

            var query9Method = context.Products.OrderBy(p => p.ProductName)
                                                .Select(p => p);
            return query9Method;
        }

        public IQueryable<Products> Ejercicio010()
        {
            /*
             * 10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor. 
             * 
             * SQL = SELECT * FROM Products
             * ORDER BY [UnitsInStock] DESC
             */

            var query10Syntax = from products in context.Products
                               orderby products.UnitsInStock descending
                               select products;

            var query10Method = context.Products.OrderBy(p => p.UnitsInStock)
                                                .Select(p => p);
            return query10Syntax;
        }


        public IEnumerable<Categories> Ejercicio011()
        {
            /*
             * 11. Query para devolver las distintas categorías asociadas a los productos
             * 
             * SQL = SELECT DISTINCT c.[CategoryID]
             *       FROM [dbo].[Categories] c
             *       JOIN [dbo].[Products] p
             *       ON c.[CategoryID] = p.[CategoryID] 
             */

            var query11Syntax = (from products in context.Products
                                 join category in context.Categories
                                 on products.CategoryID equals category.CategoryID
                                 select category).ToList().Distinct();

            return query11Syntax;
        }

        public Products Ejercicio012()
        {
            /*
             * 12. Query para devolver el primer elemento de una lista de productos
             * 
             * SQL = select top 1 [ProductID] 
             *      from [dbo].[Products]
             */

            var query12Syntax = (from product in context.Products
                                 select product).FirstOrDefault();

            return query12Syntax;
        }

    }
}

