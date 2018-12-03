using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse.Models
{
    public class AuctionItem
    {
        [Key]
        public long AuctionItemId { get; set; }
        public string ItemDescription { get; set; }
        public decimal RatingPrice{ get; set; }
        public decimal BidPrice { get; set; }
        public string BidCustomName { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime BidTimeStamp { get; set; }
    }
}
