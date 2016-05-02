using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItransitionProject.Context
{
    class User
    {
        [Key]
        public int Id { get; set; }
        public String name { get; set; }
        public Achievment Achievments { get; set; }
        public Role Role;
    }
}
