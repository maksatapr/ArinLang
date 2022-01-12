using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;

using System.Globalization;
using Microsoft.Extensions.Localization;
using ARINLAB.Services;
using DAL.Models;
using DAL.Data;
using ARINLAB.Services.ImageService;
using ARINLAB;
using ARINLAB.Areas.Admin.Models;

namespace TSTB.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, Registration-Manager")]
    public class ApplicationUserController : Controller
    {
        
        private readonly ILanguageService _languageService;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _dbContex;
        private readonly RoleManager<IdentityRole> _roleManager;
        //private readonly IApplicationUserService _applicationUserService;
        private readonly IImageService _imageService;
        private readonly IStringLocalizer<SharedResource> _localizer;

        public ApplicationUserController(ILanguageService langService, IMapper mapper, RoleManager<IdentityRole> roleManager, 
            UserManager<ApplicationUser> userManager, IImageService imageService, ApplicationDbContext dbContext, 
            IStringLocalizer<SharedResource> localizer)
        {
            _mapper = mapper;
            _imageService = imageService;
            _languageService = langService;
            _roleManager = roleManager;
            _userManager = userManager;
            _dbContex = dbContext;
            _localizer = localizer;

        }
        // GET: Admin/ApplicationUser
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        // GET: Admin/ApplicationUser/ChangePassword/{id}
        public async Task<IActionResult> ChangePassword(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if(user == null)
            {
                return NotFound();
            }else
            {
                var c = await _userManager.GeneratePasswordResetTokenAsync(user);
                var c1= WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(c));
                
                ChangePasswordModel userForChangePass = new ChangePasswordModel
                {
                    Email = await _userManager.GetEmailAsync(user),
                    UserName = user.UserName,
                    Id = id
                };
                return View(userForChangePass);
            }            
        }

        [HttpPost]
        // GET: Admin/ApplicationUser/Edit/5
        public async Task<IActionResult> ChangePassword(ChangePasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByIdAsync(model.Id);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                ViewBag.ErrorList = "User does not exists";
                return View();
            }
            var Code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, Code, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
           else
            {
                ViewBag.ErrorList = result.Errors.ToList();
                return View(model);
            }
           
        }

        // GET: Admin/ApplicationUser/Delete/5
        public IActionResult Delete(string id)
        {
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View();
        }
    }
}