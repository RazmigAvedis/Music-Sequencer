using Design_Patterns_Project.ChannelListMemento.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.ChannelListMemento.Originator
{
    public class TimeStamp
    {
        public List<string> timestampValues;

        public TimeStamp(List<string> timeStamp)
        {
            timestampValues = timeStamp;
        }

        public TimeStampMemento CreateUnDo()
        {
            return new TimeStampMemento(timestampValues);
        }

        public void UnDo(TimeStampMemento memento)
        {
            timestampValues = memento.timestampValuesMementoMember;
        }
    }
}
