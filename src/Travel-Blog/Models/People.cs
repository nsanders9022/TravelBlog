using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TravelBlog.Models
{
    [Table("Peoples")]
    public class People
    {
        [Key]
        public int PeopleId { get; set; }
        public string Name { get; set; }

        public ICollection<ExperiencePeople> ExperiencesPeoples { get; set; }
    }
}
