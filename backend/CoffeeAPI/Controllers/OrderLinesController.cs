﻿using CoffeeAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoffeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
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
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var groupMembers = _context.Users
                .Where(u => u.UserId == userId)
                .Include(u => u.GroupMember)
                .ThenInclude(gm => gm.Members)
                .Select(u => u.GroupMember.Members)
                .Single();

            var groupOrderLines = _context.OrderLines
                .Where(o => groupMembers.Contains(o.Customer));

            if (orderstatus != "")
            {
                return groupOrderLines
                    .Where(d => d.OrderStatus.StatusName.ToLower() == orderstatus.ToLower())
                    .Include(d => d.Customer)
                    .Include(d => d.Drink)
                    .Include(d => d.OrderStatus);
            }
            else
            {
                return groupOrderLines;
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
            OrderStatus orderstatus = _context.OrderStatuses
              .Where(l => l.OrderStatusId == orderLine.OrderStatus.OrderStatusId)
              .Single();
            OrderLine updatedOrderline;

            if (orderLine.Server != null)
            {

                User server = _context.Users
                   .Where(l => l.UserId == orderLine.Server.UserId)
                   .Single();

                updatedOrderline = _context.OrderLines
                    .Where(l => l.OrderLineId == orderLine.OrderLineId)
                    .Include(d => d.Server)
                    .Include(d => d.OrderStatus)
                    .Single();
                updatedOrderline.GetTime = orderLine.GetTime;
                updatedOrderline.Server = server;
            }
            else
            {
                updatedOrderline = _context.OrderLines
                    .Where(l => l.OrderLineId == orderLine.OrderLineId)
                    .Include(d => d.OrderStatus)
                    .Single();
            }

            updatedOrderline.Count = orderLine.Count;
            updatedOrderline.OrderStatus = orderstatus;
            _context.OrderLines.Update(updatedOrderline);


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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userID = orderLine.Customer.UserId;
            User customer = _context.Users
               .Where(l => l.UserId == userID)
               .Single();

            Drink drink = _context.Drinks
               .Where(l => l.DrinkId == orderLine.Drink.DrinkId)
               .Single();

            OrderStatus orderstatus = _context.OrderStatuses
              .Where(l => l.StatusName.ToLower() == "ordered")
              .Single();

            for (int i = 0; i < orderLine.Count; i++)
            {
                var newOrderLine = new OrderLine
                {
                    OrderLineId = Guid.NewGuid(),
                    Customer = customer,
                    Drink = drink,
                    Count = 1,
                    Sugar = orderLine.Sugar,
                    Milk = orderLine.Milk,
                    OrderStatus = orderstatus,
                    OrderTime = orderLine.OrderTime
                };


                _context.OrderLines.Add(newOrderLine);
                await _context.SaveChangesAsync();


            }
            return Ok();
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