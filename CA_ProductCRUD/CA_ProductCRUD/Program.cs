using System;

namespace CA_ProductCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            Category category = new Category();
            Customer customer = new Customer();
            Employee employee = new Employee();
            Shipper shipper = new Shipper();
            Supplier supplier = new Supplier();

            //Create Kısmı
            Console.WriteLine(product.Create());
            Console.WriteLine(category.Create());
            Console.WriteLine(customer.Create());
            Console.WriteLine(employee.Create());
            Console.WriteLine(shipper.Create());
            Console.WriteLine(supplier.Create());
            Console.WriteLine("***************************");
            //Read Kısmı
            product.GetList();
            category.GetList();
            customer.GetList();
            employee.GetList();
            shipper.GetList();
            supplier.GetList();
            Console.WriteLine("***************************");
            //Update Kısmı
            Console.WriteLine(product.Update(product.GetById(1)));
            Console.WriteLine(category.Update(category.GetById(1)));
            Console.WriteLine(customer.Update(customer.GetById(1)));
            Console.WriteLine(employee.Update(employee.GetById(1)));
            Console.WriteLine(shipper.Update(shipper.GetById(1)));
            Console.WriteLine(supplier.Update(supplier.GetById(1)));
            Console.WriteLine("***************************");
            //Delete Kısmı
            Console.WriteLine(product.Delete(2));
            Console.WriteLine(category.Delete(2));
            Console.WriteLine(customer.Delete(2));
            Console.WriteLine(employee.Delete(2));
            Console.WriteLine(shipper.Delete(2));
            Console.WriteLine(supplier.Delete(2));
            Console.WriteLine("***************************");

        }
    }
}
