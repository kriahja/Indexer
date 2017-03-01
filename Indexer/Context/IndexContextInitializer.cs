using Indexer.dal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer.Context
{
   public class IndexContextInitializer : CreateDatabaseIfNotExists<IndexContext>
    {

    }
}
