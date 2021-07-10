using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
      public  void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.Id + " nolu müşteri sisteme eklendi...");
        }

       public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.Id + " nolu müşteri sistemden silindi...");
        }

        /*public void CustomerList(Customer customers)
        {
           foreach (var customer in customers)
            {

            }
        }*/
    }
}
