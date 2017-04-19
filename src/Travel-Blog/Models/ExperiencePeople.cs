using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TravelBlog.Models
{
    public class ExperiencePeople
    {
        [Key]
        public int PeopleId { get; set; }
        public virtual People People { get; set; }

        public int ExperienceId { get; set; }
        public virtual Experience Experience { get; set; }
    }
}
