using Microsoft.AspNetCore.Mvc;
using MyApi.Data;
using MyApi.Models;

[ApiController]
[Route("api/[controller]")]
public class CartController : ControllerBase
{
    private readonly AppDbContext _context;

    public CartController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost("addToCart")]
    public async Task<IActionResult> AddToCart([FromBody] CartItem cartItem)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        // Optionally, you can validate the quantity here

        _context.CartItems.Add(cartItem);
        await _context.SaveChangesAsync();

        return Ok();
    }
}
