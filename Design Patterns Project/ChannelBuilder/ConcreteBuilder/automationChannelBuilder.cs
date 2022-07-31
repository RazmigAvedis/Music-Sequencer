using Design_Patterns_Project.Builder.Builder;
using Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Project.Builder.ConcreteBuilder
{
    public class automationChannelBuilder:ChannelBuilder
    {
        public override void CreateChannelTrack()
        {

            this.channel.channelTrack = new automationChannelFactory().createChannelTrack(channel.Id);
        }

        public override void CreateChannel()
        {
            this.channel = new automationChannelFactory().createChannel();
        }
    }
}
