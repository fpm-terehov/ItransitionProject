using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItransitionProject.Context
{
    class Achievment
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Reference { get; set; }
    }
}
