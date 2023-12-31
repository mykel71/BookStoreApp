﻿namespace BookStoreApp.Api.Models;

public class Book
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public int Year { get; set; }
    public string? ISBN { get; set; }
    public string? Summary { get; set; }
    public decimal Price { get; set; }
    public int AuthorId { get; set; }

    public ICollection<Book>? Books { get; set;}
}
