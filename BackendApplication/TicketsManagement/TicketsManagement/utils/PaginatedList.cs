using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;

namespace TicketsManagement.utils
{
    public class PaginatedList<T>:List<T>
    {
        public int pageNumber { get; private set; }
        public int totalPages { get; private set; }
        public bool hasPreviousPage => pageNumber > 1;
        public bool hasNextPage => pageNumber < totalPages;

        public PaginatedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            pageNumber = pageNumber;
            totalPages = (int)Math.Ceiling(count / (double)pageSize);
            this.AddRange(items);
        }


        public static async Task<PaginatedList<T>> paginate(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = await source.CountAsync(); 
            var items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PaginatedList<T>(items, count, pageNumber, pageSize);
        }
    }
}
