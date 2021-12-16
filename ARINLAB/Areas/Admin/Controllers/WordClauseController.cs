using ARINLAB.Services;
using AutoMapper;
using DAL.Data;
using DAL.Models.Dto;
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
    public class WordClauseController : Controller
    {
        private readonly IWordClauseService _wordClauseService;
        private readonly IDictionaryService _dictService;        
        private readonly IMapper _mapper;


        public WordClauseController(IWordClauseService wordClauseService, IMapper mapper, IDictionaryService dictionaryService)
        {
            _wordClauseService = wordClauseService;
            _mapper = mapper;
            _dictService = dictionaryService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewBag.Dictionaries = _dictService.GetAllDictionaries().Data;
            ViewBag.Categories = _wordClauseService.GetAllWordClauseCategories();
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> CreateAsync(CreateWordClauseDto model)
        {
            if (ModelState.IsValid)
            {
                model.UserId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var res = await _wordClauseService.CreateWordClause(model);
                if (res.IsSuccess)
                {
                    return RedirectToAction("Index");
                }               
            }
            ViewBag.Data = model;
            ViewBag.Dictionaries = _dictService.GetAllDictionaries().Data;
            ViewBag.Categories = _wordClauseService.GetAllWordClauseCategories();
            return View("Create");
        }
    }
}
