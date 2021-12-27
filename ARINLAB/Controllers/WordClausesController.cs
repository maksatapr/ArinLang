using ARINLAB.Services;
using ARINLAB.Services.SessionService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARINLAB.Controllers
{
    public class WordClausesController : Controller
    {
        private readonly UserDictionary _userDictionary;
        private readonly IWordClauseService _wordClauseService;
        private readonly IDictionaryService _dictService;
        public WordClausesController(UserDictionary userDict, IWordClauseService wordClauseService, IDictionaryService dictionaryService )
        {
            _userDictionary = userDict;
            _wordClauseService = wordClauseService;
            _dictService = dictionaryService;
        }
        public IActionResult Indexall()
        {
            var res = _userDictionary.GetDictionaryId();
            UserDictionaryModel model = new UserDictionaryModel();
            if ((int)res == -1)
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
            var clause = await _wordClauseService.GetWordClauseByIdAsync(id);
            if (clause == null)
                return RedirectToAction("Index");
            ViewBag.Dictionaries = _dictService.GetAllDictionaries().Data;
            ViewBag.Model = clause;
            var voices = _wordClauseService.GetAudioFileForClausebyID(id, true);
            return View(voices);

        }
    }
}
