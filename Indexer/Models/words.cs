using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer.model
{
    public class Words
    {
        public int id { get; }
        private String word { get; set; }

        public ICollection<object> Paths { get; internal set; }
    }
}
