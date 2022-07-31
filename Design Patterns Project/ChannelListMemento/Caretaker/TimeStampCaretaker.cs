using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using Design_Patterns_Project.Singleton;
using Design_Patterns_Project.ChannelListMemento.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Project.ChannelListMemento.Caretaker
{
    public class TimeStampCaretaker
    {
        readonly Stack<TimeStampMemento> _mementos = new Stack<TimeStampMemento>();

        public TimeStampMemento GetMemento()
        {
            return _mementos.Pop();
        }

        public void Add(TimeStampMemento newTimestampValuesMemento)
        {
            _mementos.Push(newTimestampValuesMemento);
        }

        public Stack<TimeStampMemento> GetStack()
        {
            return _mementos;
        }
    }
}
