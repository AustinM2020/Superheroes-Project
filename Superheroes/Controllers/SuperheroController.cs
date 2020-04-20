using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Superheroes.Data;
using Superheroes.Models;

namespace Superheroes.Controllers
{   
    public class SuperheroController : Controller
    {
        private ApplicationDbContext _context;
        public SuperheroController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var superheroes = _context.Superheroes.ToList();
            return View(superheroes);
        }
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Superhero superhero)
        {
            _context.Add(superhero);
            _context.SaveChanges();
            return View();
        }
        public IActionResult Details(int Id = 0)
        {
            Superhero superhero = _context.Superheroes.Find(Id);
            return View(superhero);
        }
    }
}