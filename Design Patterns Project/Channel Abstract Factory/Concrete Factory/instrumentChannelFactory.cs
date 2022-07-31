using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Factory;
using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Factory
{
    public class instrumentChannelFactory:IChannelFactory
    {
        public Channel createChannel()
        {
            return new instrumentChannel();
        }

        public ChannelTrack createChannelTrack(int channelId)
        {
            return new instrumentChannelTrack(channelId);
        }
    }
}
