using Book.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Book
{
    public class BookDbContext:DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {
        }

        public DbSet<BookDetails> Books { get; set; }

        public async Task<List<BookDetails>> GetBooksByPublisher()
        {
            return await Books.FromSqlRaw("EXEC usp_sortbypublishernametitle")
                .ToListAsync();
        }

        public async Task<List<BookDetails>> GetBooksByAuthor()
        {
            return await Books.FromSqlRaw("EXEC usp_sortbynametitle")
                .ToListAsync();
        }
    }
}
