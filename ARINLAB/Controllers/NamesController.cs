using ARINLAB.Models;
using ARINLAB.Services;
using ARINLAB.Services.Ratings;
using ARINLAB.Services.SessionService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace ARINLAB.Controllers
{
    public class UserDictionaryModel
    {
        public int DictionaryId { get; set; }
    }
    public class NamesController : Controller
    {
        private readonly UserDictionary _userDictionary;
        private readonly INamesService _nameService;
        private readonly Services.IDictionaryService _dictService;
        private readonly IRatingService _ratingServices;
        public NamesController(UserDictionary userDict, INamesService namesService, 
                            Services.IDictionaryService dictionaryService, IRatingService ratingServices)
        {
            _nameService = namesService;
            _dictService = dictionaryService;
            _userDictionary = userDict;
            _ratingServices = ratingServices;
        }
       

        public IActionResult Indexall()
        {
            var res = _userDictionary.GetDictionaryId();
            UserDictionaryModel model = new UserDictionaryModel();
            if((int)res == -1)
            {
                model.DictionaryId = 1;
            }
            else
            {
                model.DictionaryId = (int)res;
            }
            return View(model);
        }

        public async Task<IActionResult> DetailsAsync(int id)
        {
            var res = await _nameService.GetNameByIdAsync(id);
            if (res == null)
                return RedirectToAction("Indexall");

            NamesImagesViewModel model = new();
            model.Id = id;
            model.ArabName = res.ArabName;
            model.OtherName = res.OtherName;
            model.DictName = res.DictionaryName;
            var file = _nameService.GetAllNamesImagesByNameId(id);
            ViewBag.Rating = _ratingServices.GetRatingForName(id);
            ViewBag.Model = model;
            return View(file);
        }

        [HttpPost]
        public async Task<IActionResult> SetRatingAsync(float Rating, int NameId)
        {
            var responce = await _ratingServices.SetRatingForNameAsync(Rating, NameId);
            try
            {
                var res = await _nameService.GetNameByIdAsync(NameId);

                if (res != null)
                {
                    NamesImagesViewModel model = new();
                    model.Id = NameId;
                    model.ArabName = res.ArabName;
                    model.OtherName = res.OtherName;
                    model.DictName = res.DictionaryName;
                    var file = _nameService.GetAllNamesImagesByNameId(NameId);
                    ViewBag.Rating = _ratingServices.GetRatingForName(NameId);
                    ViewBag.Model = model;
                    ViewBag.RatingResult = responce.IsSuccess;
                    return View("Details", file);
                }
                else
                {
                    return RedirectToAction("Indexall");
                }
            }
            catch (Exception e)
            {
                return RedirectToAction("Indexall");
            }
        }
    }
}
