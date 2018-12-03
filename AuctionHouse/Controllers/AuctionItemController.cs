using AuctionHouse.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouse.Controllers
{
    [Route("api/AuctionItems")]
    [ApiController]
    public class AuctionItemController : ControllerBase
    {
        private readonly AuctionItemContext _context;

        public AuctionItemController(AuctionItemContext context)
        {
            _context = context;
        }

        //Get api/AuctionItems
        [HttpGet]
        public IEnumerable<AuctionItem> GetAuctionItems()
        {
            return _context.Items;
        }

        //POST api/<controller>
        [HttpPost]
        public IActionResult PostAuctionItem([FromBody] AuctionItem auctionItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Items.Add(auctionItem);
            _context.SaveChangesAsync();
            return CreatedAtAction("GetAuctionItem", new { auctionItem.AuctionItemId }, auctionItem);
        }

    }
}
