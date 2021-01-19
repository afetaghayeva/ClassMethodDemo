using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        private List<Customer> _customers;

        public CustomerManager()
        {
            _customers = new List<Customer>
            {
                new Customer {Id = 1, FirstName = "Afet", LastName = "Agayeva"},
                new Customer {Id = 2, FirstName = "Ramiz", LastName = "Valiyev"},
                new Customer {Id = 3, FirstName = "Nigar", LastName = "Ashurova"}
            };

        }

        public List<Customer> GetAll()
        {
            return _customers;
        }

        public Customer GetById(int id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }

        public void DeleteAll()
        {
            _customers.Clear();
        }

        public void Delete(int id)
        {
           var customer1= _customers.FirstOrDefault(c=>c.Id==id);
           _customers.Remove(customer1);
        }

        public void Update(Customer customer)
        {
            var newCustomer = _customers.FirstOrDefault(c => c.Id == customer.Id);
            var index = _customers.IndexOf(newCustomer);
            _customers[index] = customer;
        }
    }
}
