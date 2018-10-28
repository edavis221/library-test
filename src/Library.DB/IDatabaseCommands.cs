using Library.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.DB
{
    public interface IDatabaseCommands
    {

        Task<IEnumerable<Book>> GetBooksAsync();

        Task<int> InsertBookAsync(Book book);

        Task<bool> UpdateBookAsync(Book book);

        Task<bool> DeleteBookAsync(int bookId);
    }
}
