using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace project5.Models
{
    public class Content
    {
        public int Id { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string contentType { get; set; }
        public List<ContentCategory> ContentCategories { get; set; }
        public string? ImageUrl { get; set; }

        public List<Review> Reviews { get; set; }

    }
}