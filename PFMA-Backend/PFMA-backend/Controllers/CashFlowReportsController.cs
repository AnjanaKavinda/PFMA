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
    public class CashFlowReportsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CashFlowReportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CashFlowReports
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CashFlowReport>>> GetCashFlowReports()
        {
            return await _context.CashFlowReports.ToListAsync();
        }

        // GET: api/CashFlowReports/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CashFlowReport>> GetCashFlowReport(int id)
        {
            var cashFlowReport = await _context.CashFlowReports.FindAsync(id);

            if (cashFlowReport == null)
            {
                return NotFound();
            }

            return cashFlowReport;
        }

        // PUT: api/CashFlowReports/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCashFlowReport(int id, CashFlowReport cashFlowReport)
        {
            if (id != cashFlowReport.ReportId)
            {
                return BadRequest();
            }

            _context.Entry(cashFlowReport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CashFlowReportExists(id))
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

        // POST: api/CashFlowReports
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CashFlowReport>> PostCashFlowReport(CashFlowReport cashFlowReport)
        {
            _context.CashFlowReports.Add(cashFlowReport);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCashFlowReport", new { id = cashFlowReport.ReportId }, cashFlowReport);
        }

        // DELETE: api/CashFlowReports/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCashFlowReport(int id)
        {
            var cashFlowReport = await _context.CashFlowReports.FindAsync(id);
            if (cashFlowReport == null)
            {
                return NotFound();
            }

            _context.CashFlowReports.Remove(cashFlowReport);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CashFlowReportExists(int id)
        {
            return _context.CashFlowReports.Any(e => e.ReportId == id);
        }
    }
}
