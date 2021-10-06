using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab2.Data;
using Lab2.Models.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Areas.Admin.Controllers
{
    [Authorize(Roles = "Administrator")]
    [Area("Admin")]
    public class AdminUsersController : Controller
    {
        private readonly DataContext _context;

        public AdminUsersController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Users.ToList());
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || id.Trim().Length == 0)
            {
                return NotFound();
            }
            var userFromDb = await _context.Users.FindAsync(id);
            if (userFromDb == null)
            {
                return NotFound();
            }
            return View(userFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, User applicationUser)
        {
            if (id != applicationUser.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                User userFromDb = _context.Users.Where(b => b.Id == id).FirstOrDefault();
                userFromDb.UserName = applicationUser.UserName;
                userFromDb.PhoneNumber = applicationUser.PhoneNumber;
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(applicationUser);
        }

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || id.Trim().Length == 0)
            {
                return NotFound();
            }
            var userFromDb = await _context.Users.FindAsync(id);
            if (userFromDb == null)
            {
                return NotFound();
            }
            return View(userFromDb);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePOSTAsync(string id)
        {
            if (id == null || id.Trim().Length == 0)
            {
                return NotFound();
            }
            try
            {
                User userFromDb = _context.Users.Where(p => p.Id == id).FirstOrDefault();
                userFromDb.LockoutEnd = DateTime.Now.AddYears(1000);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            catch (DbUpdateException)
            {
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }
    }
}