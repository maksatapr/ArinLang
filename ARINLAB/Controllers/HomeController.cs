using ARINLAB.Models;
using ARINLAB.Services;
using ARINLAB.Services.News;
using ARINLAB.Services.SessionService;
using ARINLAB.Services.Statistic;
using DAL.Models.Dto.NewsModelDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ARINLAB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStatisticsService _statService;
        private readonly UserDictionary _userDict;
        private readonly IDictionaryService _dictService;
        private readonly IWordServices _wordServices;
        private readonly INewsService _newsService;
        public HomeController(ILogger<HomeController> logger, IStatisticsService statisticsService, 
                              UserDictionary userDictionary, IDictionaryService dictionaryService,
                              IWordServices wordServices, INewsService newsService)
        {
            _logger = logger;
            _statService = statisticsService;
            _userDict = userDictionary;
            _dictService = dictionaryService;
            _wordServices = wordServices;
            _newsService = newsService;
        }

        public IActionResult Index()
        {
            var dicts = _dictService.GetAllDictionaries();
            ViewBag.Dictionaries = dicts;
            HomeViewModel model = new HomeViewModel() { StatistiCards = _statService.GetStatisticsCard() };
            ViewBag.News = (List<NewsDTO>)(_newsService.GetFourPublishNews().ToList());

            return View(model);
        }

        public IActionResult SetDictionary(int dictId)
        {
            _userDict.SetDictionary(dictId);
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return RedirectToAction("Index");
        }
    }
}
