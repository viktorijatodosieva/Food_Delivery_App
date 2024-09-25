using EShop.Domain.Domain;
using EShop.Repository;
using EShop.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EShop.Web.Controllers
{
    public class PartnerBooksController : Controller
    {

        private readonly IPartnerService _partnerService;
        private readonly ApplicationDbContext _context;


        public PartnerBooksController(IPartnerService partnerService, ApplicationDbContext context)
        {
            _partnerService = partnerService;
            _context = context;
        }
        //public IActionResult Index()
        //{
        //    List<Partner>
        //    return View(_partnerService.GetAllBooks());
        //}

        public async Task<IActionResult> Index()
        {
            var books = await _context.PartnerBooks.FromSqlRaw("SELECT * FROM PartnerBooks").ToListAsync();
            return View(books);
        }
    }
}
