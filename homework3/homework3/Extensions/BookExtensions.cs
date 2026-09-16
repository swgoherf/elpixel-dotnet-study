using homework3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace homework3.Extensions;

public static class BookExtensions
{
    public static IEnumerable<Book> ByGenre(this IEnumerable<Book> books, string genre)
    {
        return books.Where(b => b.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase));
    }
}

