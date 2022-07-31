using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Design_Patterns_Project.Singleton;
using System.Drawing;
using Design_Patterns_Project.MultipleControlPrototype.ConcretePrototype;
using Design_Patterns_Project.AutomationLinkObserver.ObserverBase;
using Design_Patterns_Project.SamplesAdapter.Adapter;

namespace Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Product
{
    public class automationChannel : Channel
    {
        public automationChannel()
        {
            channelInitialize();
        }

        public override void channelInitialize()
        {

            base.channelInitialize();

            Id = ChannelList.GetListCount()==0 ? 1: ChannelList.GetChannelListObject()._ChannelList.ChannelList.Keys.Last() + 1;

            channelName = "Automation " + Id;

            mainControls.On.Name = "Automation CheckBox" + Id.ToString();
            
            mainControls.Icon.Name = "Automation PictureBox" + Id.ToString();

            try
            {
                mainControls.Icon.BackgroundImage = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\Icons\Automation.png"));
            }
            catch { }


            mainControls.Volume.Name = "Automation Volume" + Id.ToString();
            
            mainControls.selectSamplesButton.Name = "Automation Sample Select Button " + Id.ToString();
            mainControls.selectSamplesButton.Text = "Select Referance";
            mainControls.selectSamplesButton.Click += new EventHandler(button_Click);
            
            mainControls.channelDeleteButton.Name = "Automation Channel Delete Button " + Id.ToString();
            mainControls.channelDeleteButton.Click += new EventHandler(deleteButton_Click);
            
        }

        public override void button_Click(object sender, EventArgs e)
        {
            var automationLinkAdapter= new AutomationLinkAdapter();
            automationLinkAdapter.SetSamples();
            sampleData = automationLinkAdapter.GetSamples();
            if(sampleData!=null&&sampleData.Count()!=0)this.Register(ChannelList.GetChannelListObject()._ChannelList.ChannelList[int.Parse(sampleData.Last().Key)]);
        }

        readonly protected List<Channel> _observers = new List<Channel>();

        public void Register(Channel observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void Unregister(Channel observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        public void Notify(float valueToUpdateTo)
        {
            foreach(var observer in _observers)
            {
                observer.Update(valueToUpdateTo);
            }
        }

        public List<Channel> GetAllObservers()
        {
            return _observers;
        }

        public override void Update(float valueToUpdateTo){}
    }
}
