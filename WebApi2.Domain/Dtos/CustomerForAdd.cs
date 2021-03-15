using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi2.Domain.Dtos
{
     public class CustomerForAdd
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int CityId { get; set; }
    }
}

