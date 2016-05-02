using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItransitionProject.Context
{
    class Comics
    {
        [Key]
        public int Id { get; set; }
        public Template Template { get; set; }
        public User User { get; set; }
        public virtual List<Tag> Tags { get; set; }        
        public String Name { get; set; }
        public String MediaContent { get; set; }
        public String Text { get; set; }
        public int Rating { get; set; }

    }
}
