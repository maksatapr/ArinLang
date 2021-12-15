using ARINLAB.Services;
using AutoMapper;
using DAL.Data;
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
    public class WordClauseController : Controller
    {
        private readonly IWordClauseService _wordClauseService;
        private readonly IDictionaryService _dictService;
        private readonly IMapper _mapper;

        public void SetViewBag(int wordClauseId=-1, int dictId=-1)
        {
            var category = _wordClauseService.GetAllWordClauseCategories();
            ViewBag.categories = category;
            
            var dict = _dictService.GetAllDictionaries().Data;
            ViewBag.dict = dict;

            ViewBag.total = _wordClauseService.GetAllWordClauses().Count();
           
        }

        public WordClauseController(IWordClauseService wordClauseService, IMapper mapper, IDictionaryService dictionaryService)
        {
            _wordClauseService = wordClauseService;
            _mapper = mapper;
            _dictService = dictionaryService;
        }
        public IActionResult Index()
        {
            try
            {
                var res = _wordClauseService.GetAllWordClauses();
                SetViewBag();
                return View(res);
            }catch(Exception e)
            {
                return View(null);
            }
        }
    }
}
