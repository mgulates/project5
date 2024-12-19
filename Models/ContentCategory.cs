namespace project5.Models
{
    public class ContentCategory
    {
        public int Id { get; set; }
        public int ContentID { get; set; }

        public Content Content { get; set; }

        public long CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
