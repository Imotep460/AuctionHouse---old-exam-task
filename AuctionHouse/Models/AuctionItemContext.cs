using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse.Models
{
    public class AuctionItemContext : DbContext
    {
        public DbSet<AuctionItem> Items { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public AuctionItemContext(DbContextOptions<AuctionItemContext>options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
