using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TechSurvey.Entity.Concrete;
using TechSurvey.MVC.Areas.Admin.Models.DTOs;

namespace TechSurvey.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IMapper mapper;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserController(UserManager<AppUser> userManager, IMapper mapper, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            var users = await userManager.Users.Include(p => p.Roles).ToListAsync();
            return View(users);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            UserCreateDTO createDTO = new();
            createDTO.Roles = await SetRoles();

            return View(createDTO);
        }

        [NonAction]
        public async Task<ICollection<SelectListItem>> SetRoles()
        {
            var Roles = await roleManager.Roles.Select(p => new SelectListItem { Text = p.Name, Value = p.Id }).ToListAsync();
            ViewBag.roles = Roles;
            return Roles;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserCreateDTO createDTO)
        {
            if (!ModelState.IsValid)
            {
                createDTO.Roles = await SetRoles();
                return View(createDTO);
            }
            if (createDTO.RoleId.Length < 2)
            {
                createDTO.Roles = await SetRoles();
                return View(createDTO);
            }
            try
            {
                var user = mapper.Map<AppUser>(createDTO);
                var result = await userManager.CreateAsync(user, createDTO.Password);
                if (result.Succeeded)
                {
                    var role = await roleManager.FindByIdAsync(createDTO.RoleId);
                    var roleresult = await userManager.AddToRoleAsync(user, role.Name);
                    return RedirectToAction("Index", "Home", new { Area = "Admin" });
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                createDTO.Roles = await SetRoles();
                return View(createDTO);
            }
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
