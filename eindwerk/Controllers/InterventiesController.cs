using eindwerk.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace eindwerk.Controllers
{
    public class InterventiesController : Controller
    {
        private readonly DatabaseEindWerkContext _context;

        public InterventiesController(DatabaseEindWerkContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Manager, Admin, Technieker")]
        // GET: Interventies
        public async Task<IActionResult> Index()
        {

          var databaseEindWerkContext = _context.Interventies.Include(i => i.Bestel).Include(i => i.Personeels).Include(i => i.Prioriteit).Include(i => i.Toestel).Include(i => i.Toestel.Locatie);

            return View(await databaseEindWerkContext.ToListAsync());
        }
        [Authorize(Roles = "Manager, Admin, Technieker")]
        public async Task<IActionResult> Eigenlijst()
        {
            if (User.IsInRole("Technieker"))
            {

                IQueryable<Interventies> EigenLijst = _context.Interventies.Where(b => b.Personeels.Emailadres == User.Identity.Name).Include(i => i.Bestel).Include(i => i.Personeels).Include(i => i.Prioriteit).Include(i => i.Toestel).Include(i => i.Toestel.Locatie);
        
                return View(EigenLijst);
            }
            else
            {


                var databaseEindWerkContext = _context.Interventies.Include(i => i.Bestel).Include(i => i.Personeels).Include(i => i.Prioriteit).Include(i => i.Toestel).Include(i => i.Toestel.Locatie);

                return View(await databaseEindWerkContext.ToListAsync());
            }
        }

        // GET: Interventies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Interventies interventies = await _context.Interventies
                .Include(i => i.Bestel)
                .Include(i => i.Personeels)
                .Include(i => i.Prioriteit)
                .Include(i => i.Toestel)
                .Include(i => i.Toestel.Locatie)
                .FirstOrDefaultAsync(m => m.InterventieId == id);
            if (interventies == null)
            {
                return NotFound();
            }

            return View(interventies);
        }

        // GET: Interventies/Create
        public IActionResult Create()
        {
            ViewData["BestelId"] = new SelectList(_context.Bestellingen, "BestelId", "BestelId");
            ViewData["PersoneelsId"] = new SelectList(_context.Personeelsleden, "PersoneelsId", "FullName");
            ViewData["PrioriteitId"] = new SelectList(_context.Prioriteit, "PrioriteitId", "_Prioriteit");
            ViewData["ToestelId"] = new SelectList(_context.Toestel, "ToestelId", "Naam");
            ViewData["LocatieId"] = new SelectList(_context.Locatie, "LocatieId", "Naam");


            return View();
        }

        // POST: Interventies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InterventieId,Complexiteit,Meldingsdatum,Omschrijving,Einddatum,Duur,Verwachtteoplossingstermijn,OmschrijvingOplossing,PersoneelsId,PrioriteitId,ToestelId,BestelId,Status")] Interventies interventies)
        {
            if (ModelState.IsValid)
            {
                interventies.PersoneelsId = 1;
                interventies.Status = 0;
                interventies.Meldingsdatum = DateTime.Now;
                _context.Add(interventies);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            ViewData["BestelId"] = new SelectList(_context.Bestellingen, "BestelId", "BestelId", interventies.BestelId);
            ViewData["PersoneelsId"] = new SelectList(_context.Personeelsleden, "PersoneelsId", "FullName", interventies.PersoneelsId);
            ViewData["PrioriteitId"] = new SelectList(_context.Prioriteit, "PrioriteitId", "_Prioriteit", interventies.PrioriteitId);
            ViewData["ToestelId"] = new SelectList(_context.Toestel, "ToestelId", "Naam", interventies.ToestelId);
            return View(interventies);
        }
        [Authorize(Roles = "Manager, Admin, Technieker")]
        // GET: Interventies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Interventies interventies = await _context.Interventies.FindAsync(id);

            ViewData["BestelId"] = new SelectList(_context.Bestellingen, "BestelId", "BestelId", interventies.BestelId);
            ViewData["PersoneelsId"] = new SelectList(_context.Personeelsleden.Where(b => b.SoortPersoneelslid.Contains("Technieker")), "PersoneelsId", "FullName", interventies.PersoneelsId);
            ViewData["PrioriteitId"] = new SelectList(_context.Prioriteit, "PrioriteitId", "_Prioriteit", interventies.PrioriteitId);
            ViewData["ToestelId"] = new SelectList(_context.Toestel, "ToestelId", "Naam", interventies.ToestelId);
            return View(interventies);
        }
        [Authorize(Roles = "Manager, Admin, Technieker")]
        // POST: Interventies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InterventieId,Complexiteit,Meldingsdatum,Omschrijving,Einddatum,Duur,Verwachtteoplossingstermijn,OmschrijvingOplossing,PersoneelsId,PrioriteitId,ToestelId,BestelId,Status")] Interventies interventies)
        {
            if (id != interventies.InterventieId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(interventies);
                    if (interventies.Status == Status.Opgelost)
                    {
                        if (interventies.OmschrijvingOplossing != null)
                        {
                            interventies.Einddatum = DateTime.Now;

                        }
                        else
                        {

                            ModelState.AddModelError("OmschrijvingOplossing", "Gelieve een oplossing in te vullen");
                            ViewData["BestelId"] = new SelectList(_context.Bestellingen, "BestelId", "BestelId", interventies.BestelId);
                            ViewData["PersoneelsId"] = new SelectList(_context.Personeelsleden, "PersoneelsId", "FullName", interventies.PersoneelsId);
                            ViewData["PrioriteitId"] = new SelectList(_context.Prioriteit, "PrioriteitId", "_Prioriteit", interventies.PrioriteitId);
                            ViewData["ToestelId"] = new SelectList(_context.Toestel, "ToestelId", "Naam", interventies.ToestelId);
                            return View(interventies);


                        }
                    }

                    if (interventies.PersoneelsId != 1 && interventies.Status != Status.Opgelost)
                    {

                        interventies.Status = Status.Toegewezen;


                    }

                    if (interventies.PersoneelsId == 1 && interventies.Status == Status.Toegewezen)
                    {

                        ModelState.AddModelError("PersoneelsId", "Gelieve de melding toe te wijzen");
                        ViewData["BestelId"] = new SelectList(_context.Bestellingen, "BestelId", "BestelId", interventies.BestelId);
                        ViewData["PersoneelsId"] = new SelectList(_context.Personeelsleden, "PersoneelsId", "FullName", interventies.PersoneelsId);
                        ViewData["PrioriteitId"] = new SelectList(_context.Prioriteit, "PrioriteitId", "_Prioriteit", interventies.PrioriteitId);
                        ViewData["ToestelId"] = new SelectList(_context.Toestel, "ToestelId", "Naam", interventies.ToestelId);
                        return View(interventies);


                    }
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InterventiesExists(interventies.InterventieId))
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
            ViewData["BestelId"] = new SelectList(_context.Bestellingen, "BestelId", "BestelId", interventies.BestelId);
            ViewData["PersoneelsId"] = new SelectList(_context.Personeelsleden, "PersoneelsId", "FullName", interventies.PersoneelsId);
            ViewData["PrioriteitId"] = new SelectList(_context.Prioriteit, "PrioriteitId", "_Prioriteit", interventies.PrioriteitId);
            ViewData["ToestelId"] = new SelectList(_context.Toestel, "ToestelId", "Naam", interventies.ToestelId);
            return View(interventies);
        }
        [Authorize(Roles = "Manager, Admin")]
        // GET: Interventies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Interventies interventies = await _context.Interventies
                .Include(i => i.Bestel)
                .Include(i => i.Personeels)
                .Include(i => i.Prioriteit)
                .Include(i => i.Toestel)
                .FirstOrDefaultAsync(m => m.InterventieId == id);
            if (interventies == null)
            {
                return NotFound();
            }

            return View(interventies);
        }
        [Authorize(Roles = "Manager, Admin")]
        // POST: Interventies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Interventies interventies = await _context.Interventies.FindAsync(id);
            _context.Interventies.Remove(interventies);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InterventiesExists(int id)
        {
            return _context.Interventies.Any(e => e.InterventieId == id);
        }
    }
}
