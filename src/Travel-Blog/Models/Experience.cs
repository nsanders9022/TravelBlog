using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TravelBlog.Models
{
    [Table("Experiences")]
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }
        public string Description { get; set; }
        public int PlaceId { get; set; }
        public virtual Place Place { get; set; }

        public ICollection<ExperiencePeople> ExperiencesPeoples { get; set; }

    }
}
