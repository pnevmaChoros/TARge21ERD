using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TARge20.Core.Domain
{
    public class AccessRight
    {
        [Key]
        public Guid AccessRightId { get; set; }

        public Employee Employee { get; set; }

        public Access Access { get; set; }
    }
}
