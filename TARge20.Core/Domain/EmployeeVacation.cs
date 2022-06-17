using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TARge20.Core.Domain
{
    public class EmployeeVacation
    {
        [Key]
        public Guid EmployeeVacationId { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime EndDate { get; set; }

        public Employee Employee { get; set; }

        public Vacation Vacation { get; set; }
    }
}
