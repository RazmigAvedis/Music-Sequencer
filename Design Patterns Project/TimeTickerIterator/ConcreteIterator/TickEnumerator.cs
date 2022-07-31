using Design_Patterns_Project.TickIterator.ConcreteAggregate;
using Design_Patterns_Project.TickIterator.IteratorBase;
using Design_Patterns_Project.TimeTickerIterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.TickIterator.ConcreteIterator
{
    public class TickEnumerator : ITickIterator
    {
        private TickAggregate _aggregate;
        int _position;

        public TickEnumerator(TickAggregate aggregate)
        {
            _aggregate = aggregate;
        }
        
        public void MoveFirst()
        {
            if(_aggregate.Count==0)
            {
                throw new InvalidOperationException();
            }
            _position = 0;
        }

        public void MoveNext()
        {
            _position++;

            if (_position >= _aggregate.Count)
                MoveFirst();
        }

        public Tick Current
        {
            get
            {
                if (_position < _aggregate.Count) return _aggregate[_position];
                throw new InvalidOperationException();
            }
        }
        
        public void Reset()
        {
            _position = -1;
        }
    }
}
