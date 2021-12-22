using ARINLAB.Models;
using ARINLAB.Services;
using DAL.Data;
using DAL.Models.Dto.NamesDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ARINLAB.Areas.Admin.Controllers
{
    [Area(Roles.Admin)]
    [Authorize(Roles = Roles.Admin)]
    public class NamesController : Controller
    {
        private readonly INamesService _nameService;
        private readonly IDictionaryService _dictService;
        public NamesController(INamesService namesService, IDictionaryService dictionaryService)
        {
            _nameService = namesService;
            _dictService = dictionaryService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewBag.Dictionaries = _dictService.GetAllDictionaries().Data;            
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> CreateAsync(CreateNamesDto model)
        {
            if (ModelState.IsValid)
            {
                model.UserId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var res = await _nameService.CreateNameAsync(model);
                if (res.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
            }          
            ViewBag.Dictionaries = _dictService.GetAllDictionaries().Data;            
            return View("Create");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var res = await _nameService.GetNameByIdAsync(id);
            ViewBag.Dictionaries = _dictService.GetAllDictionaries().Data;
            if (res != null)
                return View(res);
            else
                return RedirectToAction("Index");
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(NamesDto model)
        {
            if (ModelState.IsValid)
            {
                model.NameImages = null;
                var res =  _nameService.EditName(model);
                if (res.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public async Task<IActionResult> EditImagesync(int id)
        {
            var clause = await _nameService.GetNameByIdAsync(id);
            if (clause == null)
                return RedirectToAction("Index");
            ViewBag.Dictionaries = _dictService.GetAllDictionaries().Data;
            ViewBag.Model = clause;
            var voices = _nameService.GetAllNamesImagesByNameId(id);
            return View(voices);
        }

        public async Task<IActionResult> AddImage(int id, string arabName, string otherName, string dictName)
        {
            NamesImagesViewModel model = new();
            model.Id = id;
            model.ArabName= arabName;
            model.OtherName= otherName;
            model.DictName = dictName;
            NameImagesDto file = new();
            ViewBag.Model = model;
            return View(file);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> AddImage(CreateNameImagesDto model)
        {
            var res = await _nameService.CreateImageforNameAsync(model);
            if (res.IsSuccess)
            {
                return RedirectToAction("EditImage", new { id = model.NamesId });
            }
            return View();
        }
    }
}
