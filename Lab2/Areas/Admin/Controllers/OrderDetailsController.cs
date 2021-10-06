using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab2.Data;
using Lab2.Views;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class OrderDetailsController : Controller
    {
        private readonly DataContext _context;

        public OrderDetailsController(DataContext context)
        {
            _context = context;
        }

        // GET: Admin/OrderBookDetails
        public async Task<IActionResult> Index(int id)
        {
            var temp = _context.OrderDetails.Where(x => x.OrderId == id).Include(o => o.Product);
            return View(temp);
        }
    }
}