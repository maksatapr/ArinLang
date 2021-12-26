﻿using DAL.Models.Dto.NamesDTO;
using DAL.Models.ResponceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARINLAB.Services
{
    public interface INamesService 
    {
        public Task<NamesDto> GetNameByIdAsync(int id);
        public List<NamesDto> GetAllNames();
        public Task<Responce> DeleteNameAsync(int id);
        public Responce EditName(NamesDto name);
        public Task<Responce> CreateNameAsync(CreateNamesDto name);
        public List<NameImagesDto> GetAllNamesImagesByNameId(int id);
        public Task<NameImagesDto> GetNameImageByImageIdAsync(int id);
        public Task<Responce> DeleteImageforNameAsync(int id);
        public Task<Responce> CreateImageforNameAsync(CreateNameImagesDto image);

        public  Task<Responce> ApproveImage(int image_id, bool approve);

        public List<NamesDto> GetRandom_N_Names(int n);

        public List<NamesDto> GetAllNamesWithDictId(int id);
    }
}
