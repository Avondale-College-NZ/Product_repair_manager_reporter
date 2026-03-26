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
    public class Item_damagesController : Controller
    {
        private readonly Product_repair_managerContext _context;

        public Item_damagesController(Product_repair_managerContext context)
        {
            _context = context;
        }

        // GET: Item_damages
        public async Task<IActionResult> Index()
        {
            return View(await _context.Item_damages.ToListAsync());
        }

        // GET: Item_damages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item_damages = await _context.Item_damages
                .FirstOrDefaultAsync(m => m.Item_damagesId == id);
            if (item_damages == null)
            {
                return NotFound();
            }

            return View(item_damages);
        }

        // GET: Item_damages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Item_damages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Item_damagesId,ItemId,damage_report,Item_date")] Item_damages item_damages)
        {
            if (ModelState.IsValid)
            {
                _context.Add(item_damages);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(item_damages);
        }

        // GET: Item_damages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item_damages = await _context.Item_damages.FindAsync(id);
            if (item_damages == null)
            {
                return NotFound();
            }
            return View(item_damages);
        }

        // POST: Item_damages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Item_damagesId,ItemId,damage_report,Item_date")] Item_damages item_damages)
        {
            if (id != item_damages.Item_damagesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(item_damages);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Item_damagesExists(item_damages.Item_damagesId))
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
            return View(item_damages);
        }

        // GET: Item_damages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item_damages = await _context.Item_damages
                .FirstOrDefaultAsync(m => m.Item_damagesId == id);
            if (item_damages == null)
            {
                return NotFound();
            }

            return View(item_damages);
        }

        // POST: Item_damages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item_damages = await _context.Item_damages.FindAsync(id);
            if (item_damages != null)
            {
                _context.Item_damages.Remove(item_damages);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Item_damagesExists(int id)
        {
            return _context.Item_damages.Any(e => e.Item_damagesId == id);
        }
    }
}
