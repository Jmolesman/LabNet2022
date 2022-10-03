using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Ejercicio005.Entities;
using Lab.Ejercicio005.Logic;

namespace Lab.Ejercicio005.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomersLogic newCustomerLogic = new CustomersLogic();
            ProductsLogic newProductsLogic = new ProductsLogic();
            Customers newCustomer = new Customers();
            Products newProduct = new Products();
            bool quit = false;
            int option = 0;

            do
            {
                Console.Clear();
                Console.Write("Seleccione un numero del 1 al 13 para ver el ejercicio o 0 para salir: ");
                try
                {
                    option = int.Parse(Console.ReadLine());
                    if (option == 0)
                    {
                        quit = true;
                    }
                }
                catch (Exception)
                {
                    option = -1;
                }

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Saliendo...................");
                        break;
                    case 1:
                        Console.WriteLine("Ejercicio 001");
                        Console.WriteLine("1. Query para devolver objeto customer");
                        newCustomer = newCustomerLogic.Ejercicio001().FirstOrDefault();
                        Console.WriteLine($"ID: {newCustomer.CustomerID}");
                        Console.WriteLine($"Contact Name: {newCustomer.ContactName}");
                        break;
                    case 2:
                        Console.WriteLine("Ejercicio 002");
                        Console.WriteLine("2. Query para devolver todos los productos sin stock");
                        foreach (var item in newProductsLogic.Ejercicio002())
                        {
                            Console.WriteLine($"ID: {item.ProductID} - Product Name: {item.ProductName} - Stock: {item.UnitsInStock}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ejercicio 003");
                        Console.WriteLine("3. Query para devolver todos los productos que tienen stock y que " +
                            "cuestan más de 3 por unidad");
                        foreach (var item in newProductsLogic.Ejercicio003())
                        {
                            Console.WriteLine($"ID: {item.ProductID} - Product Name: {item.ProductName} - Stock: {item.UnitsInStock} - Price: {item.UnitPrice}");

                        }
                        break;
                    case 4:
                        Console.WriteLine("Ejercicio 004");
                        Console.WriteLine("4. Query para devolver todos los customers de la Región WA");
                        foreach (var item in newCustomerLogic.Ejercicio004())
                        {
                            Console.WriteLine($"Company Name: {item.CompanyName} - Region: {item.Region}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Ejercicio 005");
                        Console.WriteLine("5. Query para devolver el primer elemento o nulo de una lista de " +
                            "productos donde el ID de producto sea igual a 789");
                        newProduct = newProductsLogic.Ejercicio005().FirstOrDefault();
                        if (newProduct != null)
                        {
                            Console.WriteLine($"ID: {newProduct.ProductID}");
                            Console.WriteLine($"Contact Name: {newProduct.ProductName}");
                        }
                        else
                        {
                            Console.WriteLine("El producto no existe");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Ejercicio 006");
                        Console.WriteLine("6. Query para devolver los nombre de los Customers. Mostrarlos en " +
                            "Mayúscula y en Minúscula.");
                        foreach (var item in newCustomerLogic.Ejercicio006())
                        {
                            Console.WriteLine($"Mayus: {item.ToUpper()} - Minus: {item.ToLower()}");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Ejercicio 007");
                        Console.WriteLine("7. Query para devolver Join entre Customers y Orders donde los customers");
                        Console.WriteLine("sean de la Región WA y la fecha de orden sea mayor a 1/1/1997.");
                        var newCustomerOrder = newCustomerLogic.Ejercicio007();
                        foreach (var item in newCustomerOrder)
                        {
                            Console.Write($"Customer Region: {item.Customer.Region} ");
                            Console.WriteLine($"Customer Name: {item.Customer.CompanyName} ");
                            Console.Write($"Order ID: {item.Order.OrderID} ");
                            Console.Write($"Order Date: {item.Order.OrderDate} ");
                            Console.WriteLine($"Order Ship Name: {item.Order.ShipName} ");
                            Console.WriteLine("************************************************************");
                        }
                        break;
                    case 8:
                        Console.WriteLine("Ejercicio 008");
                        Console.WriteLine("8. Query para devolver los primeros 3 Customers de la Región WA");
                        foreach (var item in newCustomerLogic.Ejercicio008())
                        {
                            Console.Write($"Customer Region: {item.Region} ");
                            Console.Write($"Customer Name: {item.CompanyName} ");
                            Console.WriteLine($"Customer ID: {item.CustomerID}");
                            Console.WriteLine("************************************************************");
                        }
                        break;
                    case 9:
                        Console.WriteLine("Ejercicio 009");
                        Console.WriteLine("9. Query para devolver lista de productos ordenados por nombre");
                        foreach (var item in newProductsLogic.Ejercicio009())
                        {
                            Console.Write($"Product ID: {item.ProductID} ");
                            Console.Write($"Product Name: {item.ProductName } ");
                            Console.WriteLine($"Product Stock: {item.UnitsInStock}");
                            Console.WriteLine("************************************************************");
                        }
                        break;
                    case 10:
                        Console.WriteLine("Ejercicio 010");
                        Console.WriteLine("10. Query para devolver lista de productos ordenados por ");
                        Console.WriteLine("unit in stock de mayor a menor.");
                        foreach (var item in newProductsLogic.Ejercicio010())
                        {
                            Console.Write($"Product ID: {item.ProductID} ");
                            Console.Write($"Product Name: {item.ProductName } ");
                            Console.WriteLine($"Product Stock: {item.UnitsInStock}");
                            Console.WriteLine("************************************************************");
                        }
                        break;
                    case 11:
                        Console.WriteLine("Ejercicio 011");
                        Console.WriteLine("11. Query para devolver las distintas categorías asociadas a los productos");
                        foreach (var item in newProductsLogic.Ejercicio011())
                        {
                            Console.Write($"Category ID: {item.CategoryID} ");
                            Console.WriteLine($"Category Name: {item.CategoryName}");
                            Console.WriteLine("************************************************************");
                        }
                        break;
                    case 12:
                        Console.WriteLine("Ejercicio 012");
                        Console.WriteLine("12. Query para devolver el primer elemento de una lista de productos");
                        newProduct = newProductsLogic.Ejercicio012();
                        Console.WriteLine($"Product ID: {newProduct.ProductID}");
                        Console.WriteLine($"Product Name: {newProduct.ProductName}");
                        Console.WriteLine($"Product Quantity Per Unit: {newProduct.QuantityPerUnit}");
                        Console.WriteLine($"Product Unit Price: {newProduct.UnitPrice}");
                        Console.WriteLine($"Product Stock: {newProduct.UnitsInStock}");
                        break;
                    case 13:
                        Console.WriteLine("Ejercicio 013");
                        Console.WriteLine("13. Query para devolver los customer con la cantidad de ordenes asociadas");

                        foreach (var item in newCustomerLogic.Ejercicio013())
                        {
                            Console.WriteLine($"Customer ID: {item.Key}");
                            Console.WriteLine($"Orders Count: {item.Count()}");
                        }
                        break;
                    default:
                        Console.WriteLine("Seleccione una opcion correcta por favor...");
                        break;
                }
                Console.WriteLine("Presione una tecla para continuar....");
                Console.ReadKey();
            } while (!quit);
        }
    }
}
