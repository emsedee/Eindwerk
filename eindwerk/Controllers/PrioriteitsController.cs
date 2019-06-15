using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eindwerk.Entities;

namespace eindwerk.Controllers
{
    public class PrioriteitsController : Controller
    {
        private readonly DatabaseEindWerkContext _context;

        public PrioriteitsController(DatabaseEindWerkContext context)
        {
            _context = context;
        }

        // GET: Prioriteits
        public async Task<IActionResult> Index()
        {
            return View(await _context.Prioriteit.ToListAsync());
        }

        // GET: Prioriteits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prioriteit = await _context.Prioriteit
                .FirstOrDefaultAsync(m => m.PrioriteitId == id);
            if (prioriteit == null)
            {
                return NotFound();
            }

            return View(prioriteit);
        }

        // GET: Prioriteits/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Prioriteits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PrioriteitId,_Prioriteit")] Prioriteit prioriteit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prioriteit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prioriteit);
        }

        // GET: Prioriteits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prioriteit = await _context.Prioriteit.FindAsync(id);
            if (prioriteit == null)
            {
                return NotFound();
            }
            return View(prioriteit);
        }

        // POST: Prioriteits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PrioriteitId,_Prioriteit")] Prioriteit prioriteit)
        {
            if (id != prioriteit.PrioriteitId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prioriteit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrioriteitExists(prioriteit.PrioriteitId))
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
            return View(prioriteit);
        }

        // GET: Prioriteits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prioriteit = await _context.Prioriteit
                .FirstOrDefaultAsync(m => m.PrioriteitId == id);
            if (prioriteit == null)
            {
                return NotFound();
            }

            return View(prioriteit);
        }

        // POST: Prioriteits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prioriteit = await _context.Prioriteit.FindAsync(id);
            _context.Prioriteit.Remove(prioriteit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrioriteitExists(int id)
        {
            return _context.Prioriteit.Any(e => e.PrioriteitId == id);
        }
    }
}
