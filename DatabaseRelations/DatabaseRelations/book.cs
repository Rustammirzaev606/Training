using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DatabaseRelations
{
    public class book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        [Key]
        public int Code { get; set; }
    }

    public class Store
    {
        [Key]
        public int StoreID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual List<Stock> Inventory { get; set; }
    }

    public class Stock
    {
        [Key]
        public int StockID { get; set; }
        public int OnHand { get; set; }
        public int OnOrder { get; set; }
        public virtual book Item { get; set; }
    }

    public class BookContext : DbContext  //creating DB?  dbContext = Database
    {
        public DbSet<book> Books { get; set; }  //table books DbSet = table
        public DbSet<Store> Stores { get; set; } //table stores DbSet = table
        public DbSet<Stock> Stocks { get; set; } //table stocks DbSet = table

    }
    
}
