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
        public override bool Equals(System.Object otherSuggestion)
        {
            if (!(otherSuggestion is Suggestion))
            {
                return false;
            }
            else
            {
                Suggestion newSuggestion = (Suggestion)otherSuggestion;
                return this.SuggestionId.Equals(newSuggestion.SuggestionId);
            }
        }

        public override int GetHashCode()
        {
            return this.SuggestionId.GetHashCode();
        }


        [Key]
        public int SuggestionId { get; set; }
        public string SuggestedCity { get; set; }
        public string SuggestedCountry { get; set; }
        public string Description { get; set; }
    }
}
