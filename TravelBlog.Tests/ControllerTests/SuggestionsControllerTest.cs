using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelBlog.Controllers;
using TravelBlog.Models;
using Xunit;

namespace TravelBlog.Tests
{
    public class SuggestionsControllerTest
    {
        //Tests that Index is returned correctly from Controller
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            SuggestionsController controller = new SuggestionsController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        //Tests that index returns list of Suggestion types
        [Fact]
        public void Get_ModelList_Index_Test()
        {
            //Arrange
            SuggestionsController controller = new SuggestionsController();
            IActionResult actionResult = controller.Index();
            ViewResult indexView = controller.Index() as ViewResult;
            //ViewResult indexView = new SuggestionsController().Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsType<List<Suggestion>>(result);
        }

        [Fact]
        public void Post_MethodAddsItem_Test()
        {
            // Arrange
            SuggestionsController controller = new SuggestionsController();
            Suggestion testSuggestion = new Suggestion();
            testSuggestion.Description = "test suggestion";

            // Act
            controller.Create(testSuggestion);
            ViewResult indexView = new SuggestionsController().Index() as ViewResult;
            var collection = indexView.ViewData.Model as IEnumerable<Suggestion>;

            // Assert
            Assert.Contains<Suggestion>(testSuggestion, collection);
        }
    }
}
