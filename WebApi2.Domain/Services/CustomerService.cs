using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApi2.Domain.Dtos;
using WebApi2.Domain.Entities;
using WebApi2.Domain.Repositories;

namespace WebApi2.Domain.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _iCustomerRepository;
        public CustomerService(ICustomerRepository iCustomerRepository)
        {
            _iCustomerRepository = iCustomerRepository;
        }
        public async Task<Customer> AddCustomerAsync(CustomerForAdd customerForAdd)
        {
            Customer customer = new Customer();
            customer.Name = customerForAdd.Name;
            customer.LastName = customerForAdd.LastName;
            customer.CityId = customerForAdd.CityId;
            _iCustomerRepository.Add(customer);
            await _iCustomerRepository.UnitOfWork.SaveChangesAsync();
            return customer;
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _iCustomerRepository.GetAll();
        }

        public async Task<Customer> GetAsync(int id)
        {
            return await _iCustomerRepository.GetSingleOrDefaultAsync(c => c.id == id);
        }

        public async Task<Customer> GetAsyncByName(string name)
        {
            return await _iCustomerRepository.GetSingleOrDefaultAsync(c => c.Name == name);
        }


        //public async Task<bool> DeleteAsync(int id)
        // {
        //     var customer = _iCustomerRepository.GetSingleOrDefaultAsync(c => c.id == id);
        //     if (customer == null)
        //         return false;

        //     return await _iCustomerRepository.Remove(customer);
        // }



    }
}
