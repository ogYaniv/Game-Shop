using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GameShop.Data;
using GameShop.Models;

namespace GameShop.Controllers
{
    public class ConsolePagesController : Controller
    {
        private readonly GameShopContext _context;

        public ConsolePagesController(GameShopContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> MainPage(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var pls = from b in _context.ConsolePage
                      where b.Id == id
                      select b.Name;
            string w = pls.First();
            var gameSearch = _context.Product.Where(a => a.Consoles.Contains(w));
            return View("MainPage", await gameSearch.ToListAsync());
        }

        public async Task<IActionResult> Home()
        {
            return View(await _context.ConsolePage.ToListAsync());
        }

        // GET: ConsolePages
        public async Task<IActionResult> Index()
        {
            return View(await _context.ConsolePage.ToListAsync());
        }

        // GET: ConsolePages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consolePage = await _context.ConsolePage
                .FirstOrDefaultAsync(m => m.Id == id);
            if (consolePage == null)
            {
                return NotFound();
            }

            return View(consolePage);
        }

        // GET: ConsolePages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ConsolePages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] ConsolePage consolePage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consolePage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(consolePage);
        }

        // GET: ConsolePages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consolePage = await _context.ConsolePage.FindAsync(id);
            if (consolePage == null)
            {
                return NotFound();
            }
            return View(consolePage);
        }

        // POST: ConsolePages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] ConsolePage consolePage)
        {
            if (id != consolePage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consolePage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsolePageExists(consolePage.Id))
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
            return View(consolePage);
        }

        // GET: ConsolePages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consolePage = await _context.ConsolePage
                .FirstOrDefaultAsync(m => m.Id == id);
            if (consolePage == null)
            {
                return NotFound();
            }

            return View(consolePage);
        }

        // POST: ConsolePages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var consolePage = await _context.ConsolePage.FindAsync(id);
            _context.ConsolePage.Remove(consolePage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsolePageExists(int id)
        {
            return _context.ConsolePage.Any(e => e.Id == id);
        }
    }
}
