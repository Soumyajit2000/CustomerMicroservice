using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMicroservice.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }


        public string Name { get; set; }

        public string Address { get; set; }

        public string EmailId { get; set; }

        public string ContactNumber { get; set; }

        [ForeignKey("Requirement")]
        public int PropertyId { get; set; }
        public Requirement Requirement { get; set; }

    }
}
