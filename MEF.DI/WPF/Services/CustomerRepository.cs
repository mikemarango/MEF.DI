﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Models;

namespace WPF.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer() { Id = 1, Name = "Mike Marango", Email = "mike.marango@gmail.com", Twitter = "@mikemarango" },
                new Customer() { Id = 2, Name = "Jerry Nixon", Email = "jerrynixon@microsoft.com", Twitter = "@jerrynixon" },
            };

            return customers;
        }

        public Customer GetById(int id)
        {
            List<Customer> customers = GetAll();
            return customers.Where(c => c.Id == id).FirstOrDefault();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}