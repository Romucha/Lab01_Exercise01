using Exercise01.DbAccess;
using Exercise01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercise01.Controllers
{
    public class FeedbackController : Controller
    {
        private ApplicationDbContext _context;
        public FeedbackController(ApplicationDbContext context) 
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Feedbacks);
        }

        public IActionResult Add()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Add(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _context.Feedbacks.Add(feedback);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
