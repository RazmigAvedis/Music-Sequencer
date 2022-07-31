using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Project.Builder.Builder
{
    public abstract class ChannelBuilder
    {
        protected Channel channel;

        public Channel GetChannel()
        {
            return channel;
        }

        public abstract void CreateChannel();
        public abstract void CreateChannelTrack();
    }
}
