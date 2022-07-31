using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using Design_Patterns_Project.ChannelListMemento.Caretaker;
using Design_Patterns_Project.ChannelListMemento.Memento;
using Design_Patterns_Project.Prototype.ConcretePrototype;
using Design_Patterns_Project.Singleton;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Product
{
    public class drumsChannelTrack: ChannelTrack
    {
        public drumsChannelTrack(int channelId)
        {
            ChannelTrackInitialize(channelId);
        }
        
        public override void ChannelTrackInitialize(int channelId)
        {
            base.ChannelTrackInitialize(channelId);

            undoButton.Name = "Drums Track Undo Button " + channelId.ToString();

            timeStampControls = new ChannelListMemento.Originator.TimeStamp(new List<string>()); // Initialize the channel Timestamp Dictionary
            trackCaretaker = new TimeStampCaretaker();
            

            for (int i = 0; i < 8; i++)
            {
                var checkBoxPrototype= new drumTrackControlMember().Clone() as drumTrackControlMember;

                CheckBox tempCheckBox = checkBoxPrototype.control as CheckBox;

                tempCheckBox.Location = new System.Drawing.Point(300 + 110 * i, ChannelList._channelList._ChannelList.ChannelList.Count == 0 ? 10 : ChannelList._channelList._ChannelList.ChannelList.Count * 50 + 10);
                tempCheckBox.CheckedChanged += new EventHandler(channelTrack_On_Change);
                tempCheckBox.Name = "Drums Track CheckBox|" + channelId + "|" + i;
                
                this.Add
                (
                 tempCheckBox
                );

            }

            lastItem = GetStringValues();

        }


        public override List<string> GetStringValues()
        {
            List<string> temp = new List<string>();
            foreach (Control control in this)
            {
                var tempp = (CheckBox)control;
                temp.Add(tempp.Checked.ToString());
            }
            return temp;
        }

        public override void SetValues()
        {
            for (int i = 0; i < 8; i++)
            {
                var temp = (CheckBox)this[i];
                temp.CheckedChanged -= new EventHandler(channelTrack_On_Change);
                temp.Checked = bool.Parse(this.timeStampControls.timestampValues[i]);
                temp.CheckedChanged += new EventHandler(channelTrack_On_Change);

            }
        }
    }
}
