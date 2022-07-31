using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using Design_Patterns_Project.Singleton;
using Design_Patterns_Project.AutomationLinkObserver.ObserverBase;
using Design_Patterns_Project.MultipleControlPrototype.ConcretePrototype;
using Design_Patterns_Project.SamplesAdapter.Models;

namespace Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product
{
    public abstract class Channel:IChannelObserver
    {
        public int Id { set; get; }
        public string channelName { set; get; }
        public bool undoClicked { set; get; }
        public sampleGroup sampleData { set; get; }
        public ChannelTrack channelTrack { set; get; }
        public ChannelPrototype mainControls { set; get; }

        public virtual void channelInitialize()
        {
            int xpadding = 10;
            int tempxpos = 0;

            Id = ChannelList.GetListCount() == 0 ? 1 : ChannelList.GetChannelListObject()._ChannelList.ChannelList.Keys.Last() + 1;

            channelName = "Automation " + Id;
            
            mainControls = new ChannelPrototype().Clone() as ChannelPrototype;

            mainControls.On.Location = new Point(tempxpos+5, ChannelList.GetListCount() == 0 ? 10 : ChannelList.GetListCount() * 50 + 10);
            
            tempxpos += mainControls.On.Size.Width + xpadding;

            mainControls.Icon.Location = new Point(tempxpos, ChannelList.GetListCount() == 0 ? 0 : ChannelList.GetListCount() * 50 + 0);
            
            tempxpos += mainControls.Icon.Size.Width + xpadding;

            mainControls.Volume.Location = new Point(tempxpos, ChannelList.GetListCount() == 0 ? 10 : ChannelList.GetListCount() * 50 + 10);
            
            tempxpos += mainControls.Volume.Size.Width + xpadding;

            mainControls.selectSamplesButton.Location = new Point(tempxpos, ChannelList.GetListCount() == 0 ? 10 : ChannelList.GetListCount() * 50 + 10);
            
            tempxpos += mainControls.selectSamplesButton.Size.Width + xpadding;

            mainControls.channelDeleteButton.Location = new Point(tempxpos, ChannelList.GetListCount() == 0 ? 10 : ChannelList.GetListCount() * 50 + 10);
            mainControls.channelDeleteButton.Text = " ";
            
            tempxpos += mainControls.channelDeleteButton.Size.Width + xpadding;

        }

        public abstract void button_Click(object sender, EventArgs e);//when sampleSelectButton is pressed
        public abstract void Update(float valueToUpdateTo);

        public void deleteButton_Click(object sender, EventArgs e)
        {

            foreach(Channel channel in ChannelList.GetChannelListObject()._ChannelList.ChannelList.Values)
            {
                if(channel.GetType().ToString()== "Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Product.automationChannel")
                {
                    ((Concrete_Product.automationChannel)channel).Unregister(this);
                }
            }
            ChannelList.GetChannelListObject()._ChannelList.Remove(Id);
        }

        public void Update()
        {
            this.mainControls.On.Location = new Point(mainControls.On.Location.X, ChannelList.GetListCount() * 50 + 10);
            this.mainControls.Icon.Location = new Point(mainControls.Icon.Location.X, ChannelList.GetListCount() * 50 + 10);
            this.mainControls.Volume.Location = new Point(mainControls.Volume.Location.X, ChannelList.GetListCount() * 50 + 10);
            this.mainControls.channelDeleteButton.Location = new Point(mainControls.channelDeleteButton.Location.X, ChannelList.GetListCount() * 50 + 10);
            this.channelTrack.undoButton.Location = new Point(this.channelTrack.undoButton.Location.X, ChannelList.GetListCount() * 50 + 10);

            foreach (Control control in channelTrack)
            {
                control.Location = new Point(control.Location.X, ChannelList.GetListCount() * 50 + 10);
            }

            this.mainControls.selectSamplesButton.Location = new Point(this.mainControls.selectSamplesButton.Location.X, ChannelList.GetListCount() * 50 + 10);
        }
    }
}
