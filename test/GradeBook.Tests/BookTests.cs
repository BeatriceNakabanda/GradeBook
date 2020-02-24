using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void CalculatesGrades()
        {
           //arrange
           var book = new Book("");
           book.AddGrade(90.2);
           book.AddGrade(50.5);
           book.AddGrade(70.8);

           //act
           var result = book.GetStatistics(); //actual

           //assert
           //Assert.Equal(expected, actual)
           Assert.Equal(70.5, result.Average);
           Assert.Equal(90.2, result.High);
           Assert.Equal(50.5, result.Low);
           Assert.Equal('C', result.Letter);
        }
    }
}
