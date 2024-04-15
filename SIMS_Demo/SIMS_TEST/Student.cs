using Xunit;
using Microsoft.AspNetCore.Mvc;
using SIMS_Demo.Controllers;
using SIMS_Demo.Models;
using System.Collections.Generic;

namespace SIMS_TEST
{
    public class StudentControllerTests
    {
        [Fact]
        public void Index_ShouldReturnCorrectNumberOfStudents()
        {
            // Arrange
            var controller = new StudentController();

            // Act
            var result = controller.Index() as ViewResult;
            var students = result.Model as List<Student>;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(3, students.Count);
        }
    }
}
