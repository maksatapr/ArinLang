using AutoMapper;
using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARINLAB.Services
{
    public class FileServices
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        public FileServices(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<AudioFile> GetAudioFilesByWordId(int id)
        {
            try
            {
                var res = new List<AudioFile>(_dbContext.AudioFiles.Where(p => p.WordId == id));
                return res;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
