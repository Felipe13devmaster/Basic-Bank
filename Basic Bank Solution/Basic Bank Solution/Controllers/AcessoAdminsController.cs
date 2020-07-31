using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basic_Bank_Solution.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic_Bank_Solution.Controllers
{
    public class AcessoAdminsController : Controller
    {
        private readonly Contexto _context;

        public AcessoAdminsController(Contexto context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
