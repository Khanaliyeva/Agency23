using Agency23.Areas.Manage.ViewModels;
using Agency23.DAL;
using Agency23.Heplers;
using Agency23.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Agency23.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public PortfolioController(AppDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        public async Task<IActionResult> Index()
        {
            List<Portfolio> portfolios = await _context.Portfolios.ToListAsync();
            return View(portfolios);
        }

        public IActionResult Create(int id)
        {
            return View(new Portfolio());
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreatePortfolioVM createPortfolioVM)
        {
            if(!ModelState.IsValid)
            {
                return View("Error");
            }

            var File = createPortfolioVM.File.Upload(_environment.WebRootPath, "Upload");
            Portfolio portfolio = new Portfolio()
            {
                Title = createPortfolioVM.Title,
                Description = createPortfolioVM.Description,
                ImgUrl = File
            };

            await _context.Portfolios.AddAsync(portfolio);
            await _context.SaveChangesAsync();
            return View();
        }
    }
}
