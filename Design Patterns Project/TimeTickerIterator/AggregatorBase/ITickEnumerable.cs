using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns_Project.TickIterator.IteratorBase;

namespace Design_Patterns_Project.TickIterator.AggregatorBase
{
    public interface ITickEnumerable
    {
        ITickIterator GetIterator();
    }                                                                                                       
}
