using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Product_repair_manager.Models;

namespace Product_repair_manager.Controllers
{
    public class damages_reportController : Controller
    {
        private readonly Product_repair_managerContext _context;

        public damages_reportController(Product_repair_managerContext context)
        {
            _context = context;
        }

        // GET: damages_report
        public async Task<IActionResult> Index()
        {
            return View(await _context.damages_report.ToListAsync());
        }

        // GET: damages_report/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var damages_report = await _context.damages_report
                .FirstOrDefaultAsync(m => m.damages_reportId == id);
            if (damages_report == null)
            {
                return NotFound();
            }

            return View(damages_report);
        }

        // GET: damages_report/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: damages_report/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("damages_reportId,UserId,fixed_report,item_status,ClassId,Item_date,item_damages_id")] damages_report damages_report)
        {
            if (ModelState.IsValid)
            {
                _context.Add(damages_report);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(damages_report);
        }

        // GET: damages_report/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var damages_report = await _context.damages_report.FindAsync(id);
            if (damages_report == null)
            {
                return NotFound();
            }
            return View(damages_report);
        }

        // POST: damages_report/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("damages_reportId,UserId,fixed_report,item_status,ClassId,Item_date,item_damages_id")] damages_report damages_report)
        {
            if (id != damages_report.damages_reportId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(damages_report);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!damages_reportExists(damages_report.damages_reportId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(damages_report);
        }

        // GET: damages_report/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var damages_report = await _context.damages_report
                .FirstOrDefaultAsync(m => m.damages_reportId == id);
            if (damages_report == null)
            {
                return NotFound();
            }

            return View(damages_report);
        }

        // POST: damages_report/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var damages_report = await _context.damages_report.FindAsync(id);
            if (damages_report != null)
            {
                _context.damages_report.Remove(damages_report);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool damages_reportExists(int id)
        {
            return _context.damages_report.Any(e => e.damages_reportId == id);
        }
    }
}
