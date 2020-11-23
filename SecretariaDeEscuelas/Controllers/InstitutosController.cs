using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SecretariaDeEscuelas.Data;
using SecretariaDeEscuelas.Models;

namespace SecretariaDeEscuelas.Controllers
{
    public class InstitutosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InstitutosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Institutos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Institutos.ToListAsync());
        }

        // GET: Institutos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instituto = await _context.Institutos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (instituto == null)
            {
                return NotFound();
            }

            return View(instituto);
        }

        // GET: Institutos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Institutos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] Instituto instituto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(instituto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(instituto);
        }

        // GET: Institutos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instituto = await _context.Institutos.FindAsync(id);
            if (instituto == null)
            {
                return NotFound();
            }
            return View(instituto);
        }

        // POST: Institutos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] Instituto instituto)
        {
            if (id != instituto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(instituto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstitutoExists(instituto.Id))
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
            return View(instituto);
        }

        // GET: Institutos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instituto = await _context.Institutos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (instituto == null)
            {
                return NotFound();
            }

            return View(instituto);
        }

        // POST: Institutos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var instituto = await _context.Institutos.FindAsync(id);
            _context.Institutos.Remove(instituto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstitutoExists(int id)
        {
            return _context.Institutos.Any(e => e.Id == id);
        }
    }
}
