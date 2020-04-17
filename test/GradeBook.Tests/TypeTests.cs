using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string naam = "Scott";
            var upper = MakeUppercase(naam);

            Assert.Equal("Scott", naam);
            Assert.Equal("SCOTT", upper);

        }

        private string MakeUppercase(string par)
        {
            return par.ToUpper();
        }

        [Fact]
        public void ValueTypeCanAlsoBePassByReference()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(43, x);
        }
        private void SetInt(ref int x)
        {
            x = 43;
        }

        [Fact]
        public void ValueTypeAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(x);

            Assert.Equal(3, x);
        }
        private void SetInt(int x)
        {
            x = 43;
        }
        private int GetInt()
        {
            return 3;
        }
        
        [Fact]
        public void CSharpCanPassByReference()
        {
            // arrange
            var book1 = GetBook("Book 1");    
            GetBookSetName(ref book1, "New Name"); // out
            // act

            // assert
            Assert.Equal("New Name", book1.Naam);
        }

        private void GetBookSetName(/*out*/ref Book book, string naam)
        {
            book = new Book(naam); // when you use out then the function needs to how a initialzer like this line.
        }
        
        [Fact]
        public void CSharpIsPassByValue()
        {
            // arrange
            var book1 = GetBook("Book 1");    
            GetBookSetName(book1, "New Name");
            // act

            // assert
            Assert.Equal("Book 1", book1.Naam);
        }

        private void GetBookSetName(Book book, string naam)
        {
            book = new Book(naam);
        }

        [Fact]
        public void CanBookSetNaam()
        {
            // arrange
            var book1 = GetBook("Book 1");    
            SetName(book1, "New Name");
            // act

            // assert
            Assert.Equal("New Name", book1.Naam);
        }

        private void SetName(Book book, string naam)
        {
            book.Naam = naam;
        }
        
        [Fact]
        public void GetBoolRetrunDifferentObjects()
        {
            // arrange
            var book1 = GetBook("Book 1");    
            var book2 = GetBook("Book 2");            

            // act

            // assert
            Assert.Equal("Book 1", book1.Naam);
            Assert.Equal("Book 2", book2.Naam);
            Assert.NotSame(book1, book2);
            Assert.False(Object.ReferenceEquals(book1, book2));
        }

        [Fact]
        public void TwoVarsCanReferenceSameobjects()
        {
            // arrange
            var book1 = GetBook("Book 1");    
            var book2 = book1;            

            // act

            // assert
            Assert.Equal("Book 1", book1.Naam);
            Assert.Equal("Book 1", book2.Naam);
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }
        
        Book GetBook(string naam)
        {
            return new Book(naam);
        }
    }

}
