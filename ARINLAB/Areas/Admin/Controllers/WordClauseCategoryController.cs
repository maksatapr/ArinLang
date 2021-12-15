using ARINLAB.Services;
using AutoMapper;
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
    public class WordClauseCategoryController : Controller
    {
        private readonly IWordClauseService _wordClauseServices;
        private readonly IMapper _mapper;
        private readonly ILanguageService _languageService;

        public WordClauseCategoryController(IWordClauseService wordClause, IMapper mapper, ILanguageService languageService)
        {
            _wordClauseServices = wordClause;
            _mapper = mapper;
            _languageService = languageService;
        }

        public IActionResult Index()
        {
            var res = _wordClauseServices.GetAllWordClauseCategories();           
            return View(res);
        }

        public IActionResult Create()
        {
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            ViewBag.Categories = _wordClauseServices.GetAllWordClauseCategories();
            int count = _wordClauseServices.GetAllWordClauseCategories().Count;
            return View(new CreateWordClauseCategoryDto() { WordClauseCategoryTranslates = new List<DAL.Models.WordClauseCategoryTranslate>(count)});
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateWordClauseCategoryDto cat)
        {
            if (ModelState.IsValid)
            {
                await _wordClauseServices.CreateWordClauseCategory(cat);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            ViewBag.Categories = _wordClauseServices.GetAllWordClauseCategories();
            return View(cat);
        }
    }
}
