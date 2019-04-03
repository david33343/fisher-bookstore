using System;
using Xunit;
using Fisher.Bookstore.Models;
using System.Collections.Generic;

namespace tests
{
    public class AuthorTest
    {
        [Fact]
        public void ChangeAuthorName()
        {
            //Arrange
            var author1 = new Author()
            {
                Name = "David"
            };

            //Act
            var aName = "David";
            author1.ChangeAuthorName(aName);

            //Assert
            Assert.Equal(author1.Name,aName);
        }

        [Fact]
        public void CheckForBookTitle()
        {
            //Arrange
            var author1 = new Author()
            {
                Name = "David",
                Titles = new List<Book>()
            };
            var book1 = new Book()
            {
                Id = 1,
                Title = "Domain Driven Design",
                Publisher = "McGraw-Hill"
            };
            var book2 = new Book()
            {
                Id = 2,
                Title = "Not Domain Driven Design",
                Publisher = "Not McGraw-Hill"
            };
            author1.Titles.Add(book1);
            author1.Titles.Add(book2);

            //Act
            var checkBook = "N/A";
            var newbook = "Not Domain Driven Design";
            if (author1.Titles.Contains(book2)){
                if (book2.Title == newbook)
                {
                    checkBook = "Not Domain Driven Design";
                }
            }
            //Assert
            Assert.Equal(newbook,checkBook);
        }
    }
    
}