using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopAcademyPrize
{
    internal class buffer
    {
        public class set
        {
            public string Name { get; set; }
            public int Value { get; set; }
            public string Put { get; set; }
        }
        public static List<set> list = new List<set>();
    }
}
