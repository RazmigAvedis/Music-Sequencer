using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Design_Patterns_Project.Singleton;
using System.Drawing;
using Design_Patterns_Project.MultipleControlPrototype.ConcretePrototype;
using Design_Patterns_Project.SamplesAdapter.Adapter;
using Design_Patterns_Project.AutomationLinkObserver.ObserverBase;
using Design_Patterns_Project.SamplesAdapter.Models;

namespace Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Product
{
    public class drumsChannel:Channel
    {
        public drumsChannel()
        {
            channelInitialize();
        }

        public override void channelInitialize()
        {
            base.channelInitialize();

            Id = ChannelList.GetListCount() == 0 ? 1 : ChannelList.GetChannelListObject()._ChannelList.ChannelList.Keys.Last() + 1;

            channelName = "Drums " + Id;
            
            mainControls.On.Name = "Drums CheckBox" + Id.ToString();
            
             this.mainControls.Icon.Name = "Drums PictureBox" + Id.ToString();
            try
            {
                mainControls.Icon.BackgroundImage = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\Icons\Drums.png"));
            }
            catch { }

            mainControls.Volume.Name = "Drums Volume" + Id.ToString();
            
           this.mainControls.selectSamplesButton.Name = "Drums Sample Select Button " + Id.ToString();
            mainControls.selectSamplesButton.Text = "Select Sample";
            mainControls.selectSamplesButton.Click += new EventHandler(button_Click);

           mainControls.channelDeleteButton.Name = "Drums Channel Delete Button " + Id.ToString();
            mainControls.channelDeleteButton.Click += new EventHandler(deleteButton_Click);
            
        }

        public override void button_Click(object sender, EventArgs e)
        {
            var drumSampleAdapter = new DrumsGetSamplesAdapter();
            drumSampleAdapter.SetSamples();
            sampleGroup oldSampleData = sampleData;
            sampleData = drumSampleAdapter.GetSamples();
            if (sampleData != null && sampleData.Count != 0)
            {
                string DrumSample = sampleData.FirstOrDefault().Key.ToString();
                this.mainControls.selectSamplesButton.Text = DrumSample;
                this.channelName = DrumSample;
            }

            else sampleData = oldSampleData;
            this.channelTrack.trackCaretaker.GetStack().Clear();
        }

        public override void Update(float valueToBeUpdatedTo)
        {
            this.mainControls.Volume.Volume = valueToBeUpdatedTo;
        }
    }
}
