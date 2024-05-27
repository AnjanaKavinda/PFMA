using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PFMA.Core.Entities;
using PFMA.Infrastructure.Data;

namespace PFMA_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavingsAccountsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SavingsAccountsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SavingsAccounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SavingsAccount>>> GetSavingsAccounts()
        {
            return await _context.SavingsAccounts.ToListAsync();
        }

        // GET: api/SavingsAccounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SavingsAccount>> GetSavingsAccount(int id)
        {
            var savingsAccount = await _context.SavingsAccounts.FindAsync(id);

            if (savingsAccount == null)
            {
                return NotFound();
            }

            return savingsAccount;
        }

        // PUT: api/SavingsAccounts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSavingsAccount(int id, SavingsAccount savingsAccount)
        {
            if (id != savingsAccount.AccountId)
            {
                return BadRequest();
            }

            _context.Entry(savingsAccount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SavingsAccountExists(id))
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

        // POST: api/SavingsAccounts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SavingsAccount>> PostSavingsAccount(SavingsAccount savingsAccount)
        {
            _context.SavingsAccounts.Add(savingsAccount);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSavingsAccount", new { id = savingsAccount.AccountId }, savingsAccount);
        }

        // DELETE: api/SavingsAccounts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSavingsAccount(int id)
        {
            var savingsAccount = await _context.SavingsAccounts.FindAsync(id);
            if (savingsAccount == null)
            {
                return NotFound();
            }

            _context.SavingsAccounts.Remove(savingsAccount);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SavingsAccountExists(int id)
        {
            return _context.SavingsAccounts.Any(e => e.AccountId == id);
        }
    }
}
