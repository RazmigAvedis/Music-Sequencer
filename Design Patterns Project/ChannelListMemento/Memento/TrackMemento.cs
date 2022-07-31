using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using Design_Patterns_Project.ChannelListMemento.Originator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Project.ChannelListMemento.Memento
{
    public class TrackMemento
    {
        public Dictionary<float,string> timestampValues;

        public TrackMemento(Dictionary<float,string> timeStamp)
        {
            timestampValues = timeStamp ;
        }
    }
}
