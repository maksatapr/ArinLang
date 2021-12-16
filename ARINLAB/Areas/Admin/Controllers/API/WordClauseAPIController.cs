﻿using ARINLAB.Services;
using AutoMapper;
using DAL.Data;
using DAL.Models.Dto;
using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARINLAB.Areas.Admin.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordClauseAPIController : ControllerBase
    {
        private readonly IWordClauseService _wordClauseServices;
        private readonly IMapper _mapper;
        public WordClauseAPIController(IWordClauseService wordClauseService, IMapper mapper)
        {
            _wordClauseServices = wordClauseService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<object> GetAsync(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<WordClauseDto>((await _wordClauseServices.GetAllWordClausesAsync()).AsQueryable(), loadOptions);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = Roles.Admin)]
        public async Task DeleteAsync(int id)
        {
            await _wordClauseServices.DeleteWordClause(id);
        }
    }
}
