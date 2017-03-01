using Indexer.dal;
using Indexer.model;
using Indexer.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer.Repository
{
    public class WordsRepository : IRepository<Words>
    {

        public void Add(Words word)
        {
            using (var ctx = new IndexContext())
            {
                ctx.Words.Add(word);
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Words item)
        {
            throw new NotImplementedException();
        }

        public Words Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Words> ReadAll()
        {
            throw new NotImplementedException();
        }
    }
}
