using Microsoft.AspNetCore.Mvc;
using PracticaMvc.Models; 
using Microsoft.EntityFrameworkCore;

namespace PracticaMvc.Controllers{
    public class MoviesController : Controller{
        private readonly MovieDBContext _context;
        public MoviesController(MovieDBContext context) {
            _context = context;
        }


      public async Task<IActionResult> Index(){
        return View(await _context.MovieDBs.ToListAsync());
      }
      public async Task<IActionResult> Details(int id){
         return View (await _context.MovieDBs.FirstOrDefaultAsync(x => x.Id == id));
      }
    }
}