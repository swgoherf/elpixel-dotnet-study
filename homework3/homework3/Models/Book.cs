using System;
using System.Collections.Generic;
using System.Text;

namespace homework3.Models;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }
    public int Pages { get; set; }
    public bool IsAvailable { get; set; }
}

