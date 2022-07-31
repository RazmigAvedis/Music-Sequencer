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
    public class TrackCaretaker
    {
        readonly Stack<TrackMemento> _mementos = new Stack<TrackMemento>();

        public TrackMemento GetMemento()
        {
            return _mementos.Pop();
        }

        public void Add(TrackMemento newTrack)
        {
            _mementos.Push(newTrack);
        }
    }
}
