using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
}

public class MovieYearViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Year { get; set; }
    public string? MovieYear { get; set; }
    public string? SearchString { get; set; }
}