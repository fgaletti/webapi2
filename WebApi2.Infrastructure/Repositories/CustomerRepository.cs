using System;
using System.Collections.Generic;
using System.Text;
using WebApi2.Domain.Entities;
using WebApi2.Domain.Repositories;

namespace WebApi2.Infrastructure.Repositories
{
   public  class CustomerRepository : Repository<Customer>, ICustomerRepository

    {

        private DataContext _appContext => (DataContext)_context;

        public CustomerRepository(DataContext context) : base(context)
        {

        }

    }
}
