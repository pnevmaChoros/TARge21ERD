using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TARge20.Core.Domain
{
    public class Stuffs
    {
        [Key]
        public Guid StuffId { get; set; }

        public string Stuff { get; set; }

        public string Description { get; set; }

        public string Comment { get; set; }
    }
}
