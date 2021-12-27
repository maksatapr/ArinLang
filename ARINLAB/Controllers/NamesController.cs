using ARINLAB.Models;
using ARINLAB.Services;
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
        public NamesController(UserDictionary userDict, INamesService namesService, Services.IDictionaryService dictionaryService)
        {
            _nameService = namesService;
            _dictService = dictionaryService;
            _userDictionary = userDict;
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
                return RedirectToAction("EditImage", new { id = id });

            NamesImagesViewModel model = new();
            model.Id = id;
            model.ArabName = res.ArabName;
            model.OtherName = res.OtherName;
            model.DictName = res.DictionaryName;
            var file = _nameService.GetAllNamesImagesByNameId(id);
            ViewBag.Model = model;
            return View(file);
        }
    }
}
