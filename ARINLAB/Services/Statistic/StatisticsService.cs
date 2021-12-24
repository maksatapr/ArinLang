using ARINLAB.Models;
using DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARINLAB.Services.Statistic
{
    public class StatisticsService : IStatisticsService
    {
        private readonly ApplicationDbContext _dbContext;
        public StatisticsService(ApplicationDbContext applicationDb)
        {
            _dbContext = applicationDb;
        }
        public List<StatisticCard> GetStatisticsCard()
        {
            //////////// Statistics for Word ////////////
            int wordCount = _dbContext.Words.Count();
            int Editers = _dbContext.Words.Select(p => p.UserId).Distinct().Count();
            StatisticCard word = new StatisticCard()
            {
                Editers = Editers,
                totalCount = wordCount,
                Type = WordType.Word
            };

            //////////// Statistics for WordSentence ////////////
            int wordSCount = _dbContext.WordSentences.Count();
            int SEditers = _dbContext.WordSentences.Select(p => p.UserId).Distinct().Count();
            StatisticCard sentences = new StatisticCard()
            {
                Editers = SEditers,
                totalCount = wordSCount,
                Type = WordType.WordSentence
            };

            //////////// Statistics for WordClauses ////////////
            int wordClauses = _dbContext.WordClauses.Count();
            int CEditors = _dbContext.WordClauses.Select(p => p.UserId).Distinct().Count();
            StatisticCard clauses = new StatisticCard()
            {
                Editers = CEditors,
                totalCount = wordClauses,                
                Type = WordType.WordClause
            };

            //////////// Statistics for Names ////////////
            int names = _dbContext.Names.Count();
            int NameEditors = _dbContext.Names.Select(p => p.UserId).Distinct().Count();
            StatisticCard name = new StatisticCard()
            {
                Editers = NameEditors,
                totalCount = names,
                Type = WordType.Name
            };

            return new List<StatisticCard>() { word, sentences, clauses, name };
        }
    }
}
