using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelBlog.Models;
using Xunit;

namespace TravelBlog.Tests
{
    public class SuggestionTest
    {
        public SuggestionTest()
        {
        }

        [Fact]
        public void GetDescriptionTest()
        {
            //Arrange
            var suggestion = new Suggestion();
            suggestion.Description = "Go hiking and wine tasting";

            //Act
            var result = suggestion.Description;

            //Assert
            Assert.Equal("Go hiking and wine tasting", result);
        }
    }
}
