using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse.Models
{
    public class AuctionItem
    {
        public long AuctionItemId { get; set; }
        public string ItemDescription { get; set; }
        public decimal RatingPrice{ get; set; }
        public decimal BidPrice { get; set; }
        public string BidCustomName { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime BidTimeStamp { get; set; }
    }
}
