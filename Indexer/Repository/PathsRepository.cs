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
    public class PathsRepository : IRepository<Paths>
    {
        public void Add(Paths path)
        {
            using (var ctx = new IndexContext())
            {
                ctx.Paths.Add(path);
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Paths item)
        {
            throw new NotImplementedException();
        }

        public Paths Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Paths> ReadAll()
        {
            throw new NotImplementedException();
        }
    }
}
