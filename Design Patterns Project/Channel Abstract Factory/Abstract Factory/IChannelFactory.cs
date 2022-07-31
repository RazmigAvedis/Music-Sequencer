using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;

namespace Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Factory
{
    public interface IChannelFactory
    {
        Channel createChannel();
        ChannelTrack createChannelTrack(int channelId);
    }
}
