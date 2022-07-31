using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using Design_Patterns_Project.Prototype.ConcretePrototype;
using Design_Patterns_Project.Singleton;
using Design_Patterns_Project.UIObserver.ObserverBase;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.UIObserver_Remove_Maybe_.ConcreteObserver
{
    public class MusicSequencerForm : IUIObserver
    {
        public Music_Sequencer musicSynthesizerForm;

        public MusicSequencerForm(Music_Sequencer form)
        {
            musicSynthesizerForm = form;
        }

        public void Update()
        {

            musicSynthesizerForm.GetMainPanel().Controls.Clear();//Reset all controls in the panel

            Dictionary<int, Channel> temp = new Dictionary<int, Channel>();

            foreach (Channel channel in ChannelList.GetChannelListObject()._ChannelList.ChannelList.Values)
            {
                temp.Add(channel.Id, channel);
            }

            ChannelList.GetChannelListObject()._ChannelList.ChannelList.Clear();

            foreach (Channel channel in temp.Values)
            {
                channel.Update();
                ChannelList.GetChannelListObject()._ChannelList.ChannelList.Add(channel.Id, channel);
            }

            foreach (var channel in ChannelList.GetChannelListObject()._ChannelList.ChannelList)
            {
                musicSynthesizerForm.GetMainPanel().Controls.Add(channel.Value.mainControls.On);
                musicSynthesizerForm.GetMainPanel().Controls.Add(channel.Value.mainControls.selectSamplesButton);
                musicSynthesizerForm.GetMainPanel().Controls.Add(channel.Value.mainControls.Volume);
                musicSynthesizerForm.GetMainPanel().Controls.Add(channel.Value.mainControls.Icon);
                musicSynthesizerForm.GetMainPanel().Controls.Add(channel.Value.mainControls.channelDeleteButton);
                musicSynthesizerForm.GetMainPanel().Controls.Add(channel.Value.channelTrack.undoButton);

                foreach (var control in channel.Value.channelTrack)
                {
                    musicSynthesizerForm.GetMainPanel().Controls.Add(control);
                }

            }


            int x = ChannelList.GetListCount();

            var addTrackButton = new addTrackButton().Clone() as addTrackButton;
            Button button = addTrackButton.control as Button;
            button.Location = new Point(130, (ChannelList.GetListCount() * 50) + 10);
            button.Click += new EventHandler(musicSynthesizerForm.button_AddChannel_Click);

            musicSynthesizerForm.GetMainPanel().Controls.Add(button);
        }
    
    }
}
