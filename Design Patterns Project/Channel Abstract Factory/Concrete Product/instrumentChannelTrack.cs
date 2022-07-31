using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using Design_Patterns_Project.ChannelListMemento.Caretaker;
using Design_Patterns_Project.ChannelListMemento.Memento;
using Design_Patterns_Project.ChannelListMemento.Originator;
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
    public class instrumentChannelTrack:ChannelTrack
    {
        public instrumentChannelTrack(int channelId)
        {
            ChannelTrackInitialize(channelId);
        }

        public override void ChannelTrackInitialize(int channelId)
        {
            base.ChannelTrackInitialize(channelId);

            undoButton.Name = "Instrument Track Undo Button " + channelId.ToString();

            trackCaretaker = new TimeStampCaretaker();
            timeStampControls = new TimeStamp(new List<string>()); // Initialize the channel Timestamp Dictionary


            for (int i = 0; i < 8; i++)
            {
                var comboBoxPrototype = new instrumentTrackControlMember().Clone() as instrumentTrackControlMember;

                ComboBox tempComboBox = comboBoxPrototype.control as ComboBox;

                tempComboBox.Location = new Point(300 + 110* i, ChannelList.GetListCount() == 0 ? 10 : ChannelList.GetListCount() * 50 + 10);
                tempComboBox.Items.Insert(0, "None");
                tempComboBox.SelectedItem = tempComboBox.Items[0];
                tempComboBox.SelectedValueChanged += new EventHandler(channelTrack_On_Change);
                tempComboBox.Name = "Instrument Track ComboBox|" + channelId + "|" + i;
                
                this.Add
                (
                tempComboBox
                );


            }
            
            lastItem = GetStringValues();

        }


        public override List<string> GetStringValues()
        {
            List<string> temp = new List<string>();
            foreach (Control control in this)
            {
                var tempp = (ComboBox)control;
                temp.Add(tempp.Text);
            }
            return temp;
        }

        public override void SetValues()
        {
            for (int i = 0; i < 8; i++)
            {
                var temp = (ComboBox)this[i];
                temp.SelectedValueChanged -= new EventHandler(channelTrack_On_Change);
                temp.SelectedItem=this.timeStampControls.timestampValues[i];
                temp.SelectedValueChanged += new EventHandler(channelTrack_On_Change);
            }
        }
    }
}
