﻿using ARINLAB.Models;
using ARINLAB.Services;
using ARINLAB.Services.ImageService;
using ARINLAB.Services.SessionService;
using AutoMapper;
using DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace ARINLAB.Controllers
{
    public class WordsController : Controller
    {
        private readonly UserDictionary _userDictionary;
        private readonly IWordServices _wordsService;
        private readonly Services.IDictionaryService _dictService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly FileServices _audoFileServise;
        private readonly IImageService _fileService;
        private static string text = "";
        private readonly IMapper _mapper;

        public WordsController(UserDictionary userDictionary, IWordServices wordServices, Services.IDictionaryService dictionaryService
                                , FileServices fileServices)
        {
            _userDictionary = userDictionary;
            _wordsService = wordServices;
            _dictService = dictionaryService;
            _audoFileServise = fileServices;
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

        public async Task<IActionResult> Details(int id)
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