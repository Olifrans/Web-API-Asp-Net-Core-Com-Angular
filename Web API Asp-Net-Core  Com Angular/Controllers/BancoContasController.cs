using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web_API_Asp_Net_Core__Com_Angular.Models;

namespace Web_API_Asp_Net_Core__Com_Angular.Controllers
{
    public class BancoContasController : Controller
    {
        private readonly ApiDBContext _context;

        public BancoContasController(ApiDBContext context)
        {
            _context = context;
        }

        // GET: BancoContas
        public async Task<IActionResult> Index()
        {
            return View(await _context.BancoConta.ToListAsync());
        }

        // GET: BancoContas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bancoConta = await _context.BancoConta
                .FirstOrDefaultAsync(m => m.BancoContaId == id);
            if (bancoConta == null)
            {
                return NotFound();
            }

            return View(bancoConta);
        }

        // GET: BancoContas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BancoContas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BancoContaId,ContaNumero,ContaSeguradora,BancoId,BRFSC")] BancoConta bancoConta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bancoConta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bancoConta);
        }

        // GET: BancoContas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bancoConta = await _context.BancoConta.FindAsync(id);
            if (bancoConta == null)
            {
                return NotFound();
            }
            return View(bancoConta);
        }

        // POST: BancoContas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BancoContaId,ContaNumero,ContaSeguradora,BancoId,BRFSC")] BancoConta bancoConta)
        {
            if (id != bancoConta.BancoContaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bancoConta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BancoContaExists(bancoConta.BancoContaId))
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
            return View(bancoConta);
        }

        // GET: BancoContas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bancoConta = await _context.BancoConta
                .FirstOrDefaultAsync(m => m.BancoContaId == id);
            if (bancoConta == null)
            {
                return NotFound();
            }

            return View(bancoConta);
        }

        // POST: BancoContas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bancoConta = await _context.BancoConta.FindAsync(id);
            _context.BancoConta.Remove(bancoConta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BancoContaExists(int id)
        {
            return _context.BancoConta.Any(e => e.BancoContaId == id);
        }
    }
}
