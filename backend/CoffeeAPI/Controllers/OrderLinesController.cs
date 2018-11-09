using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoffeeAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace CoffeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderLinesController : ControllerBase
    {
        private readonly CoffeeContext _context;

        public OrderLinesController(CoffeeContext context)
        {
            _context = context;
        }

        // GET: api/OrderLines
        [HttpGet]
        public IEnumerable<OrderLine> GetOrderLines(string orderstatus = "")
        {
            if (orderstatus != "")
            {
                return _context.OrderLines.Where(d => d.OrderStatus.StatusName.ToLower() == orderstatus.ToLower()).Include(d => d.Customer).Include(d => d.Drink).Include(d => d.OrderStatus);
            }
            else
            { 
                return _context.OrderLines;
            }
        }

        // GET: api/OrderLines/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderLine([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var orderLine = await _context.OrderLines.FindAsync(id);

            if (orderLine == null)
            {
                return NotFound();
            }

            return Ok(orderLine);
        }

        // PUT: api/OrderLines/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderLine([FromRoute] Guid id, [FromBody] OrderLine orderLine)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != orderLine.OrderLineId)
            {
                return BadRequest();
            }

            _context.Entry(orderLine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderLineExists(id))
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

        // POST: api/OrderLines
        [HttpPost]
        public async Task<IActionResult> PostOrderLine([FromBody] OrderLine orderLine)
        {
            var userID = orderLine.Customer.UserId;           
            User customer = _context.Users
               .Where(l => l.UserId == userID)
               .Single();

            Drink drink = _context.Drinks
               .Where(l => l.DrinkId == orderLine.Drink.DrinkId)
               .Single();

            OrderStatus orderstatus = _context.OrderStatuses
              .Where(l => l.OrderStatusId == orderLine.OrderStatus.OrderStatusId)
              .Single();

            var newOrderLine = new OrderLine
            {
                OrderLineId = Guid.NewGuid(),
                Customer = customer,
                Drink = drink,
                Count = orderLine.Count,
                Sugar = orderLine.Sugar,
                Milk = orderLine.Milk,
                OrderStatus = orderstatus,
                OrderTime = orderLine.OrderTime
            };

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.OrderLines.Add(newOrderLine);
            await _context.SaveChangesAsync();

            return Ok(newOrderLine.OrderLineId);
        }

        // DELETE: api/OrderLines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderLine([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var orderLine = await _context.OrderLines.FindAsync(id);
            if (orderLine == null)
            {
                return NotFound();
            }

            _context.OrderLines.Remove(orderLine);
            await _context.SaveChangesAsync();

            return Ok(orderLine);
        }

        private bool OrderLineExists(Guid id)
        {
            return _context.OrderLines.Any(e => e.OrderLineId == id);
        }
    }
}