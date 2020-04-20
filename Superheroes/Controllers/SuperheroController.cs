using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Superheroes.Data;

namespace Superheroes.Controllers
{   
    public class SuperheroController : Controller
    {
        private ApplicationDbContext _context;
        SuperheroController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }

    }
}