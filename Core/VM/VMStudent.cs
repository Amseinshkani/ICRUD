using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.VM
{
    public class VMStudent
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
    }
}
