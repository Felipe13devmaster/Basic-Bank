using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Basic_Bank_Solution.Models;

namespace Basic_Bank_Solution.Controllers
{
    public class DadosAcessosController : Controller
    {
        private readonly Contexto _context;

        public DadosAcessosController(Contexto context)
        {
            _context = context;
        }

        // GET: DadosAcessos
        public async Task<IActionResult> Index()
        {
            var contexto = _context.DadosAcessos.Include(d => d.Cliente);
            return View(await contexto.ToListAsync());
        }

        // GET: DadosAcessos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dadosAcesso = await _context.DadosAcessos
                .Include(d => d.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dadosAcesso == null)
            {
                return NotFound();
            }

            return View(dadosAcesso);
        }

        // GET: DadosAcessos/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Id");
            return View();
        }

        // POST: DadosAcessos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeAcesso,Senha,ClienteId")] DadosAcesso dadosAcesso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dadosAcesso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Id", dadosAcesso.ClienteId);
            return View(dadosAcesso);
        }

        // GET: DadosAcessos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dadosAcesso = await _context.DadosAcessos.FindAsync(id);
            if (dadosAcesso == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Id", dadosAcesso.ClienteId);
            return View(dadosAcesso);
        }

        // POST: DadosAcessos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeAcesso,Senha,ClienteId")] DadosAcesso dadosAcesso)
        {
            if (id != dadosAcesso.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dadosAcesso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DadosAcessoExists(dadosAcesso.Id))
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
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Id", dadosAcesso.ClienteId);
            return View(dadosAcesso);
        }

        // GET: DadosAcessos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dadosAcesso = await _context.DadosAcessos
                .Include(d => d.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dadosAcesso == null)
            {
                return NotFound();
            }

            return View(dadosAcesso);
        }

        // POST: DadosAcessos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dadosAcesso = await _context.DadosAcessos.FindAsync(id);
            _context.DadosAcessos.Remove(dadosAcesso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DadosAcessoExists(int id)
        {
            return _context.DadosAcessos.Any(e => e.Id == id);
        }
    }
}
