using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TARge20.Core.Domain
{
    public class Company
    {
        [Key]
        public Guid CompanyId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string RedisterNumber { get; set; }

        public string Location { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }
        
        public string Email { get; set; }

        public string Owner { get; set; }

        public string Comment { get; set; }
    }
}
