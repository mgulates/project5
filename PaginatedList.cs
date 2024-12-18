namespace project5
{
    public class PaginatedList<T>:List<T>
    {
        public int pageIndex { get; set; }
        public int totalPages { get; set; }

        public PaginatedList(List<T> list,int itemCount,int pageIndex,int pageSize)
        {
            this.pageIndex = pageIndex;
            totalPages = (int)Math.Ceiling((double)itemCount / pageSize);

            this.AddRange(list);
        }

        public bool hasPrev => pageIndex > 1;
        public bool hasNext => pageIndex < totalPages;

        public static List<T> getlist(List<T> list,int pageIndex,int pageSize)
        {
            var itemCount = list.Count;
            var newlist = list.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new PaginatedList<T>(newlist,itemCount,pageIndex,pageSize);

        }
    }
}
