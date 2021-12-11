using ARINLAB.Models;
using ARINLAB.Services;
using AutoMapper;
using DAL.Data;
using DAL.Models;
using DAL.Models.Dto;
using DAL.Models.ResponceModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
    public class WordController : Controller
    {
        private readonly IWordServices _wordsService;
        private readonly IDictionaryService _dictService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly FileServices _audoFileServise;
        private static string text = "";
        private readonly IMapper _mapper;
        public WordController(IWordServices wordServices, IDictionaryService dictionaryService, UserManager<ApplicationUser> userManager, 
                              IMapper mapper, FileServices fileServices)
        {
            _wordsService = wordServices;
            _dictService = dictionaryService;
            _userManager = userManager;
            _mapper = mapper;
            _audoFileServise = fileServices;
        }
        public IActionResult Index()
        {
            ViewBag.page = 1;          
            ViewBag.total = _wordsService.GetAllWords(1,int.MaxValue).Count;
            var result = _wordsService.GetAllWords(1, 15);
            ViewBag.text = text;
            return View(new List<WordDto>(result));
        }

        [HttpGet("/Admin/[controller]/{id}/{approve}/{returnPage}")]
        public async Task<IActionResult> EditApproveAsync(int id, bool approve, int returnPage) {

            var resp = await _wordsService.EditWordApproveByIdAsync(id, approve);
           
                if (resp.IsSuccess)
                {
                    ViewBag.text = "Success";
                }
                else
                {
                    ViewBag.text = "";
                }
            
            ViewBag.page = returnPage;
            ViewBag.total = _wordsService.GetAllWords(1, int.MaxValue).Count;
            var res = _wordsService.GetAllWords(returnPage, 15);           
            return View("Index", new List<WordDto>(res));
        }

        [HttpGet("/Admin/[controller]/List/{page}/{count}")]
        public IActionResult List(int page, int count)
        {
            var result = _wordsService.GetAllWords(page, count);
            ViewBag.text = "";
            ViewBag.page = page;           
            ViewBag.total = _wordsService.GetAllWords(1, int.MaxValue).Count;
            return View( "Index", new List<WordDto>(result));
        }

        [HttpGet]
        public IActionResult Create()
        {
            var result = new List<DAL.Models.Dictionary>((IEnumerable<DAL.Models.Dictionary>)_dictService.GetAllDictionaries().Data);
            ViewBag.Dicts = result;
            return View(new CreateWordDto());
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> CreateAsync(CreateWordDto newW)
        {
            var r = new List<DAL.Models.Dictionary>((IEnumerable<DAL.Models.Dictionary>)_dictService.GetAllDictionaries().Data);
            if (newW != null)
            {
                var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                newW.UserId = userId;
                newW.IsApproved = true;
                if (ModelState.IsValid)
                {
                    Responce result = await _wordsService.addWordAsync(newW);
                    if (result.IsSuccess)
                    {
                        ViewBag.text = $"Word {newW.ArabWord} <-> {newW.OtherWord} added successfully";
                        ViewBag.page = 1;
                        ViewBag.total = _wordsService.GetAllWords(1, int.MaxValue).Count;
                        var rt = _wordsService.GetAllWords(1, 15);
                        return View("Index", rt);
                    }
                }
                newW.IsApproved = false;
                ViewBag.Dicts = r;
                ViewBag.page = 1;
                ViewBag.total = _wordsService.GetAllWords(1, int.MaxValue).Count;
                return View(newW);
            }
           
            ViewBag.Dicts = r;
            ViewBag.page = 1;
            ViewBag.total = _wordsService.GetAllWords(1, int.MaxValue).Count;
            return View(new CreateWordDto());
        }

        [HttpGet("/Admin/[controller]/Edit/{id}")]
        public async Task<IActionResult> EditAsync(int id)
        {
            if (id < 0) {
                ViewBag.page = 1;
                ViewBag.total = _wordsService.GetAllWords(1, int.MaxValue).Count;
                var result = _wordsService.GetAllWords(1, 15);
                ViewBag.text = text;
                return View("Index", new List<WordDto>(result));
            }
            var res = await _wordsService.GetWordByIdAsync(id);
            if(res == null )
            {
                ViewBag.page = 1;
                ViewBag.total = _wordsService.GetAllWords(1, int.MaxValue).Count;
                var result = _wordsService.GetAllWords(1, 15);
                ViewBag.text = text;
                return View("Index", new List<WordDto>(result));
            }
            ViewBag.Dictionaries = new List<Dictionary>((IEnumerable<Dictionary>)_dictService.GetAllDictionaries().Data);
            return View(_mapper.Map<EditWordDto>(res));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAsync(EditWordDto model)
        {
            try
            {
                Responce result = await _wordsService.editWordAsync(model);
                if (result.IsSuccess)
                {
                    ViewBag.page = 1;
                    ViewBag.total = _wordsService.GetAllWords(1, int.MaxValue).Count;
                    var data = _wordsService.GetAllWords(1, 15);
                    ViewBag.text = "Success";
                    ViewBag.Dictionaries = new List<Dictionary>((IEnumerable<Dictionary>)_dictService.GetAllDictionaries().Data);
                    return View("Index", new List<WordDto>(data));
                }
                else
                {
                    ViewBag.Dictionaries = new List<Dictionary>((IEnumerable<Dictionary>)_dictService.GetAllDictionaries().Data);
                    return View(model);
                }
            }catch(Exception e)
            {
                ViewBag.Dictionaries = new List<Dictionary>((IEnumerable<Dictionary>)_dictService.GetAllDictionaries().Data);
                return View(model);
            }
        }

        [HttpGet("/Admin/[controller]/Delete/{id}")]
        [Authorize(Roles=Roles.Admin)]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await _wordsService.Delete(id);
            if (res.IsSuccess)
            {
                ViewBag.text = "Success";
            }
            ViewBag.page = 1;
            ViewBag.total = _wordsService.GetAllWords(1, int.MaxValue).Count;
            var data = _wordsService.GetAllWords(1, 15);            
            ViewBag.Dictionaries = new List<Dictionary>((IEnumerable<Dictionary>)_dictService.GetAllDictionaries().Data);
            return View("Index", new List<WordDto>(data));
        }

     
        public async Task<IActionResult> EditWordAsync(int id)
        {
            try
            {
                var res = await _wordsService.GetWordByIdAsync(id);
                if (res != null)
                {
                    WordSentencesViewModel model = new();
                    model.Word = res;
                    model.WordSentences = _wordsService.GetAllWordSentencesByWordId(id);
                    model.AudioFiles = _audoFileServise.GetAudioFilesByWordId(id);
                    ViewBag.dict = _dictService.GetAllDictionaries().Data;
                    return View(model);
                }
                else
                {
                    ViewBag.page = 1;
                    ViewBag.total = _wordsService.GetAllWords(1, int.MaxValue).Count;
                    var result = _wordsService.GetAllWords(1, 15);
                    ViewBag.text = text;
                    return View("Index",result);
                }
            }catch(Exception e)
            {
                ViewBag.page = 1;
                ViewBag.total = _wordsService.GetAllWords(1, int.MaxValue).Count;
                var result = _wordsService.GetAllWords(1, 15);
                ViewBag.text = text;
                return View("Index", result);
            }
        }
        
        public IActionResult AddWordSentence(int id,string arabWord, string otherWord, string dictId)
        {
            SimpleWordModel model = new SimpleWordModel
            {
                Id = id,
                ArabWord = arabWord,
                OtherWord = otherWord,
                DictID = dictId
            };
            ViewBag.dict = _dictService.GetAllDictionaries().Data;
            return View(model);
        } 

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult EditWord(WordSentencesViewModel model)
        {
            return View(model);
        }


    }
}
