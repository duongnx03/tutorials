using System;
using Exercise.NET.Models;

namespace Exercise.NET.IRepository
{
	public interface ICustomerRepo
	{
        Task<IEnumerable<Customer>> GetALL();

        Task<Customer> Get(int Id);

        Task<int> Edit(Customer customer);

        Task<int> Delete(int Id);

        Task<int> Create(Customer customer);

        Task<IEnumerable<Customer>> SearchByName(String name);
    }
}

