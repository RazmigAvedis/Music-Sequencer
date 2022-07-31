using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Project.TimeTickerIterator
{
   public class Tick
    {
        int i { get; set; }

        public Tick(int x)
        {
            i = x;
        }

        public int GetTick()
        {
            return i;
        }
    }
}
