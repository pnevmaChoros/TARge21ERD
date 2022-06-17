using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TARge20.Core.Domain
{
    public class BorrowedStuff
    {
        [Key]
        public Guid BorrowedStuffId { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Comment { get; set; }

        public Employee Employee { get; set; }

        public Stuffs Stuff { get; set; }
    }
}
