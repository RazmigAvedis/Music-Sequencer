using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using System.Collections.Generic;

namespace Design_Patterns_Project.UIObserver.ConcreteSubject
{
    public class ConcreteChannelsSubject : SubjectBase.SubjectBase
    {
        Dictionary<int, Channel> channellist;

        public ConcreteChannelsSubject()
        {
            channellist = new Dictionary<int, Channel>();
        }

        public void Add(Channel channel)
        {
            channellist.Add(channel.Id, channel);
            Notify();
        }

        public void Remove(int id)
        {
            channellist.Remove(id);
            Notify();
        }

        public Dictionary<int,Channel> ChannelList
        {
            set { channellist = value; }
            get { return channellist; }
        }

        public override void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
