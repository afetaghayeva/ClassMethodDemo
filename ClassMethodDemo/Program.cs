using System;
using System.Linq;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            

            //Console.WriteLine(customerManager.GetById(1).FirstName);
            customerManager.Add(new Customer()
            {
                FirstName = "Leman",
                Id = 4,
                LastName = "Hesenova"
            });
            // customerManager.Delete(3);

            customerManager.Update(new Customer()
            {
                Id = 1,
                FirstName = "Afet",
                LastName = "Valiyeva"

            });

            foreach (var item in customerManager.GetAll())
            {

                Console.WriteLine(item.Id + " " + item.FirstName + " " + item.LastName);
            }
        }
    }
}
