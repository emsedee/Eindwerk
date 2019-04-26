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
    public class PersoneelsledenController : Controller
    {
        private readonly DatabaseEindWerkContext _context;

        public PersoneelsledenController(DatabaseEindWerkContext context)
        {
            _context = context;
        }

        // GET: Personeelsleden
        public async Task<IActionResult> Index()
        {
            return View(await _context.Personeelsleden.ToListAsync());
        }

        // GET: Personeelsleden/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personeelsleden = await _context.Personeelsleden
                .FirstOrDefaultAsync(m => m.PersoneelsId == id);
            if (personeelsleden == null)
            {
                return NotFound();
            }

            return View(personeelsleden);
        }

        // GET: Personeelsleden/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Personeelsleden/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersoneelsId,Naam,Voornaam,GsmNummer,Emailadres,Foto,SoortPersoneelslid")] Personeelsleden personeelsleden)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personeelsleden);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personeelsleden);
        }

        // GET: Personeelsleden/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personeelsleden = await _context.Personeelsleden.FindAsync(id);
            if (personeelsleden == null)
            {
                return NotFound();
            }
            return View(personeelsleden);
        }

        // POST: Personeelsleden/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersoneelsId,Naam,Voornaam,GsmNummer,Emailadres,Foto,SoortPersoneelslid")] Personeelsleden personeelsleden)
        {
            if (id != personeelsleden.PersoneelsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personeelsleden);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersoneelsledenExists(personeelsleden.PersoneelsId))
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
            return View(personeelsleden);
        }

        // GET: Personeelsleden/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personeelsleden = await _context.Personeelsleden
                .FirstOrDefaultAsync(m => m.PersoneelsId == id);
            if (personeelsleden == null)
            {
                return NotFound();
            }

            return View(personeelsleden);
        }

        // POST: Personeelsleden/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personeelsleden = await _context.Personeelsleden.FindAsync(id);
            _context.Personeelsleden.Remove(personeelsleden);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersoneelsledenExists(int id)
        {
            return _context.Personeelsleden.Any(e => e.PersoneelsId == id);
        }
    }
}
