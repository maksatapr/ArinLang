﻿using DAL.Models.Dto;
using DAL.Models.ResponceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARINLAB.Services
{
    public interface IWordClauseService
    {
        public Task<Responce> CreateWordClause(CreateWordClauseDto model);
        public Task<Responce> CreateWordClauseCategory(CreateWordClauseCategoryDto model);

        public Task<Responce> EditWordClause(WordClauseDto model);
        public Task<Responce> EditWordClauseCategory(WordClauseCategoryDto model);

        public Task<Responce> DeleteWordClause(int id);
        public Task<Responce> DeleteWordClauseCategory(int id);

        public List<WordClauseDto> GetAllWordClauses();
        public List<WordClauseCategoryDto> GetAllWordClauseCategories();

        public Task<WordClauseDto> GetWordClauseByIdAsync(int id);
        public Task<WordClauseCategoryDto> GetWordClauseCategoryByIdAsync(int id);

        public List<WordClauseDto> GetAllWordClauseByDictionaryId(int id);
        public List<WordClauseDto> GetAllWordClauseById_and_DictionaryId(int id, int dictId);

        public List<WordClauseCategoryDto> GetAllWordClauseCategoriesByDictID(int id);
        public List<WordClauseCategoryDto> GetAllWordClauseCategoriesById_and_DictId(int id, int dictId);

    }
}
