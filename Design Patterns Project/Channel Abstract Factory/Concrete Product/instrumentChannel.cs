using Design_Patterns_Project.AutomationLinkObserver.ObserverBase;
using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using Design_Patterns_Project.MultipleControlPrototype.ConcretePrototype;
using Design_Patterns_Project.SamplesAdapter.Adapter;
using Design_Patterns_Project.Singleton;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Product
{
    class instrumentChannel : Channel,IChannelObserver
    {

        public instrumentChannel()
        {
            channelInitialize();
        }

        public override void channelInitialize()
        {
            base.channelInitialize();

            Id = ChannelList.GetListCount() == 0 ? 1 : ChannelList.GetChannelListObject()._ChannelList.ChannelList.Keys.Last() + 1;

            channelName = "Instrument " + Id;

            mainControls.On.Name = "Instrument CheckBox" + Id.ToString();
            
            mainControls.Icon.Name = "Instrument PictureBox" + Id.ToString();
            try
            {
                mainControls.Icon.BackgroundImage = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\Icons\Instrument.png"));
            }
            catch { }
            mainControls.Volume.Name = "Instrument Volume" + Id.ToString();
            
            mainControls.selectSamplesButton.Name = "Instrument Sample Select Button " + Id.ToString();
            mainControls.selectSamplesButton.Text = "Select Instrument";
            mainControls.selectSamplesButton.Click += new EventHandler(button_Click);
            
            mainControls.channelDeleteButton.Name = "Instrument Channel Delete Button " + Id.ToString();
            mainControls.channelDeleteButton.Text = " ";
            mainControls.channelDeleteButton.Click += new EventHandler(deleteButton_Click);
            

        }

        public override void button_Click(object sender, EventArgs e)
        {
            var instrumentSamplesAdapter = new InstrumentGetSamplesAdapter();
            instrumentSamplesAdapter.SetSamples();
            sampleData = instrumentSamplesAdapter.GetSamples();
            if (sampleData != null && sampleData.Count > 1) // If directory found but no samples are inside
            {
                this.channelTrack.ForEach((control) =>
            {
                ((ComboBox)control).Items.Clear();
                ((ComboBox)control).Items.Insert(0, "None");
               foreach (string key in sampleData.Keys)
                {
                    if (key != "Instrument Folder Name") ((ComboBox)control).Items.Add(key);
                }
            });
                this.mainControls.selectSamplesButton.Text = sampleData["Instrument Folder Name"];
                this.channelName = sampleData["Instrument Folder Name"];
            }




            this.channelTrack.trackCaretaker.GetStack().Clear();
        }
        public override void Update(float valueToBeUpdatedTo)
        {
            this.mainControls.Volume.Volume= valueToBeUpdatedTo;
        }
    }
}
