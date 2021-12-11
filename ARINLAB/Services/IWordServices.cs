﻿using DAL.Models.Dto;
using DAL.Models.ResponceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARINLAB.Services
{
    public interface IWordServices
    {
        public Task<Responce>           addWordAsync(CreateWordDto word);
        public Task<Responce>           editWordAsync(EditWordDto editWordDto);
        public Task<Responce>           CreateWordSentenceAsync(CreateWordSentencesDto createWordModel);
        public Task<Responce>           EditWordSentenceAsync(EditWordSentencesDto editWordSentence);
        public List<WordDto>            GetAllWords(int page, int count);
        public Task<WordDto>            GetWordByIdAsync(int id);
        public Task<Responce>           EditWordApproveByIdAsync(int id, bool approve);
        public List<WordDto>            GetAllWordsByUserId(string userId);
        public List<WordDto>            GetWordsWithApproval(bool isApproved);
        public List<WordSentencesDto>   GetAllWordSentences();
        public List<WordSentencesDto>   GetAllWordSentencesByWordId(int wordId);
        public Task<Responce>           Delete(int id);
        public Task<WordSentencesDto>   GetWordSentencesById(int id);



    }
}
