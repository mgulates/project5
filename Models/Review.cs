using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace project5.Models
{
    public class Review
	{
		public long ReviewId { get; set; }
		public string? userID	{ get; set; }
		[ForeignKey("userID")]
		public IdentityUser ReviewerName { get; set; }
		public string ReviewTitle { get; set; } = string.Empty;
		public string ReviewDescription { get; set; } = string.Empty;
		public int Rating { get; set; }

		public int contentID { get; set; }
		public Content Content { get; set; }	
	}
}
