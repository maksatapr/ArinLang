using ARINLAB.Services.ImageService;
using ARINLAB.Services.SessionService;
using AutoMapper;
using DAL.Data;
using DAL.Models;
using DAL.Models.Dto;
using DAL.Models.ResponceModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARINLAB.Services
{
    public class WordServices : IWordServices
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IImageService _fileService;
        private readonly UserDictionary _userDict;
        public WordServices(ApplicationDbContext applicationDbContext, IMapper mapper, IImageService imageService
                            , UserDictionary u
            )
        {
            _dbContext = applicationDbContext;
            _mapper = mapper;
            _fileService = imageService;
            _userDict = u;
        }
        public async Task<Responce> addWordAsync(CreateWordDto word)
        {
            Responce result = new Responce();
            try
            {
                var _word = _mapper.Map<Word>(word);
                _word.ArabWord = _word.ArabWord.Trim();
                _word.OtherWord = _word.OtherWord.Trim().ToLower();
                var gotAlready = new List<Word>(_dbContext.Words.Where(p => p.OtherWord.CompareTo(_word.OtherWord) == 0 && p.ArabWord.CompareTo(_word.ArabWord) == 0).AsNoTracking());
                if(gotAlready != null && gotAlready.Count() > 0)
                {
                    return ResponceGenerator.GetResponceModel(false, "This word is already in the Dictionary", _word);
                }
                var data = _dbContext.Words.AddAsync(_word).Result;
                await _dbContext.SaveChangesAsync();
                if (data.IsKeySet)
                {
                    return ResponceGenerator.GetResponceModel(true, "", data.Entity);
                }
                else
                {
                    return ResponceGenerator.GetResponceModel(false, $"Could Not add Word. {data.State}", data);
                }
            }catch(Exception e) {
                return ResponceGenerator.GetResponceModel(false, e.Message, null);
            }
        }

        public async Task<Responce> CreateWordSentenceAsync(CreateWordSentencesDto createWordModel)
        {
            try
            {
                if (createWordModel != null)
                {
                    var newSentences = _mapper.Map<WordSentences>(createWordModel);
                    newSentences.ArabSentence = newSentences.ArabSentence.ToLower();
                    newSentences.OtherSentence = newSentences.OtherSentence.ToLower();
                    var data = await _dbContext.WordSentences.AddAsync(newSentences);
                    await _dbContext.SaveChangesAsync();
                    return ResponceGenerator.GetResponceModel(true, "", data);
                }
                return ResponceGenerator.GetResponceModel(false, "", createWordModel);
            }catch(Exception e)
            {
                return ResponceGenerator.GetResponceModel(false, e.Message, createWordModel);
            }
        }

        public async Task<Responce> Delete(int id)
        {
            var res = await _dbContext.Words.FindAsync(id);
            try
            {
                if (res != null)
                {
                    var sentences = _dbContext.AudioFiles.Where(p => p.WordId == id).AsNoTracking();
                    if (sentences != null)
                    {
                        foreach (var item in sentences)
                        {
                            _fileService.DeleteImage(item.ArabVoice);
                            _fileService.DeleteImage(item.OtherVoice);
                        }
                    }
                    _dbContext.Words.Remove(res);
                    await _dbContext.SaveChangesAsync();
                    return ResponceGenerator.GetResponceModel(true, "", res);
                }
                return ResponceGenerator.GetResponceModel(false, "Cannot delete", null);
            }catch(Exception e)
            {
                return ResponceGenerator.GetResponceModel(false, "Some Error Accured", null);
            }
        }

        public async Task<Responce> DeleteSentence(int id)
        {            
            var res = await _dbContext.WordSentences.FindAsync(id);
            if (res != null)
            {
                _dbContext.WordSentences.Remove(res);
                await _dbContext.SaveChangesAsync();
                return ResponceGenerator.GetResponceModel(true, "", res);
            }
            return ResponceGenerator.GetResponceModel(false, "", null);
        }

        public async Task<Responce> EditWordApproveByIdAsync(int id, bool approve)
        {
            var res = await _dbContext.Words.FindAsync(id);
            if(res != null)
            {
                res.IsApproved = approve;
                res = _dbContext.Words.Update(res).Entity;
                await _dbContext.SaveChangesAsync();
                return ResponceGenerator.GetResponceModel(true, "Success", res);
            }
            return ResponceGenerator.GetResponceModel(false, "Error", res);
        }

       
        public async Task<Responce> editWordAsync(EditWordDto editWordDto)
        {
            if (editWordDto == null)
                return ResponceGenerator.GetResponceModel(false, "Data is being modifyed is null", null);
            Word _word = new Word {
                ArabWord = editWordDto.ArabWord,
                DictionaryId = editWordDto.DictionaryId,
                Id = editWordDto.Id,
                IsApproved = editWordDto.IsApproved,
                UserId = editWordDto.UserId,
                OtherWord = editWordDto.OtherWord,
                ImageForShare = editWordDto.ImageForShare
            };

            Responce result = new Responce();
            try
            {                
                var data = _dbContext.Words.Update(_word);
                await _dbContext.SaveChangesAsync();
                if (data.IsKeySet)
                {
                    return ResponceGenerator.GetResponceModel(true, "", data.Entity);
                }
                else
                {
                    return ResponceGenerator.GetResponceModel(false, $"Could Not update Word. {data.State}", data);
                }
            }
            catch (Exception e)
            {
                return ResponceGenerator.GetResponceModel(false, e.Message, null);
            }
        }

        public async Task<Responce> EditWordSentenceApproveByIdAsync(int id, bool approve)
        {
            var res = await _dbContext.WordSentences.FindAsync(id);
            if (res != null)
            {
                res.IsApproved = approve;
                res = _dbContext.WordSentences.Update(res).Entity;
                await _dbContext.SaveChangesAsync();
                return ResponceGenerator.GetResponceModel(true, "Success", res);
            }
            return ResponceGenerator.GetResponceModel(false, "Error", res);
        }

        public async Task<Responce> EditWordSentenceAsync(WordSentencesDto editWordSentence)
        {
            try
            {
                if (editWordSentence != null)
                {
                    var editWord = _mapper.Map<WordSentences>(editWordSentence);
                    editWord.ArabSentence = editWord.ArabSentence.ToLower();
                    editWord.OtherSentence = editWord.OtherSentence.ToLower();
                    var data = _dbContext.WordSentences.Update(editWord).Entity;
                    _ = await _dbContext.SaveChangesAsync();
                    return ResponceGenerator.GetResponceModel(true, "", data);
                }
                return ResponceGenerator.GetResponceModel(false, "", editWordSentence);
            }
            catch(Exception e)
            {
                return ResponceGenerator.GetResponceModel(false, e.Message, editWordSentence);
            }
        }

        public List<WordDto> GetAllWords(int pageNumber, int count)
        {
            try
            {
                var result = _mapper.Map<List<WordDto>>(_dbContext.Words.Skip((pageNumber - 1) * count).Take(count).AsNoTracking());
                int n = 1 + (pageNumber - 1) * count;
                foreach (var item in result)
                {
                    item.Dictionary = _dbContext.Dictionaries.Find(item.DictionaryId).Language;
                    item.Number = n;
                    ++n;
                }
                return result;
            }
            catch(Exception e)
            {
                return new List<WordDto>();
            }
            
        }

        public List<WordDto> GetAllWords(string userId, int pageNumber, int count)
        {
            try
            {
                var result = _mapper.Map<List<WordDto>>(_dbContext.Words.Where(p => p.UserId == userId).Skip((pageNumber - 1) * count).Take(count).AsNoTracking());
                int n = 1 + (pageNumber - 1) * count;
                foreach (var item in result)
                {
                    item.Dictionary = _dbContext.Dictionaries.Find(item.DictionaryId).Language;
                    item.Number = n;
                    ++n;
                }
                return result;
            }
            catch (Exception e)
            {
                return new List<WordDto>();
            }

        }

        public List<WordDto> GetAllWordsByUserId(string userId)
        {
            var result = _mapper.Map<List<WordDto>>(_dbContext.Words.Where(p => p.UserId == userId).Include(p => p.AudioFiles).Include(p => p.WordSentences).AsNoTracking());
            foreach(var item in result)
            {
                item.Dictionary = _dbContext.Dictionaries.Find(item.DictionaryId).Language;
            }
            return result;
        }

        public List<WordSentencesDto> GetAllWordSentences()
        {
            throw new NotImplementedException();
        }

        public List<WordSentencesDto> GetAllWordSentencesByWordId(int wordId)
        {
            try
            {
                var res = _dbContext.WordSentences.Where(p => p.WordId == wordId);
                return _mapper.Map<List<WordSentencesDto>>(res);
            }catch(Exception e)
            {
                return new List<WordSentencesDto>();
            }
        }

        public async Task<WordDto> GetWordByIdAsync(int id)
        {
            try
            {
                var r = _mapper.Map<WordDto>(await _dbContext.Words.FindAsync(id));
                r.Dictionary = (await _dbContext.Dictionaries.FindAsync(r.DictionaryId))?.Language;
                return r;
            }catch(Exception e)
            {
                return null;
            }
        }

        public async Task<WordSentencesDto> GetWordSentencesById(int id)
        {
            try
            {
                var res = await _dbContext.WordSentences.FindAsync(id);
                if (res != null)
                    return _mapper.Map<WordSentencesDto>(res);
                return null;
            }catch(Exception e)
            {
                return null;
            }
        }

        public List<WordDto> GetWordsWithApproval(bool isApproved)
        {
            var res = _mapper.Map<List<WordDto>>(_dbContext.Words.Where(p => p.IsApproved == true).Include(p => p.AudioFiles).Include(p => p.WordSentences));
            foreach(var r in res)
            {
                r.Dictionary = _dbContext.Dictionaries.Find(r.DictionaryId)?.Language;
            }
            return res;
        }

        public List<WordDto> GetRandom_N_Words(int n)
        {
            try
            {
                var dictId = _userDict.GetDictionaryId();
                Random rnd = new Random(DateTime.UtcNow.Millisecond);
                int rn = rnd.Next();
                var res = _dbContext.Words.Where(p => p.DictionaryId == dictId && p.IsApproved == true).OrderBy(p => rn).Take(n).ToList();
                if (res != null)
                {
                    var r = _mapper.Map<List<WordDto>>(res);
                    foreach(var item in r)
                    {
                        item.Dictionary = _dbContext.Dictionaries.Find(item.DictionaryId)?.Language;
                    }
                    return r;
                }
                else
                {
                    return null;
                }
            }catch(Exception e)
            {
                return null;
            }
        }

        public List<WordDto> GetAllWordsWithDictId(int id)
        {
            try
            {
                var res1 = _dbContext.Words.Where(p => p.DictionaryId == id && p.IsApproved == true);
                var res = _mapper.Map<List<WordDto>>(res1);
                foreach (var r in res)
                {
                    r.Dictionary = _dbContext.Dictionaries.Find(r.DictionaryId)?.Language;
                }
                return res;
            }
            catch (Exception e)
            {
                return new List<WordDto>();
            }
        }

    }
}
