using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //custumer 1
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Dimitra";
            customer1.LastName = "Nowlic";
            customer1.Salary = 7500;
            customer1.Job = "swimmer";

            //Customer 2
            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Sinan";
            customer2.LastName = "Narkoz";
            customer2.Salary = 1500;
            customer2.Job = "Manager";

            //customer 3
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Martin";
            customer3.LastName = "Martiez";
            customer3.Salary = 750000;
            customer3.Job = "Investor";

            //Custormer 4
            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Name = "Abuzer";
            customer4.LastName = "Kalaman";
            customer4.Salary = 5000;
            customer4.Job = "Engineer";

            CustomerManager customerManager = new CustomerManager();

            //Customer list
            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4};

            //Customer listing
            foreach (var customer in customers)
            {
                Console.WriteLine
                    (
                        "Id: " + customer.Id + " Name: " + customer.Name + " Last name: " + customer.LastName + " Job: " +
                        customer.Job + " Salary: " + customer.Salary
                    );
                Console.WriteLine("--------------------------------------------------------------------------");
            }

            Console.WriteLine();

            //Add customer
            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);
            customerManager.AddCustomer(customer3);
            customerManager.AddCustomer(customer4);

            Console.WriteLine();

            //Delete customer
            customerManager.DeleteCustomer(customer1);
            customerManager.DeleteCustomer(customer2);
            customerManager.AddCustomer(customer3);
            customerManager.AddCustomer(customer4);
        }
    }
}
