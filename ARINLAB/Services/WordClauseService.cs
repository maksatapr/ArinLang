using AutoMapper;
using DAL.Data;
using DAL.Models;
using DAL.Models.Dto;
using DAL.Models.ResponceModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ARINLAB.Services
{
    public class WordClauseService : IWordClauseService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _useManager;

        public WordClauseService(ApplicationDbContext dbContext, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _useManager = userManager;
        }
        public async Task<Responce> CreateWordClause(CreateWordClauseDto model)
        {
            try
            {                
                var res = await _dbContext.WordClauses.AddAsync(_mapper.Map<WordClause>(model));
                await _dbContext.SaveChangesAsync();
                return ResponceGenerator.GetResponceModel(true, "", res);
            }catch(Exception e)
            {
                return ResponceGenerator.GetResponceModel(false, e.Message, null);
            }
        }

        public async Task<Responce> CreateWordClauseCategory(CreateWordClauseCategoryDto model)
        {
            try
            {
                var res = await _dbContext.WordClauseCategories.AddAsync(_mapper.Map<WordClauseCategory>(model));
                await _dbContext.SaveChangesAsync();
                return ResponceGenerator.GetResponceModel(true, "", res);
            }
            catch (Exception e)
            {
                return ResponceGenerator.GetResponceModel(false, e.Message, null);
            }
        }

        public async Task<Responce> DeleteWordClause(int id)
        {
            try
            {
                var res = await _dbContext.WordClauses.FindAsync(id);
                if (res != null)
                {
                    _dbContext.WordClauses.Remove(res);
                    await _dbContext.SaveChangesAsync();
                    return ResponceGenerator.GetResponceModel(true, "", res);
                }
                return ResponceGenerator.GetResponceModel(false, "", res);
            }catch(Exception e)
            {
                return ResponceGenerator.GetResponceModel(false, "", null);
            }
        }

        public async Task<Responce> DeleteWordClauseCategory(int id)
        {
            try
            {
                var res = await _dbContext.WordClauseCategories.FindAsync(id);
                if (res != null)
                {
                    _dbContext.WordClauseCategories.Remove(res);
                    await _dbContext.SaveChangesAsync();
                    return ResponceGenerator.GetResponceModel(true, "", res);
                }
                return ResponceGenerator.GetResponceModel(false, "", res);
            }
            catch (Exception e)
            {
                return ResponceGenerator.GetResponceModel(false, "", null);
            }
        }

        public async Task<Responce> EditWordClause(EditWordClauseDto model)
        {
            try
            {                
                var res = _mapper.Map<WordClause>(model);
                _dbContext.WordClauses.Update(res);
                await _dbContext.SaveChangesAsync();
                return ResponceGenerator.GetResponceModel(true, "", res);
            }
            catch(Exception e)
            {
                return ResponceGenerator.GetResponceModel(false, "", null);
            }
        }

        public async Task<Responce> EditWordClauseCategory(WordClauseCategoryDto model)
        {
            try
            {
                var res = _mapper.Map<WordClauseCategory>(model);
                _dbContext.WordClauseCategories.Update(res);
                await _dbContext.SaveChangesAsync();
                return ResponceGenerator.GetResponceModel(true, "", res);
            }
            catch (Exception e)
            {
                return ResponceGenerator.GetResponceModel(false, "", null);
            }
        }

        public List<WordClauseDto> GetAllWordClauseByDictionaryId(int id)
        {
            var res = _dbContext.WordClauses.Select(p => p.DictionaryId == id);
            if (res != null)
            {
                return _mapper.Map<List<WordClauseDto>>(res);
            }
            else
                return null;
        }

        public List<WordClauseDto> GetAllWordClauseById_and_DictionaryId(int id, int dictId)
        {
            var res = _dbContext.WordClauses.Select(p => p.Id == id && p.DictionaryId == dictId);
            if(res != null)
            {
                return _mapper.Map<List<WordClauseDto>>(res);
            }return null;
        }

        public List<WordClauseCategoryDto> GetAllWordClauseCategories()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var res = _dbContext.WordClauseCategories.Include(p=>p.WordClauseCategoryTranslates);
            if (res != null)
            {

                var res1 = _mapper.Map<List<WordClauseCategoryDto>>(res);
                foreach(var item in res1)
                {
                    item.CategoryName = _dbContext.WordClauseCategoryTranslates.FirstOrDefault(p => p.LanguageCulture == culture && p.WordClauseCategoryId == item.Id)?.CategoryName;
                    item.ParenCategoryName = _dbContext.WordClauseCategoryTranslates.SingleOrDefault(p => p.LanguageCulture == culture && p.WordClauseCategoryId == item.ParentCategoryId)?.CategoryName ;
                    if (item.ParenCategoryName == null)
                        item.ParenCategoryName = "";
                }
                return res1;
            }
            return null;
        }

        public List<WordClauseCategoryDto> GetAllWordClauseCategoriesByDictID(int id)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var res = _dbContext.WordClauseCategories.Include(p => p.WordClauseCategoryTranslates.FirstOrDefault(p => p.LanguageCulture == culture));            
            if (res != null)
            {
                var res1 = res.Select(p => p.Id == id);
                if(res1!=null && res1.Count() > 0)
                    return _mapper.Map<List<WordClauseCategoryDto>>(res1);
            }
            return null;
        }

        public List<WordClauseCategoryDto> GetAllWordClauseCategoriesById_and_DictId(int id, int dictId)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var res = _dbContext.WordClauseCategories.Include(p => p.WordClauseCategoryTranslates.FirstOrDefault(p => p.LanguageCulture == culture));
            if (res != null)
            {
                var res1 = res.Select(p => p.Id == id);
                if (res1 != null && res1.Count() > 0)
                    return _mapper.Map<List<WordClauseCategoryDto>>(res1);
            }
            return null;
        }

        public async Task<List<WordClauseDto>> GetAllWordClausesAsync()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var res = _dbContext.WordClauses;
            List<WordClauseDto> result = new List<WordClauseDto>();
            if (res != null)
            {
                foreach (var clause in res) {
                    var userName = _useManager.FindByIdAsync(clause.UserId)?.Result.Email;
                    var dto = _mapper.Map<WordClauseDto>(clause);
                    dto.UserName = userName==null?"":userName;

                    var catName = _dbContext.WordClauseCategories.Include(p => p.WordClauseCategoryTranslates).FirstOrDefault(p => p.Id == clause.CategoryId);
                    dto.CategoryName = catName == null ? "" : catName.WordClauseCategoryTranslates.FirstOrDefault(p => p.LanguageCulture == culture)?.CategoryName;

                    var dict = await _dbContext.Dictionaries.FindAsync(clause.DictionaryId);
                    dto.DictionaryName = dict == null ? "" : dict.Language;
                    result.Add(dto);
                }
                return result;
            }
            return null;
        }

        public List<AudioFileForClauseDto> GetAudioFileForClausebyID(int id)
        {
            var res = _dbContext.AudioFileForClauses.Where(p => p.Id == id);
            if(res != null)
            {
                return _mapper.Map<List<AudioFileForClauseDto>>(res);
            }
            return null;
        }



        public async Task<EditWordClauseDto> GetWordClauseByIdAsync(int id)
        {            
            try
            {
                var res = await _dbContext.WordClauses.FindAsync(id);
                
                if (res != null)
                {
                    return _mapper.Map<EditWordClauseDto>(res);
                }
                return null;
            }catch(Exception e)
            {
                return null;
            }
        }

        public async Task<WordClauseCategoryDto> GetWordClauseCategoryByIdAsync(int id)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var res = await _dbContext.WordClauseCategories.Include(p => p.WordClauseCategoryTranslates).SingleOrDefaultAsync(p => p.Id == id);
            if (res != null)
            {
                return _mapper.Map<WordClauseCategoryDto>(res);
            }
            return null;
        }

        public Responce CreateAudiFileForClause(CreateAudioFileForClauseDto model)
        {
            try
            {
                var res = _mapper.Map<AudioFileForClause>(model);
                if (res != null) {
                    _dbContext.AudioFileForClauses.Add(res);
                    return ResponceGenerator.GetResponceModel(true, "", res);
                }
            }catch(Exception e)
            {
                return ResponceGenerator.GetResponceModel(false, e.Message, model);
            }
            return ResponceGenerator.GetResponceModel(false, "Unknow error accured", model);
        }
    }
}
