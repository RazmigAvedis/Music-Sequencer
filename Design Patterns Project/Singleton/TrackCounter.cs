using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Project.Singleton
{
    class TrackCounter
    {
        public static volatile TrackCounter _trackCounter;
        private static object _lockThis = new object();

        private TrackCounter()
        {
            _TrackCounter = 0;
        }

        public static TrackCounter GetTrackCounter()
        {
            if (_trackCounter == null)
            {
                lock (_lockThis)
                {
                    if (_trackCounter == null) _trackCounter = new TrackCounter();
                }
            }
            return _trackCounter;
        }

        public int _TrackCounter { set; get; }

        public void incrementCounter()
        {
            GetTrackCounter()._TrackCounter += 110;
        }
    }
}