using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using Library.Data;

namespace Library.DB
{
    public class SQLCommands : IDatabaseCommands
    {
        private readonly string _connectionString;

        public SQLCommands(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                return await conn.QueryAsync<Book>("SELECT * FROM Book");
            }
        }

        public async Task<int> InsertBookAsync(Book book)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                return await conn.InsertAsync(book);
            }
        }

        public async Task<bool> UpdateBookAsync(Book book)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                return await conn.UpdateAsync(book);
            }
        }

        public async Task<bool> DeleteBookAsync(int bookId)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                return await conn.DeleteAsync(new Book { Id = bookId});
            }
        }
    }
}
