using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TravelBlog.Models
{
    [Table("Suggestions")]
    public class Suggestion
    {
        [Key]
        public int SuggestionId { get; set; }
        public string SuggestedCity { get; set; }
        public string SuggestedCountry { get; set; }
        public string Description { get; set; }
    }
}
