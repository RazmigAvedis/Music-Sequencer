using Design_Patterns_Project.TickIterator.ConcreteAggregate;
using Design_Patterns_Project.TickIterator.IteratorBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Project.Singleton
{
    public class TrackTicks
    {
        public static volatile TrackTicks _trackTicks;
        private static object _lockThis = new object();

        private TrackTicks()
        {
            var _TrackTicksAggregate = new TickAggregate();
            _TrackTicksAggregate.Add(new TimeTickerIterator.Tick(0));
            _TrackTicksAggregate.Add(new TimeTickerIterator.Tick(1));
            _TrackTicksAggregate.Add(new TimeTickerIterator.Tick(2));
            _TrackTicksAggregate.Add(new TimeTickerIterator.Tick(3));
            _TrackTicksAggregate.Add(new TimeTickerIterator.Tick(4));
            _TrackTicksAggregate.Add(new TimeTickerIterator.Tick(5));
            _TrackTicksAggregate.Add(new TimeTickerIterator.Tick(6));
            _TrackTicksAggregate.Add(new TimeTickerIterator.Tick(7));

            _TrackTicks = _TrackTicksAggregate.GetIterator();
        }

        public static TrackTicks GetTrackTicks()
        {
            if (_trackTicks == null)
            {
                lock (_lockThis)
                {
                    if (_trackTicks == null) _trackTicks = new TrackTicks();
                }
            }
            return _trackTicks;
        }

        public ITickIterator _TrackTicks { set; get; }

        public void incrementCounter()
        {
            GetTrackTicks()._TrackTicks.MoveNext();
        }
    }
}
