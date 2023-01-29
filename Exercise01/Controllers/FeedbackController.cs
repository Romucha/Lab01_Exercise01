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
                return RedirectToAction(nameof(Thanks), new { Id = feedback.Id });
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) 
            {
                return NotFound();
            }
            Feedback feedback = _context.Feedbacks.FirstOrDefault(x => x.Id == id);
            if (feedback == null)
            {
                return NotFound();
            }
            return View(feedback);
        }

        [ValidateAntiForgeryToken, HttpPost]
        public IActionResult Delete(Feedback feedback)
        {
            if (feedback != null)
            {
                _context.Feedbacks.Remove(feedback);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Thanks(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Feedback feedback = _context.Feedbacks.FirstOrDefault(x => x.Id == id);
            if (feedback == null)
            {
                return NotFound();
            }
            return View(feedback);
        }
    }
}
