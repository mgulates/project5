using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace project5.Data
{
    public class Movies
    {
        public int Id { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? Category { get; set; }
        public string? ImageUrl { get; set; }
        
        }}