using homework3.Extensions;
using homework3.Models;

var books = new List<Book>
{
    new Book { Title = "Книга 1", Author = "Автор 1", Genre = "Жанр 1", Year = 2000, Pages = 100, IsAvailable = true },
    new Book { Title = "Книга 2", Author = "Автор 1", Genre = "Жанр 1", Year = 2005, Pages = 150, IsAvailable = true },
    new Book { Title = "Книга 3", Author = "Автор 2", Genre = "Жанр 1", Year = 2010, Pages = 200, IsAvailable = false },
    new Book { Title = "Книга 4", Author = "Автор 2", Genre = "Жанр 2", Year = 2015, Pages = 250, IsAvailable = true },
    new Book { Title = "Книга 5", Author = "Автор 3", Genre = "Жанр 2", Year = 2020, Pages = 300, IsAvailable = true }
};

var chainMethod = books
            .ByGenre("Жанр 1")
            .Where(b => b.IsAvailable)
            .OrderBy(b => b.Year)
            .ToList();

var chainQuery = (from b in books.ByGenre("Жанр 1")
                  where b.IsAvailable
                  orderby b.Year
                  select b).ToList();

var countByGenre = books
            .GroupBy(b => b.Genre)
            .Select(g => new { Genre = g.Key, Count = g.Count() });

var avgYear = books
            .GroupBy(b => b.Author)
            .Select(g => new { Author = g.Key, AvgYear = g.Average(b => b.Year) });

var bigBook = books
            .GroupBy(b => b.Genre)
            .Select(g => new { Genre = g.Key, ThickestBook = g.OrderByDescending(b => b.Pages).First() });