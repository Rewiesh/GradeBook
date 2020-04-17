using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalcultateAnAverageGrade()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.1);
            book.AddGrade(77.1);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(85.4, result.Average, 1);
            Assert.Equal(90.1, result.High, 1);
            Assert.Equal(77.1, result.Low, 1);
            Assert.Equal('B', result.Letter);
        }
    }
}
