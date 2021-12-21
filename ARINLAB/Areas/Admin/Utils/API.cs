using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARINLAB.Areas.Admin.Utils
{
    public class API
    {
        public static string GetAllWordClauseCategories { get; } = "/api/WordClauseCategoryAPI";
        public static string GetAllWordClauses { get; } = "/api/WordClauseAPI";     
        public static string GetAllWordClauseAudioFiles { get; } = "/api/WordClauseAudioAPI";
        public static string GetAllMenu { get; } = "/api/MenuAPI";
        public static string GetAllNews { get; } = "/api/NewsAPI";
        public static string GetAllNewsCategory { get; } = "/api/NewsAPI/GetAllNewsCategories";
        public static string GetAllPages { get; } = "/api/PagesAPI";
    }
}
