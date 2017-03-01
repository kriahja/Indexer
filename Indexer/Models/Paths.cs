using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer.model
{
    public class Paths
    {
        public int id { get; }
        private String path { get; set; }

        public ICollection<object> Words { get; internal set; }
    }
}
