using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact] //behaviour of a method
        public void csharpIsPassedByRef()
        {
           //arrange
           var book1 = GetBook("Book 1"); 
           //act
           GetBookSetName(ref book1, "New name");
           //assert
           Assert.Equal("New name", book1.Name);

        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
            
        }
        [Fact] //behaviour of a method
        public void csharpIsPassedByValue()
        {
           //arrange
           var book1 = GetBook("Book 1"); 
           GetBookSetName(book1, "New name");
           //assert
           Assert.Equal("Book 1", book1.Name);

        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
            
        }
        //updating book name
        [Fact] //behaviour of a method
        public void CanSetNameFromReference()
        {
           //arrange
           var book1 = GetBook("Book 1"); 
           // act
           SetName(book1, "New name");
           //assert
           Assert.Equal("New name", book1.Name);

        }

        private void SetName(Book book, string name)
        {
            // book.Name should be equal to the incomming parameter  
            book.Name = name;
        }

        [Fact] //behaviour of a method
        public void GetBookReturnsDifferentObjects()
        {
           //arrange
           var book1 = GetBook("Book 1");  
           var book2 = GetBook("Book 2");  


           //assert
           Assert.Equal("Book 1", book1.Name);
           Assert.Equal("Book 2", book2.Name);

        }
        [Fact] //behaviour of a method
        public void TwoVarsCanReferenceSameObject()
        {
           //arrange
           var book1 = GetBook("Book 1");  
           var book2 = book1;  


           //assert
           Assert.Same(book1, book2);

        }

        //Book describes the return type
        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
