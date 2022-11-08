using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Entities
{
    public class TStudent
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
    }
}
