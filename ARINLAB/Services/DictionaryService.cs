using AutoMapper;
using DAL.Data;
using DAL.Models;
using DAL.Models.Dto;
using DAL.Models.ResponceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARINLAB.Services
{
    public class DictionaryService : IDictionaryService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        public DictionaryService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public Responce CreateDictionary(CreateDictionaryDto createModel)
        {
            Responce result = new Responce();
            try
            {
                var newDict = _mapper.Map<Dictionary>(createModel);
                var data = _dbContext.Dictionaries.Add(newDict);
                _dbContext.SaveChanges();
                if (data.IsKeySet)
                {
                    return ResponceGenerator.GetResponceModel(true, "", data.Entity);
                }else
                {
                    return ResponceGenerator.GetResponceModel(false, "Could not add Dictionary", newDict);
                }

            }catch(Exception e)
            {
               return ResponceGenerator.GetResponceModel(false, e.Message, null);
            }
        }

        public async Task<Responce> DeleteDictionaryAsync(int id)
        {
            try
            {
                var result = await _dbContext.Dictionaries.FindAsync(id);
                if(result != null)
                {
                    var data = _dbContext.Dictionaries.Remove(result);
                    await _dbContext.SaveChangesAsync();
                    return ResponceGenerator.GetResponceModel(true, "", data);
                }
                else
                {
                    return ResponceGenerator.GetResponceModel(true, "No Data Found", null);
                }
            }catch(Exception e)
            {
                return ResponceGenerator.GetResponceModel(false, e.Message, null);
            }
        }

        public Responce EditDictionary(Dictionary edit)
        {
            Responce result = new Responce();
            try
            {              
                var data = _dbContext.Dictionaries.Add(edit);
                _dbContext.SaveChanges();
                return ResponceGenerator.GetResponceModel(true, "", data.Entity);                
            }
            catch (Exception e)
            {
                return ResponceGenerator.GetResponceModel(false, e.Message, null);
            }
        }

        public Responce GetAllDictionaries()
        {
            var result = _dbContext.Dictionaries;
            return ResponceGenerator.GetResponceModel(true, "", new List<Dictionary>(result));
        }

        public string GetDictionaryNameById(int id)
        {
            var dict = _dbContext.Dictionaries.Find(id);
            if (dict != null)
                return dict.Language;
            return "";
        }
    }
}
