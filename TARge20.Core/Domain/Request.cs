using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TARge20.Core.Domain
{
    public class Request
    {
        [Key]
        public Guid RequestId { get; set; }

        public string Letter { get; set; }

        public DateTime DateTime { get; set; }

        public string Comment { get; set; }

        public Employee Employee { get; set; }


    }
}
