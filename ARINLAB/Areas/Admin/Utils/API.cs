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
    }
}
