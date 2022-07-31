using Design_Patterns_Project.Builder.Builder;
using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using Design_Patterns_Project.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.Builder.Director
{
    public class ChannelCreator
    {
        private readonly ChannelBuilder _builder;

        public ChannelCreator(ChannelBuilder builder)
        {
            _builder = builder;
        }

        public void CreateChannel()
        {
            _builder.CreateChannel(); // create the channel
            _builder.CreateChannelTrack(); // create its Track UI

            ChannelList.GetChannelListObject()._ChannelList.Add(_builder.GetChannel()); // put the Channel in the ChannelList
        }

        public Channel GetChannel()
        {
            return _builder.GetChannel();
        }
    }
}
