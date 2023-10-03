using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechSurvey.Entity.Concrete;

namespace TechSurvey.MVC.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles = "Member")]
    public class MUserController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        public MUserController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var users = await userManager.Users.ToListAsync();

            return View(users);
        }
        public async Task<ActionResult> Delete(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                await userManager.DeleteAsync(user);
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<ActionResult> Edit(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, AppUser user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    await userManager.UpdateAsync(user);
                }
                catch (Exception ex)
                {
                    if (await userManager.FindByIdAsync(id) == null)
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
            return View(user);
        }
    }
}
