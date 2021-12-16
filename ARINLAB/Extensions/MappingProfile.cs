using AutoMapper;
using DAL.Models;
using DAL.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARINLAB.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Language, LanguageDto>().ReverseMap();
            CreateMap<WordDto, Word>().ReverseMap();
            CreateMap<WordSentencesDto, WordSentences>().ReverseMap();
            CreateMap<CreateWordDto, Word>().ReverseMap();
            CreateMap<CreateWordDto, WordSentences>().ReverseMap();
            CreateMap<EditWordDto, Word>().ReverseMap();
            CreateMap<EditWordDto, WordDto>().ReverseMap();
            CreateMap<EditWordSentencesDto, WordSentences>().ReverseMap();
            CreateMap<CreateDictionaryDto, Dictionary>().ReverseMap();
            CreateMap<CreateAudioFileDto, AudioFile>().ReverseMap();
            CreateMap<CreateWordSentencesDto, WordSentences>().ReverseMap();
            CreateMap<CreateWordClauseDto, WordClause>().ReverseMap();
            CreateMap<EditWordClauseDto, WordClauseDto>().ReverseMap();
            CreateMap<WordClause, WordClauseDto>().ReverseMap();
            CreateMap<WordClauseCategory, CreateWordClauseCategoryDto>().ReverseMap();
            CreateMap<WordClauseCategoryDto, WordClauseCategory>().ReverseMap();
            CreateMap<Language, LanguageDto>().ReverseMap();

        }
    }
}
