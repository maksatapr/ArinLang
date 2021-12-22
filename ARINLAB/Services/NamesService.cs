﻿using ARINLAB.Services.ImageService;
using AutoMapper;
using DAL.Data;
using DAL.Models;
using DAL.Models.Dto.NamesDTO;
using DAL.Models.ResponceModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARINLAB.Services
{
    public class NamesService : INamesService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IImageService _imageService;
        private readonly IMapper _mapper;

        public NamesService(ApplicationDbContext applicationDb, IImageService imageService, IMapper mapper)
        {
            _dbContext = applicationDb;
            _imageService = imageService;
            _mapper = mapper;
        }
        public async Task<Responce> CreateImageforNameAsync(CreateNameImagesDto image)
        {
            NameImages model = new();            
            try
            {
                if(image != null)
                {
                    model.NamesId = image.NamesId;
                    if (image.ImageUri != null)
                    {
                        model.ImageUri = await _imageService._UploadImage(image.ImageUri, "Names");
                        _dbContext.NameImages.Add(model);
                        _dbContext.SaveChanges();
                        return ResponceGenerator.GetResponceModel(true, "Success", model);
                    }
                }                
            }
            catch(Exception e)
            {
                return ResponceGenerator.GetResponceModel(false, e.Message, image);
            }
            return ResponceGenerator.GetResponceModel(false, "Image is not set", image);
        }

        public async Task<Responce> CreateNameAsync(CreateNamesDto name)
        {
            try {
                var res = _mapper.Map<Names>(name);
                _dbContext.Names.Add(res);
                await _dbContext.SaveChangesAsync();
                return ResponceGenerator.GetResponceModel(true, "Success", name);
            }
            catch(Exception e)
            {
                return ResponceGenerator.GetResponceModel(false, e.Message, name);
            }
        }

        public async Task<Responce> DeleteImageforNameAsync(int id)
        {
            var res = await _dbContext.NameImages.FindAsync(id);
            if (res != null)
            {
                _imageService._DeleteImage(res.ImageUri, "Names");
                _dbContext.NameImages.Remove(res);
                await _dbContext.SaveChangesAsync();
                return ResponceGenerator.GetResponceModel(false, "", res);
            }
            return ResponceGenerator.GetResponceModel(false, $"Does not found the image for word with id={id}", null);
        }

        public async Task<Responce> DeleteNameAsync(int id)
        {
            try
            {
                var res = await _dbContext.Names.FindAsync(id);
                if (res != null)
                {
                    _dbContext.Names.Remove(res);
                    await _dbContext.SaveChangesAsync();
                    var images = _dbContext.NameImages.Where(p => p.NamesId == id);
                    foreach(var image in images)
                    {
                        _imageService._DeleteImage(image.ImageUri, "Names");
                        _dbContext.NameImages.Remove(image);                        
                    }
                    await _dbContext.SaveChangesAsync();
                    return ResponceGenerator.GetResponceModel(true, "Success", res);
                }
            }catch(Exception e)
            {
                return ResponceGenerator.GetResponceModel(false, e.Message, null);
            }
            return ResponceGenerator.GetResponceModel(false, $"Failed to find Name with id={id}", null);
        }

        public Responce EditName(NamesDto name)
        {
            try
            {
                name.NameImages = null;
                var res = _mapper.Map<Names>(name);
                _dbContext.Update(res);
                _dbContext.SaveChanges();
                return ResponceGenerator.GetResponceModel(true, "", res);
            }catch(Exception e)
            {
                return ResponceGenerator.GetResponceModel(false, e.Message, null);
            }
        }

        public List<NamesDto> GetAllNames()
        {
            try
            {
                return _mapper.Map<List<NamesDto>>(_dbContext.Names.Include(p => p.NameImages));
            }catch(Exception e)
            {
                return null;
            }
        }

        public List<NameImagesDto> GetAllNamesImagesByNameId(int id)
        {
            try
            {
                return _mapper.Map<List<NameImagesDto>>(_dbContext.NameImages.Where(p => p.NamesId == id));
            }catch(Exception e)
            {
                return null;
            }
            
        }

        public async Task<NamesDto> GetNameByIdAsync(int id)
        {
            try
            {
                var res = _dbContext.Names.Include(p => p.NameImages).FirstOrDefault(p => p.Id == id);
                if (res != null)
                {
                    return _mapper.Map<NamesDto>(res);
                }
            }catch(Exception e)
            {
                return null;
            }
            return null;
        }

        public async Task<NameImagesDto> GetNameImageByImageIdAsync(int id)
        {
            try
            {
                var res = await _dbContext.NameImages.FindAsync(id);
                if(res != null)
                {
                    return _mapper.Map<NameImagesDto>(res);
                }
            }catch(Exception e)
            {
                return null;
            }
            return null;
        }
    }
}