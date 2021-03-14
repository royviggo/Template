using System.Collections.Generic;
using Template.Domain.Entities;

namespace Template.Data.Data
{
    internal class BookData
    {
        internal static IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Isbn = "9781492056812",
                    Title = "Programming C# 8.0: Build Cloud, Web, and Desktop Applications",
                    Author = "Ian Griffiths",
                    Binding = "Paperback",
                    Language = "English",
                    Publisher = "O'Reilly Media",
                    EditionNumber = 1,
                    PublishedYear = 2020,
                    NumberOfPages = 800,
                },
                new Book
                {
                    Id = 2,
                    Isbn = "9781617294273",
                    Title = ".NET Core in Action",
                    Author = "Dustin Metzgar",
                    Binding = "Paperback",
                    Language = "English",
                    Publisher = "Manning Publications",
                    EditionNumber = 1,
                    PublishedYear = 2018,
                    NumberOfPages = 288,
                },
                new Book
                {
                    Id = 3,
                    Isbn = " 9781800568105",
                    Title = "C# 9 and .NET 5 - Modern Cross-Platform Development",
                    Author = "Mark J. Price",
                    Binding = "Paperback",
                    Language = "English",
                    Publisher = "Packt Publishing",
                    EditionNumber = 5,
                    PublishedYear = 2020,
                    NumberOfPages = 822,
                },
                new Book
                {
                    Id = 4,
                    Isbn = "9781617294532",
                    Title = "C# in Depth",
                    Author = "Jon Skeet",
                    Binding = "Paperback",
                    Language = "English",
                    Publisher = "Manning Publications",
                    EditionNumber = 4,
                    PublishedYear = 2019,
                    NumberOfPages = 528,
                },
                new Book
                {
                    Id = 5,
                    Isbn = "9781617294563",
                    Title = "Entity Framework Core in Action",
                    Author = "Jon P Smith",
                    Binding = "Paperback",
                    Language = "English",
                    Publisher = "Manning Publications",
                    EditionNumber = 1,
                    PublishedYear = 2018,
                    NumberOfPages = 520,
                },
                new Book
                {
                    Id = 6,
                    Isbn = "9780134494166",
                    Title = "Clean Architecture: A Craftsman's Guide to Software Structure and Design",
                    Author = "Robert Martin",
                    Binding = "Paperback",
                    Language = "English",
                    Publisher = "Pearsons",
                    EditionNumber = 1,
                    PublishedYear = 2017,
                    NumberOfPages = 432,
                },
            };
        }
    }
}
