using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItransitionProject.Context
{
    class Comment
    {
        [Key]
        public int Id { get; set; }
        public String Text { get; set; }
        public int UserId { get; set; }
    }
}
