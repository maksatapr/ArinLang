using ARINLAB.Services;
using DAL.Data;
using DAL.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARINLAB.Areas.Admin.Controllers
{
    [Area(Roles.Admin)]
    [Authorize(Roles = Roles.Admin)]
    public class AdminController : Controller
    {
        private readonly IWordServices _wordsService;
        public AdminController(IWordServices wordServices)
        {
            _wordsService = wordServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Area(Roles.Admin)]
        [Authorize(Roles = Roles.Admin)]
        public IActionResult Words()
        {
            List<WordDto> _words = _wordsService.GetAllWords(15,10);
            return View(_words);
        }
    }
}
