using Indexer.model;
using Indexer.Repository;
using Indexer.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class Facade
    {
        private IRepository<Paths> pathRepo;
        private IRepository<Words> wordRepo;


        public IRepository<Paths> GetPathsRepository()
        {
            if (pathRepo == null)
            {
                pathRepo = new PathsRepository();
            }
            return pathRepo;
        }
        public IRepository<Words> GetWordsRepository()
        {
            if (wordRepo == null)
            {
                wordRepo = new WordsRepository();
            }
            return wordRepo;
        }
    }
}
