﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TechSurvey.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            var roles = roleManager.Roles.ToList();
            return View(roles);
        }
        public async Task<IActionResult> Create()
        {
            IdentityRole role = new();
            return View(role);
        }
        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            if (!ModelState.IsValid)
            {
                return View(role);
            }

            var result = await roleManager.CreateAsync(role);
            if (!result.Succeeded)
            {
                return View(role);
            }
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Delete(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            return View(role);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            if (role != null)
            {
                await roleManager.DeleteAsync(role);
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<ActionResult> Edit(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            return View(role);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, IdentityRole role)
        {
            if (id != role.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    await roleManager.UpdateAsync(role);
                }
                catch (Exception ex)
                {
                    if (await roleManager.FindByIdAsync(id) == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        ModelState.AddModelError("", ex.Message);
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(role);
        }
    }
}
