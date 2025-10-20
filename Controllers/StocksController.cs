using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IOMS.Data;
using IOMS.Models;

namespace IOMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly IomsDbContext _context;

        public StocksController(IomsDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StockTransaction>>> GetStocks()
        {
            return await _context.Stocks
                .Include(s => s.Product)
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StockTransaction>> GetStock(int id)
        {
            var stock = await _context.Stocks
                .Include(s => s.Product)
                .FirstOrDefaultAsync(s => s.ProductId == id);

            if (stock == null)
                return NotFound();

            return stock;
        }

        [HttpPost]
        public async Task<ActionResult<StockTransaction>> PostStock(StockTransaction stock)
        {
            _context.Stocks.Add(stock);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetStock), new { id = stock.StockTransactionId }, stock);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutStock(int id, StockTransaction stock)
        {
            if (id != stock.StockTransactionId)
                return BadRequest();

            _context.Entry(stock).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStock(int id)
        {
            var stock = await _context.Stocks.FindAsync(id);
            if (stock == null)
                return NotFound();

            _context.Stocks.Remove(stock);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
