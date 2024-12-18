using project5.Data;

namespace project5.Models
{
	public class Review
	{
		public long ReviewId { get; set; }
		public string ReviewerName { get; set; } = string.Empty;
		public string ReviewTitle { get; set; } = string.Empty;
		public string ReviewDescription { get; set; } = string.Empty;
		public int Rating { get; set; }

		public int contentID { get; set; }
		public Content Content { get; set; }	
	}
}
