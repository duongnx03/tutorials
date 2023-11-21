using System;
using Exercise.NET.Data;
using Exercise.NET.IRepository;
using Exercise.NET.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercise.NET.Repository
{
	public class CustomerRepo : ICustomerRepo
	{
        public CustomerRepo(CustomerContext db)
        {
            this.db = db;
        }
        private readonly CustomerContext db;

        public async Task<int> Create(Customer customer)
        {
            db.Customers.Add(customer);
            try
            {
                return await db.SaveChangesAsync();
            }
            catch
            {
                return -1;
            }
           
        }

        public async Task<int> Delete(int id)
        {
            var cus = await db.Customers.SingleOrDefaultAsync(c => c.Id == id);
            if(cus != null)
            {
                db.Customers.Remove(cus);
                return await db.SaveChangesAsync();
            }
            else
            {
                return -1;
            }
        }

        public async Task<int> Edit(Customer customer)
        {
            var cus = await db.Customers.SingleOrDefaultAsync(c => c.Id == customer.Id);
            if(cus != null)
            {
                cus.Email = customer.Email;
                cus.Birthday = customer.Birthday;
                cus.Gender = customer.Gender;
                cus.Name = customer.Name;
                return await db.SaveChangesAsync();
            }
            else
            {
                return -1;
            }
        }

        public async Task<Customer> Get(int id)
        {
            var cus = await db.Customers.SingleOrDefaultAsync(c => c.Id == id);
            return cus;
        }

        public async Task<IEnumerable<Customer>> GetALL()
        {
            var cusList = await db.Customers.ToListAsync();
            return cusList;
        }

        public async Task<IEnumerable<Customer>> SearchByName(string name)
        {
            var searchList = await db.Customers.Where(c => c.Name.Contains(name)).ToListAsync();
            return searchList;
        }
    }
}

