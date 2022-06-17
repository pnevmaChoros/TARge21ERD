using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TARge20.Core.Domain
{
    public class Report
    {
        [Key]
        public Guid ReportId { get; set; }

        public string Letter { get; set; }

        public DateTime Date { get; set; }

        public string Comment { get; set; }

        public Employee Employee { get; set; }

        public Office Office { get; set; }
    }
}
