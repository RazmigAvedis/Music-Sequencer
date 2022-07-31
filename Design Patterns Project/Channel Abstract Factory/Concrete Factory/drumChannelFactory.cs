using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Factory;
using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Product;

namespace Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Factory
{
    public class drumChannelFactory:IChannelFactory
    {
        public Channel createChannel()
        {
            return new drumsChannel();
        }

        public ChannelTrack createChannelTrack(int channelId)
        {
            return new drumsChannelTrack(channelId);
        }
    }
}
