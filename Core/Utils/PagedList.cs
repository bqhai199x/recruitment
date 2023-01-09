namespace Recruitment.Core.Utils
{
    public class PagedList<T> : List<T>
    {
        public PagedList() { }

        public MetaData MetaData { get; set; } = new();

        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            MetaData = new MetaData
            {
                TotalCount = count,
                PageSize = pageSize,
                CurrentPage = pageNumber,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize)
            };
            AddRange(items);
        }

        public static PagedList<T> ToPagedList(IEnumerable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var items = source
              .Skip((pageNumber - 1) * pageSize)
              .Take(pageSize).ToList();
            return new PagedList<T>(items, count, pageNumber, pageSize);
        }
    }

    public class MetaData
    {
        public int CurrentPage { get; set; } = 0;

        public int TotalPages { get; set; } = 0;

        public int PageSize { get; set; } = 0;

        public int TotalCount { get; set; } = 0;

        public bool HasPrevious => CurrentPage > 1;

        public bool HasNext => CurrentPage < TotalPages;
    }

    public class PagingResponse<T> where T : class
    {
        public List<T> Items { get; set; } = new();

        public MetaData MetaData { get; set; } = new();
    }
}
