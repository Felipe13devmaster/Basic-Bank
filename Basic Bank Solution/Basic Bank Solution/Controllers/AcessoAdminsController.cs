using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Basic_Bank_Solution.Controllers
{
    public class AcessoAdminsController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
