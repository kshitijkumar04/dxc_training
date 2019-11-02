using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            ADODemoEntities obj = new ADODemoEntities();
            int choice = 1;
            while (choice != 0)
            {
                Console.WriteLine("1 - View Existing Customers \n2 -Add New Customer");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            var cinfo = obj.customers;                         
                            foreach (var item in cinfo)
                            {
                             product pro = obj.products.First(x => x.productid == item.productid);
                             Console.WriteLine($"Customer ID - {item.customerId}\nCustomer Name - {item.cname}\nProduct ID - {item.productid}\nProduct Name -{pro.pname} \nQuantity - {item.quantity}\nSupplier - {item.sname}\nTotal Bill - {item.bill}\n\n");
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter Customer Name:");
                            customer newcustomer = new customer()
                            {
                                cname = Console.ReadLine()
                            };
                            var productlist = obj.products;
                            foreach (var item in productlist)
                            {
                                Console.WriteLine($"{item.productid}  {item.pname}");
                            }
                            Console.WriteLine("Enter ID To Add Item To Cart:");
                            newcustomer.productid = int.Parse(Console.ReadLine());                            
                            var supplierlist = obj.suppliers;
                            product pro = obj.products.First(x => x.productid == newcustomer.productid);
                            foreach (var item in supplierlist)
                            {
                                if (item.productid == newcustomer.productid)
                                {
                                    Console.WriteLine($"Supplier Id-{item.supplierId}   Name-{item.sname}   Product ID-{item.productid}   Product Name-{pro.pname}   City-{item.location}   Price-{item.price}");
                                    continue;
                                }

                            }
                            Console.WriteLine("Enter Supplier Id to select a supplier");
                            int supid = int.Parse(Console.ReadLine());
                            supplier sup = obj.suppliers.First(x => x.supplierId == supid);
                            newcustomer.sname = sup.sname;
                            Console.WriteLine("Enter Quantity:");
                            newcustomer.quantity = int.Parse(Console.ReadLine());
                            newcustomer.bill = sup.price * newcustomer.quantity;
                            Console.WriteLine($"Total Bill - Rs{newcustomer.bill}");
                            obj.customers.Add(newcustomer);
                            obj.SaveChanges();
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
    }
}
