using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Product;
using Design_Patterns_Project.SamplesAdapter.Models;
using Design_Patterns_Project.SamplesAdapter.Target;
using Design_Patterns_Project.Singleton;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.SamplesAdapter.Adapter
{
    public class AutomationLinkAdapter: IGetSamplesAdapter
    {
        readonly sampleGroup AutomationLinks = new sampleGroup();

        public sampleGroup GetSamples()
        {
            return AutomationLinks;
        }

        public void SetSamples()
        {
            ChooseAutomationLink chooseAutomationLink = new ChooseAutomationLink();


            //Populate dataGridView
            foreach (Channel channel in ChannelList.GetChannelListObject()._ChannelList.ChannelList.Values )
            {
                if (channel.GetType().ToString() != "Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Product.automationChannel")
                {
                    bool found = false;
                    foreach (Channel observerChannel in ChannelList.GetChannelListObject()._ChannelList.ChannelList.Values)
                    {
                        if (observerChannel.GetType().ToString() == "Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Product.automationChannel")
                        {
                            var temp = (automationChannel)observerChannel;
                            foreach (var observer in temp.GetAllObservers())
                            {
                                if (channel.Id == observer.Id) found = true;
                            }
                        }

                    }

                    if(!found)
                    {
                        var temp=(DataGridView)chooseAutomationLink.Controls.Find("dataGridView_Controls",true).FirstOrDefault();
                        temp.Rows.Add(channel.Id.ToString(), channel.channelName.ToString(), "Volume");
                    }

                }
            }

            if (chooseAutomationLink.ShowDialog() == DialogResult.OK)
            {
                sampleGroup sampleGroup = new sampleGroup();
                var tempTag = (DataGridViewRow)chooseAutomationLink.Tag;
                AutomationLinks.Add(tempTag.Cells[0].Value.ToString(), tempTag.Cells[2].Value.ToString());
            }
            
        }
    }
}
