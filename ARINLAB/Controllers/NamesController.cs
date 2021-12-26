using ARINLAB.Services.SessionService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        public NamesController(UserDictionary userDict)
        {
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
    }
}
