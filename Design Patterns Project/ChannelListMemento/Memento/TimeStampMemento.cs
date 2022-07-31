using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using Design_Patterns_Project.ChannelListMemento.Originator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.ChannelListMemento.Memento
{
    public class TimeStampMemento
    {
        public List<string> timestampValuesMementoMember;

        public TimeStampMemento(List<string> timeStampvals)
        {
            timestampValuesMementoMember = timeStampvals ;
        }
    }
}
