using Design_Patterns_Project.TrackControlsIterator.ConcreteAggregate;
using Design_Patterns_Project.TrackControlsIterator.IteratorBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.TrackControlsIterator.ConcreteIterator
{
    public class TrackControlsEnumerator : ITrackControlsIterator
    {
        private TrackControlsAggregate _aggregate;
        int position;

        public TrackControlsEnumerator(TrackControlsAggregate aggregate)
        {

        }

        public Control Current => throw new NotImplementedException();

        public void MoveFirst()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
