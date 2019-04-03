using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            //PrintAllProducts();
            //PrintAllCustomers();

            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();
            //Exercise6();
            //Exercise7();
            //Exercise8();
            //Exercise9();
            //Exercise10();
            //Exercise11();
            //Exercise12();
            //Exercise13();
            //Exercise14();
            //Exercise15();
            //Exercise16();
            //Exercise17();
            //Exercise18();
            //Exercise19();
            //Exercise20();
            //Exercise21();
            //Exercise22();
            //Exercise23();
            //Exercise24();
            //Exercise25();
            //Exercise26();
            //Exercise27();
            //Exercise28();
            //Exercise29();
            //Exercise30();
            //Exercise31();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }


        /// <summary>
        /// Sample, load and print all the product objects
        /// </summary>
        static void PrintAllProducts()
        {
            List<Product> products = DataLoader.LoadProducts();
            PrintProductInformation(products);
        }

        /// <summary>
        /// This will print a nicely formatted list of products
        /// </summary>
        /// <param name="products">The collection of products to print</param>
        static void PrintProductInformation(IEnumerable<Product> products)
        {
            string line = "{0,-5} {1,-35} {2,-15} {3,7:c} {4,6}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock");
            Console.WriteLine("==============================================================================");

            foreach (var product in products)
            {
                Console.WriteLine(line, product.ProductID, product.ProductName, product.Category,
                    product.UnitPrice, product.UnitsInStock);
            }

        }

        /// <summary>
        /// Sample, load and print all the customer objects and their orders
        /// </summary>
        static void PrintAllCustomers()
        {
            var customers = DataLoader.LoadCustomers();
            PrintCustomerInformation(customers);
        }

        /// <summary>
        /// This will print a nicely formated list of customers
        /// </summary>
        /// <param name="customers">The collection of customer objects to print</param>
        static void PrintCustomerInformation(IEnumerable<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("==============================================================================");
                Console.WriteLine(customer.CompanyName);
                Console.WriteLine(customer.Address);
                Console.WriteLine("{0}, {1} {2} {3}", customer.City, customer.Region, customer.PostalCode, customer.Country);
                Console.WriteLine("p:{0} f:{1}", customer.Phone, customer.Fax);
                Console.WriteLine();
                Console.WriteLine("\tOrders");
                foreach (var order in customer.Orders)
                {
                    Console.WriteLine("\t{0} {1:MM-dd-yyyy} {2,10:c}", order.OrderID, order.OrderDate, order.Total);
                }
                Console.WriteLine("==============================================================================");
                Console.WriteLine();
            }
        }


        /// <summary>
        /// Print all products that are out of stock.
        /// </summary>
        static void Exercise1()
        {
            var outOfStock = DataLoader.LoadProducts().Where(p => p.UnitsInStock == 0);

            PrintProductInformation(outOfStock);
        }

        /// <summary>
        /// Print all products that are in stock and cost more than 3.00 per unit.
        /// </summary>
        static void Exercise2()
        {
            var outOfStock = DataLoader.LoadProducts().Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);

            PrintProductInformation(outOfStock);
        }

        /// <summary>
        /// Print all customer and their order information for the Washington (WA) region.
        /// </summary>
        static void Exercise3()
        {
            var washOrders = DataLoader.LoadCustomers().Where(c => c.Region == "WA");

            PrintCustomerInformation(washOrders);
        }

        /// <summary>
        /// Create and print an anonymous type with just the ProductName
        /// </summary>
        static void Exercise4()
        {
            var productNames = from product in DataLoader.LoadProducts()
                               select new
                               {
                                   product.ProductName
                               };

            string line = "{0,-35}";
            Console.WriteLine(line, "Product Name");
            Console.WriteLine("==========================");

            foreach (var product in productNames)
            {
                Console.WriteLine(line, product.ProductName);
            }
        }

        /// <summary>
        /// Create and print an anonymous type of all product information but increase the unit price by 25%
        /// </summary>
        static void Exercise5()
        {
            var products = from product in DataLoader.LoadProducts()
                           select new
                           {
                               product.ProductID,
                               product.ProductName,
                               product.Category,
                               UnitPrice = product.UnitPrice + (product.UnitPrice * .025M),
                               product.UnitsInStock
                           };

            string line = "{0,-5} {1,-35} {2,-15} {3,7:c} {4,6}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock");
            Console.WriteLine("==============================================================================");

            foreach (var product in products)
            {
                Console.WriteLine(line, product.ProductID, product.ProductName, product.Category,
                    product.UnitPrice, product.UnitsInStock);
            }
        }

        /// <summary>
        /// Create and print an anonymous type of only ProductName and Category with all the letters in upper case
        /// </summary>
        static void Exercise6()
        {
            var products = from product in DataLoader.LoadProducts()
                           select new
                           {
                               ProductName = product.ProductName.ToUpper(),
                               Category = product.Category.ToUpper()
                           };

            string line = "{0,-35} {1,-15}";
            Console.WriteLine(line, "Product Name", "Category");
            Console.WriteLine("======================================================");

            foreach (var product in products)
            {
                Console.WriteLine(line, product.ProductName, product.Category);
            }
        }

        /// <summary>
        /// Create and print an anonymous type of all Product information with an extra bool property ReOrder which should 
        /// be set to true if the Units in Stock is less than 3
        /// 
        /// Hint: use a ternary expression
        /// </summary>
        static void Exercise7()
        {
            var products = from product in DataLoader.LoadProducts()
                           select new
                           {
                               product.ProductID,
                               product.ProductName,
                               product.Category,
                               product.UnitPrice,
                               product.UnitsInStock,
                               Reorder = (product.UnitsInStock < 3) ? true : false
                           };

            string line = "{0,-5} {1,-35} {2,-15} {3,7:c} {4,6} {5,10}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock", "Reorder");
            Console.WriteLine("====================================================================================");

            foreach (var product in products)
            {
                Console.WriteLine(line, product.ProductID, product.ProductName, product.Category,
                    product.UnitPrice, product.UnitsInStock, product.Reorder);
            }
        }

        /// <summary>
        /// Create and print an anonymous type of all Product information with an extra decimal called 
        /// StockValue which should be the product of unit price and units in stock
        /// </summary>
        static void Exercise8()
        {
            var products = from product in DataLoader.LoadProducts()
                           select new
                           {
                               product.ProductID,
                               product.ProductName,
                               product.Category,
                               product.UnitPrice,
                               product.UnitsInStock,
                               StockValue = Math.Round((product.UnitPrice * product.UnitsInStock), 2)
                           };

            string line = "{0,-5} {1,-35} {2,-15} {3,7:c} {4,6} {5,15:c}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock", "Value");
            Console.WriteLine("=========================================================================================");

            foreach (var product in products)
            {
                Console.WriteLine(line, product.ProductID, product.ProductName, product.Category,
                    product.UnitPrice, product.UnitsInStock, product.StockValue);
            }
        }

        /// <summary>
        /// Print only the even numbers in NumbersA
        /// </summary>
        static void Exercise9()
        {
            var numbers = DataLoader.NumbersA.Where(number => number % 2 == 0);

            //var numbers = from number in DataLoader.NumbersA
            //                  where number % 2 == 0
            //                  select number;

            foreach (var number in numbers)
            {
                Console.WriteLine("\n" + number);
            }

            //DataLoader.NumbersA.Where(number => number % 2 == 0).ToList().ForEach(x => Console.WriteLine("\n" + x));
        }

        /// <summary>
        /// Print only customers that have an order whos total is less than $500
        /// </summary>
        static void Exercise10()
        {
            // QUERY SYNTAX
            //var customers = (from customer in DataLoader.LoadCustomers()
            //                 from order in customer.Orders
            //                 where order.Total < 500.00M
            //                 select customer).Distinct();

            // METHOD SYNTAX
            var customers = DataLoader.LoadCustomers().Where(customer => customer.Orders.Where(order => order.Total < 500).Any());

            PrintCustomerInformation(customers);
            Console.WriteLine("\n customer count: " + customers.ToList().Count());
        }

        /// <summary>
        /// Print only the first 3 odd numbers from NumbersC
        /// </summary>
        static void Exercise11()
        {
            var numbers = DataLoader.NumbersC.Where(number => number % 2 == 1).Take(3);

            foreach (var number in numbers)
            {
                Console.WriteLine("\n" + number);
            }
        }

        /// <summary>
        /// Print the numbers from NumbersB except the first 3
        /// </summary>
        static void Exercise12()
        {
            var numbers = DataLoader.NumbersB.Skip(3);

            foreach (var number in numbers)
            {
                Console.WriteLine("\n" + number);
            }
        }

        /// <summary>
        /// Print the Company Name and most recent order for each customer in Washington
        /// </summary>
        static void Exercise13()
        {
            //QUERY SYNTAX + METHOD SYNTAX
            var customers = from customer in DataLoader.LoadCustomers()
                            where customer.Region == "WA"
                            select new
                            {
                                customer.CompanyName,
                                customer.Region,
                                Orders = customer.Orders.OrderByDescending(order => order.OrderDate).Take(1)
                            };

            // METHOD SYNTAX
            //var customers = DataLoader.LoadCustomers()
            //    .Where(customer => customer.Region == "WA")
            //    .Select(customer => new
            //    {
            //        customer.CompanyName,
            //        customer.Region,
            //        Orders = customer.Orders.OrderByDescending(order => order.OrderDate).Take(1)
            //    }
            //    );

            string line = "{0,-40} {1, 5}";

            foreach (var customer in customers)
            {
                Console.WriteLine("==============================================================================");
                Console.WriteLine(line, "Company", "Region");
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine(line, customer.CompanyName, customer.Region);
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine("\tRecent Order");
                Console.WriteLine("\t************");
                foreach (var order in customer.Orders)
                {
                    Console.WriteLine("\t{0} {1:MM-dd-yyyy} {2,10:c}", order.OrderID, order.OrderDate, order.Total);
                }
                Console.WriteLine("==============================================================================\n");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Print all the numbers in NumbersC until a number is >= 6
        /// </summary>
        static void Exercise14()
        {
            var numbers = DataLoader.NumbersC.Where(number => number >= 6);
        }

        /// <summary>
        /// Print all the numbers in NumbersC that come after the first number divisible by 3
        /// </summary>
        static void Exercise15()
        {
            var numbers = DataLoader.NumbersC.Where(number => number % 3 == 0);
        }

        /// <summary>a
        /// Print the products alphabetically by name
        /// </summary>
        static void Exercise16()
        {
            var products = from product in DataLoader.LoadProducts()
                           orderby product.ProductName ascending
                           select new
                           {
                               product.ProductName,
                           };

            string line = "{0,-35}";
            Console.WriteLine(line, "Product Name");
            Console.WriteLine("=====================");

            foreach (var product in products)
            {
                Console.WriteLine(line, product.ProductName);
            }
        }

        /// <summary>
        /// Print the products in descending order by units in stock
        /// </summary>
        static void Exercise17()
        {
            var products = from product in DataLoader.LoadProducts()
                           orderby product.UnitsInStock descending
                           select new
                           {
                               product.ProductName,
                               product.UnitsInStock,
                           };

            string line = "{0,-35} {1,6}";
            Console.WriteLine(line, "Product Name", "Stock");
            Console.WriteLine("=====================");

            foreach (var product in products)
            {
                Console.WriteLine(line, product.ProductName, product.UnitsInStock);
            }
        }

        /// <summary>
        /// Print the list of products ordered first by category, then by unit price, from highest to lowest.
        /// </summary>
        static void Exercise18()
        {
            //QUERY SYNTAX
            var products = from product in DataLoader.LoadProducts()
                           orderby product.Category descending, product.UnitPrice descending
                           select new
                           {
                               product.ProductName,
                               product.Category,
                               product.UnitPrice
                           };
            string line = "{0,-35} {1,-15} {2,7:c}";
            Console.WriteLine(line, "Product Name", "Category", "Price");
            Console.WriteLine("==========================================================");

            foreach (var product in products)
            {
                Console.WriteLine(line, product.ProductName, product.Category, product.UnitPrice);
            }

            //METHOD SYNTAX
            //var products = DataLoader.LoadProducts().OrderByDescending(p => p.Category).ThenByDescending(p => p.UnitPrice);//foobarList.OrderBy(x => x.Foo).ThenBy(x => x.Bar)

            //string line = "{0,-5} {1,-35} {2,-15} {3,7:c} {4,6}";
            //Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock");
            //Console.WriteLine("==============================================================================");

            //foreach (var product in products)
            //{
            //    Console.WriteLine(line, product.ProductID, product.ProductName, product.Category,
            //        product.UnitPrice, product.UnitsInStock);
            //}
        }

        /// <summary>
        /// Print NumbersB in reverse order
        /// </summary>
        static void Exercise19()
        {
            var numbers = DataLoader.NumbersB.Reverse();

            foreach (var number in numbers)
            {
                Console.WriteLine("\n" + number);
            }
        }

        /// <summary>
        /// Group products by category, then print each category name and its products
        /// ex:
        /// 
        /// Beverages
        /// Tea
        /// Coffee
        /// 
        /// Sandwiches
        /// Turkey
        /// Ham
        /// </summary>
        static void Exercise20()
        {
            var groups = from product in DataLoader.LoadProducts()
                         orderby product.UnitPrice descending
                         group product by product.Category into newgroup
                         select newgroup;

            string line = "{0,-5} {1,-35} {2,7:c} {3,6}";

            foreach (var group in groups)
            {
                Console.WriteLine("Category: {0}", group.Key);
                Console.WriteLine("=========================================================");
                Console.WriteLine(line, "ID", "Product Name", "Price", "Stock");
                Console.WriteLine("---------------------------------------------------------");

                foreach (var product in group)
                {
                    Console.WriteLine(line, product.ProductID, product.ProductName, product.UnitPrice, product.UnitsInStock);
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Print all Customers with their orders by Year then Month
        /// ex:
        /// 
        /// Joe's Diner
        /// 2015
        ///     1 -  $500.00
        ///     3 -  $750.00
        /// 2016
        ///     2 - $1000.00
        /// </summary>
        static void Exercise21()
        {
            /*
             * Both solutions return a collection of customers who have orders
            */
            //METHOD SYNTAX
            var customers = DataLoader.LoadCustomers().Where(c => (c.Orders.OrderBy(o => o.OrderDate.Year).ThenBy(o => o.OrderDate.Month)).Any());

            //QUERY SYNTAX
            //var customers = (from customer in DataLoader.LoadCustomers()
            //                 from order in customer.Orders
            //                 orderby order.OrderDate.Year, order.OrderDate.Month
            //                 select customer).Distinct();

            PrintCustomerInformation(customers);
        }

        /// <summary>
        /// Print the unique list of product categories
        /// </summary>
        static void Exercise22()
        {
            var groups = from product in DataLoader.LoadProducts()
                         orderby product.Category ascending
                         group product by product.Category into newgroup
                         select newgroup;

            foreach (var group in groups)
            {
                Console.WriteLine("Category: {0}", group.Key);
            }
        }

        /// <summary>
        /// Write code to check to see if Product 789 exists
        /// </summary>
        static void Exercise23()
        {
            int productID = 789;
            var product = DataLoader.LoadProducts().Where(p => p.ProductID == productID);

            if (product.Any())
            {
                Console.WriteLine("Product ID {0} exists in the system:\n", productID);
                PrintProductInformation(product);
            }
            else
            {
                Console.WriteLine("We could not locate Product ID {0} in the system.", productID);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Print a list of categories that have at least one product out of stock
        /// </summary>
        static void Exercise24()
        {
            // METHOD SYNTAX
            //var query = DataLoader.LoadProducts()
            //    .Where(product => product.UnitsInStock == 0)
            //    .OrderBy(product => product.Category)
            //    .GroupBy(product => product.Category);

            // QUERY SYNTAX
            var groups = from product in DataLoader.LoadProducts()
                         where product.UnitsInStock == 0
                         orderby product.Category ascending
                         group product by product.Category into newgroup
                         select newgroup;

            string line = "{0,-35} {1,6}";

            foreach (var group in groups)
            {
                Console.WriteLine("Category: {0}", group.Key);
                Console.WriteLine("=========================================================");
                Console.WriteLine(line, "Product Name", "Stock");
                Console.WriteLine("---------------------------------------------------------");

                foreach (var product in group)
                {
                    Console.WriteLine(line, product.ProductName, product.UnitsInStock);
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Print a list of categories that have no products out of stock
        /// </summary>
        static void Exercise25()
        {
            // METHOD SYNTAX
            //var groups = DataLoader.LoadProducts()
            //    .OrderBy(product => product.Category)
            //    .GroupBy(product => product.Category)
            //    .Where(group => group.All(product => product.UnitsInStock > 0));

            //QUERY SYNTAX
            var groups = from product in DataLoader.LoadProducts()
                         orderby product.Category ascending
                         group product by product.Category into newgroup
                         where newgroup.All(p => p.UnitsInStock > 0)
                         select newgroup;

            string line = "{0,-35} {1,6}";

            foreach (var group in groups)
            {
                Console.WriteLine("Category: {0}", group.Key);
                Console.WriteLine("=========================================================");
                Console.WriteLine(line, "Product Name", "Stock");
                Console.WriteLine("---------------------------------------------------------");

                foreach (var product in group)
                {
                    Console.WriteLine(line, product.ProductName, product.UnitsInStock);
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Count the number of odd numbers in NumbersA
        /// </summary>
        static void Exercise26()
        {
            var count = DataLoader.NumbersA.Where(number => number % 2 != 0).Count();

            Console.WriteLine("The number of odd numbers in the NumbersA array is: " + count);
        }

        /// <summary>
        /// Create and print an anonymous type containing CustomerId and the count of their orders
        /// </summary>
        static void Exercise27()
        {
            var customers = from customer in DataLoader.LoadCustomers()
                            select new
                            {
                                customer.CompanyName,
                                customer.CustomerID,
                                OrderCount = customer.Orders.Count()
                            };

            string line = "{0,-40} {1,10} {2,15}";

            foreach (var customer in customers)
            {
                Console.WriteLine("====================================================================");
                Console.WriteLine(line, "Company Name", "Customer ID", "Order Count");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine(line, customer.CompanyName, customer.CustomerID, customer.OrderCount);
                Console.WriteLine("====================================================================");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Print a distinct list of product categories and the count of the products they contain
        /// </summary>
        static void Exercise28()
        {
            // METHOD SYNTAX
            //var groups = DataLoader.LoadProducts()
            //    .OrderBy(product => product.Category)
            //    .GroupBy(product => product.Category)
            //    .Select(group => new
            //        {
            //            Category = group.Key,
            //            Count = group.Count()
            //        }
            //    );

            //QUERY SYNTAX
            var groups = from product in DataLoader.LoadProducts()
                         orderby product.Category ascending
                         group product by product.Category into newgroup
                         select new
                         {
                             Category = newgroup.Key,
                             Count = newgroup.Count()
                         };

            string line = "{0,-35} {1,15}";

            foreach (var group in groups)
            {
                Console.WriteLine("=========================================================");
                Console.WriteLine(line, "Category: " + group.Category, "Product Count: " + group.Count);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Print a distinct list of product categories and the total units in stock
        /// </summary>
        static void Exercise29()
        {
            // METHOD SYNTAX
            //var groups = DataLoader.LoadProducts()
            //    .OrderBy(product => product.Category)
            //    .GroupBy(product => product.Category)
            //    .Select(group => new
            //        {
            //            Category = group.Key,
            //            Stock = group.Sum(product => product.UnitsInStock)
            //        }
            //    );

            //QUERY SYNTAX
            var groups = from product in DataLoader.LoadProducts()
                         orderby product.Category ascending
                         group product by product.Category into newgroup
                         select new
                         {
                             Category = newgroup.Key,
                             Count = newgroup.Sum(product => product.UnitsInStock)
                         };

            string line = "{0,-35} {1,25}";

            foreach (var group in groups)
            {
                Console.WriteLine("==============================================================");
                Console.WriteLine(line, "Category: " + group.Category, "Total Units in Stock: " + group.Count);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Print a distinct list of product categories and the lowest priced product in that category
        /// </summary>
        static void Exercise30()
        {

            var groups = from product in DataLoader.LoadProducts()
                         orderby product.Category ascending
                         group product by product.Category into newgroup
                         let minPrice = newgroup.Min(product => product.UnitPrice)
                         select new
                         {
                             Category = newgroup.Key,
                             Product = newgroup.Where(product => product.UnitPrice == minPrice)
                         };

            string line = "{0,-35} {1,6:c}";

            foreach (var group in groups)
            {
                Console.WriteLine("Category: {0}", group.Category);
                Console.WriteLine("=========================================================");
                Console.WriteLine(line, "Product Name", "Price");
                Console.WriteLine("---------------------------------------------------------");

                foreach (var product in group.Product)
                {
                    Console.WriteLine(line, product.ProductName, product.UnitPrice);
                }

                Console.WriteLine();
            }

            //PrintProductInformation(DataLoader.LoadProducts().OrderBy(p => p.Category).ThenBy(p => p.UnitPrice));

            Console.WriteLine();
        }

        /// <summary>
        /// Print the top 3 categories by the average unit price of their products
        /// </summary>
        static void Exercise31()
        {
            // METHOD SYNTAX
            //var groups = DataLoader.LoadProducts()
            //    .GroupBy(product => product.Category)
            //    .Select(g => new
            //    {
            //        Category = newgroup.Key,
            //        AvgCategoryPrice = newgroup.Average(product => product.UnitPrice)
            //    }).OrderByDescending(newgroup => newgroup.AvgCategoryPrice).Take(3);

            // QUERY SYNTAX
            var groups = (from product in DataLoader.LoadProducts()
                          group product by product.Category into newgroup
                          select new
                          {
                              Category = newgroup.Key,
                              AvgCategoryPrice = newgroup.Average(product => product.UnitPrice)
                          }).OrderByDescending(newgroup => newgroup.AvgCategoryPrice).Take(3);

            string hline = "{0,-25} {1,25}";
            string line = "{0,-25} {1,25:c}";

            foreach (var group in groups)
            {
                Console.WriteLine("===================================================");
                Console.WriteLine(hline, "Category", "Average Price of products");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine(line, group.Category, group.AvgCategoryPrice);
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
