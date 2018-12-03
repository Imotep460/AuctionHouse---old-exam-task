using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse.Models
{
    public class Bid
    {
        [ForeignKey("AuctionItem")]
        public long AuctionItemId { get; set; }
        public decimal Price { get; set; }
        public string CustomName { get; set; }
        public string CustomPhone { get; set; }
    }
}
