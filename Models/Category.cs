namespace project5.Models
{
	public class Category
	{
		public long ID { get; set; }
		public string CategoryName { get; set; }
		public string CategoryDescription { get; set; }
		public List<ContentCategory> ContentCategories { get; set; }
	}
}
