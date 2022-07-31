
using Design_Patterns_Project.TickIterator.IteratorBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns_Project.TimeTickerIterator;
using Design_Patterns_Project.TickIterator.AggregatorBase;
using Design_Patterns_Project.TickIterator.ConcreteIterator;

namespace Design_Patterns_Project.TickIterator.ConcreteAggregate
{
    public class TickAggregate : ITickEnumerable
    {
        private List<Tick> _ticks = new List<Tick>();

        public Tick this[int index]
        {
            get { return _ticks[index]; }
        }

        public ITickIterator GetIterator()
        {
            return new TickEnumerator(this);
        }

        public int Count
        {
            get { return _ticks.Count; }
        }

        public void Add(Tick tick)
        {
            _ticks.Add(tick);
        }


    }
}
