using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorRoseNoirApp.Server.Data;
using BlazorRoseNoirApp.Shared;
using Microsoft.AspNetCore.Authorization;

namespace BlazorRoseNoirApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
	public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
		[AllowAnonymous]
		public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            if (_context.Products == null)
            {
                return NotFound();
            }
            
            return Ok(await _context.Products.Include(p => p.Variations).ToListAsync());
        }

		// GET: api/Products/5
		[HttpGet("{id}")]
		[AllowAnonymous]
		public async Task<ActionResult<Product>> GetProduct(int id)
		{
			if (_context.Products == null)
			{
				return NotFound();
			}

			var product = await _context.Products.FindAsync(id);

			if (product == null)
			{
				return NotFound();
			}

			return Ok(product);
		}

		// GET: api/Products
		//[HttpGet("{category}")]
		//[AllowAnonymous]
		//public async Task<ActionResult<IEnumerable<Product>>> GetProducts(Categories category)
		//{
		//    if (_context.Products == null)
		//    {
		//        return NotFound();
		//    }

		//    return await _context.Products
		//        .Where(p => p.Category == category).ToListAsync();
		//}

		// PUT: api/Products/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.ProductId)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
          if (_context.Products == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Products'  is null.");
          }
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (_context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductExists(int id)
        {
            return (_context.Products?.Any(e => e.ProductId == id)).GetValueOrDefault();
        }
    }
}
