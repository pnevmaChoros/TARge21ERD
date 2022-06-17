using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Job
    {
        [Key]
        public Guid JobId { get; set; }

        public string JobTitle { get; set; }

        public string JobDescription { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
