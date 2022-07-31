using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Product;
using Design_Patterns_Project.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.SoundPlayChainOfResponsibility.ConcreteHandlers
{
    public class InvokeAutomationLinks : HandlerBase.SoundPlayer
    {
        public override void Process(int playPosition)
        {
            foreach (Channel channel in ChannelList.GetChannelListObject()._ChannelList.ChannelList.Values)
            {
                if(channel.GetType().ToString()== "Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Product.automationChannel")
                {
                    if (channel.mainControls.On.Checked)//If the automation channel is on, notify observers of the automation clip to self invoke and get their volumes changed
                    {
                        var ch = (automationChannel)channel;
                        var numericUDList = (NumericUpDown)ch.channelTrack[playPosition];
                        ch.Notify(float.Parse(numericUDList.Value.ToString()));//notify 
                    }
                }
            }
            if(_successor!=null)
            {
                _successor.Process(playPosition);
            }
        }
    }
}
