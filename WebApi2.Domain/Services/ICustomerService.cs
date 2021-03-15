using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApi2.Domain.Dtos;
using WebApi2.Domain.Entities;

namespace WebApi2.Domain.Services
{
    public interface ICustomerService
    {
        Task<Customer> AddCustomerAsync(CustomerForAdd customer);
        Task<IEnumerable<Customer>> GetAllAsync();
        Task<Customer> GetAsync(int id);
        Task<Customer> GetAsyncByName(string name);

        //Task<bool> DeleteAsync(int id);
    }
}
