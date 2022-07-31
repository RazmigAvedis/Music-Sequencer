using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using Design_Patterns_Project.ChannelListMemento.Memento;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Design_Patterns_Project.UIObserver.SubjectBase;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns_Project.UIObserver.ConcreteSubject;

namespace Design_Patterns_Project.Singleton
{
    sealed class ChannelList
    {
        public static volatile ChannelList _channelList;
        private static object _lockThis = new object();

        private ChannelList()
        {
            _ChannelList = new ConcreteChannelsSubject();
        }

        public static ChannelList GetChannelListObject()
        {
            if (_channelList == null)
            {
                lock (_lockThis)
                {
                    if (_channelList == null) _channelList = new ChannelList();
                }
            }
            return _channelList;
        }
        
        public ConcreteChannelsSubject _ChannelList { set; get; }

        public static int GetListCount()
        {
            return GetChannelListObject()._ChannelList.ChannelList.Count();
        }
    }

}

