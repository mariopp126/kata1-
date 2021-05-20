using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata1_Anagrams
{
    public class GetAnagrams
    {
        public IEnumerable<string> Get(string path)
        {
            return File.ReadAllLines(path)
            .GroupBy(e => string.Concat(e.OrderBy(b => b)))
            .Where(e => e.Count() > 1)
            .Select(e =>
            {
                return e.Key + " " + e.FirstOrDefault();
            }
           
            );
        }
    }
}
