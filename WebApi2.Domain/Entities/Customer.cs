using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebApi2.Domain.Entities
{
    public class Customer
    {
        public int id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

    }
}
