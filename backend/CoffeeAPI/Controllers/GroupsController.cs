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
    public class GroupsController : ControllerBase
    {
        private readonly CoffeeContext _context;

        public GroupsController(CoffeeContext context)
        {
            _context = context;
        }

        // GET: api/Groups
        [HttpGet]
        public IEnumerable<Group> GetGroups()
        {
            return _context.Groups;
        }

        // GET: api/Groups/member-group
        [HttpGet("member-group")]
        public IActionResult GetMemberGroup()
        {
            Group group;
            try
            {
                var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                group = _context.Users
                    .Where(u => u.UserId == userId)
                    .Include(u => u.GroupMember)
                    .Select(u => u.GroupMember)
                    .Single();
            }
            catch
            {
                return NotFound();
            }

            return Ok(group);
        }

        // GET: api/Groups/my-group
        [HttpGet("my-group")]
        public IActionResult GetMyGroup()
        {
            Group group;
            try
            {
                var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                group = _context.Users
                    .Where(u => u.UserId == userId)
                    .Include(u => u.GroupOwner)
                    .Select(u => u.GroupOwner)
                    .Single();
            }
            catch
            {
                return NotFound();
            }

            return Ok(group);
        }

        // GET: api/Groups/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGroup([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var @group = await _context.Groups.FindAsync(id);

            if (@group == null)
            {
                return NotFound();
            }

            return Ok(@group);
        }

        // PUT: api/Groups/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroup([FromRoute] Guid id, [FromBody] Group @group)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != @group.GroupId)
            {
                return BadRequest();
            }

            _context.Entry(@group).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupExists(id))
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

        // POST: api/Groups
        [HttpPost]
        public async Task<IActionResult> PostGroup([FromBody] Group @group)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Groups.Add(@group);
            await _context.SaveChangesAsync();

            return Ok(group.GroupId);
        }

        // DELETE: api/Groups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGroup([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var @group = await _context.Groups.FindAsync(id);
            if (@group == null)
            {
                return NotFound();
            }

            _context.Groups.Remove(@group);
            await _context.SaveChangesAsync();

            return Ok(@group);
        }

        private bool GroupExists(Guid id)
        {
            return _context.Groups.Any(e => e.GroupId == id);
        }
    }
}