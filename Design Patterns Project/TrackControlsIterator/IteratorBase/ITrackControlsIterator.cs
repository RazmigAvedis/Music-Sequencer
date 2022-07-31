using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.TrackControlsIterator.IteratorBase
{
    public interface ITrackControlsIterator
    {
        void MoveFirst();
        void Reset();
        bool MoveNext();
        Control Current { get; }
    }
}
