using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eindwerk.Entities;
using Microsoft.AspNetCore.Authorization;

namespace eindwerk.Controllers
{
    [Authorize(Roles = "Manager, Admin")]
    public class ToestelController : Controller
    {
        private readonly DatabaseEindWerkContext _context;

        public ToestelController(DatabaseEindWerkContext context)
        {
            _context = context;
        }

        // GET: Toestel
        public async Task<IActionResult> Index()
        {
            var databaseEindWerkContext = _context.Toestel.Include(t => t.Locatie);
            return View(await databaseEindWerkContext.ToListAsync());
        }

        // GET: Toestel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toestel = await _context.Toestel
                .Include(t => t.Locatie)
                .FirstOrDefaultAsync(m => m.ToestelId == id);
            if (toestel == null)
            {
                return NotFound();
            }

            return View(toestel);
        }

        // GET: Toestel/Create
        public IActionResult Create()
        {
            ViewData["LocatieId"] = new SelectList(_context.Locatie, "LocatieId", "Naam");
            return View();
        }

        // POST: Toestel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ToestelId,Naam,Merk,Keuring,Ouderdom,Omschrijving,Formaat,MaximumGewicht,TypeMatras,TypeAandrijving,Opplooibaar,Verstelbaar,Materie,DatumAfschrijving,LocatieId,SoortToestel")] Toestel toestel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(toestel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocatieId"] = new SelectList(_context.Locatie, "LocatieId", "Naam", toestel.LocatieId);
            return View(toestel);
        }

        // GET: Toestel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toestel = await _context.Toestel.FindAsync(id);
            if (toestel == null)
            {
                return NotFound();
            }
            ViewData["LocatieId"] = new SelectList(_context.Locatie, "LocatieId", "Naam", toestel.LocatieId);
            return View(toestel);
        }

        // POST: Toestel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ToestelId,Naam,Merk,Keuring,Ouderdom,Omschrijving,Formaat,MaximumGewicht,TypeMatras,TypeAandrijving,Opplooibaar,Verstelbaar,Materie,DatumAfschrijving,LocatieId,SoortToestel")] Toestel toestel)
        {
            if (id != toestel.ToestelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(toestel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ToestelExists(toestel.ToestelId))
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
            ViewData["LocatieId"] = new SelectList(_context.Locatie, "LocatieId", "Naam", toestel.LocatieId);
            return View(toestel);
        }

        // GET: Toestel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toestel = await _context.Toestel
                .Include(t => t.Locatie)
                .FirstOrDefaultAsync(m => m.ToestelId == id);
            if (toestel == null)
            {
                return NotFound();
            }

            return View(toestel);
        }

        // POST: Toestel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var toestel = await _context.Toestel.FindAsync(id);
            _context.Toestel.Remove(toestel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ToestelExists(int id)
        {
            return _context.Toestel.Any(e => e.ToestelId == id);
        }
    }
}
