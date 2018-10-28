using System;
using Dapper.Contrib.Extensions;

namespace Library.Data
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public DateTime PublishDate { get; set; }
        
        public DateTime PurchaseDate { get; set; }
    }
}
