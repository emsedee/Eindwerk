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
    public class KennisgebiedenController : Controller
    {
        private readonly DatabaseEindWerkContext _context;

        public KennisgebiedenController(DatabaseEindWerkContext context)
        {
            _context = context;
        }

        // GET: Kennisgebieden
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kennisgebieden.ToListAsync());
        }

        // GET: Kennisgebieden/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kennisgebieden = await _context.Kennisgebieden
                .FirstOrDefaultAsync(m => m.SpecialisatieId == id);
            if (kennisgebieden == null)
            {
                return NotFound();
            }

            return View(kennisgebieden);
        }

        // GET: Kennisgebieden/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kennisgebieden/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SpecialisatieId,KorteOmschrijving,LangeOmschrijving,SoortKennisgebied")] Kennisgebieden kennisgebieden)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kennisgebieden);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kennisgebieden);
        }

        // GET: Kennisgebieden/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kennisgebieden = await _context.Kennisgebieden.FindAsync(id);
            if (kennisgebieden == null)
            {
                return NotFound();
            }
            return View(kennisgebieden);
        }

        // POST: Kennisgebieden/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SpecialisatieId,KorteOmschrijving,LangeOmschrijving,SoortKennisgebied")] Kennisgebieden kennisgebieden)
        {
            if (id != kennisgebieden.SpecialisatieId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kennisgebieden);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KennisgebiedenExists(kennisgebieden.SpecialisatieId))
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
            return View(kennisgebieden);
        }

        // GET: Kennisgebieden/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kennisgebieden = await _context.Kennisgebieden
                .FirstOrDefaultAsync(m => m.SpecialisatieId == id);
            if (kennisgebieden == null)
            {
                return NotFound();
            }

            return View(kennisgebieden);
        }

        // POST: Kennisgebieden/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kennisgebieden = await _context.Kennisgebieden.FindAsync(id);
            _context.Kennisgebieden.Remove(kennisgebieden);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KennisgebiedenExists(int id)
        {
            return _context.Kennisgebieden.Any(e => e.SpecialisatieId == id);
        }
    }
}
