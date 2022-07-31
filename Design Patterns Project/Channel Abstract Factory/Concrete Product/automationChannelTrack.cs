using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using Design_Patterns_Project.ChannelListMemento.Caretaker;
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
    public class automationChannelTrack:ChannelTrack
    {
        public automationChannelTrack(int channelId)
        {
            ChannelTrackInitialize(channelId);
        }

        public override void ChannelTrackInitialize(int channelId)
        {
            base.ChannelTrackInitialize(channelId);

            undoButton.Name = "Automation Track Undo Button " + channelId.ToString();

            timeStampControls = new TimeStamp(new List<string>()); // Initialize the channel Timestamp Dictionary
            trackCaretaker = new TimeStampCaretaker();

            undoButton = new Button()
            {
                Size = new Size(20, 20),
                BackgroundImageLayout = ImageLayout.Zoom,
                BackgroundImage = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\Icons\Undo.png")),
                Enabled = true,
                Location = new Point(270, ChannelList.GetListCount() == 0 ? 10 : ChannelList.GetListCount() * 50 + 10),
                Name = "Automation Track Undo Button " + channelId.ToString(),
                Text = " "
            };

            undoButton.Enabled = false;

            undoButton.Click += new EventHandler(undoButton_On_Click);

            for (int i = 0; i < 8; i++)
            {
                var NumericUpDownPrototype = new automationTrackControlMember().Clone() as automationTrackControlMember;

                NumericUpDown tempNumericUpDown = NumericUpDownPrototype.control as NumericUpDown;

                tempNumericUpDown.Location =new Point(300 + 110 * i, ChannelList.GetListCount() == 0 ? 10 : ChannelList.GetListCount() * 50 + 10);  
                tempNumericUpDown.ValueChanged += new EventHandler(channelTrack_On_Change);
                tempNumericUpDown.Name = "Automation Track NumericUpDown|" + channelId + "|" + i;
                
                this.Add
                (
                 tempNumericUpDown
                );
            }
            lastItem = GetStringValues();
        }

        
        public override List<string> GetStringValues()
        {
            List<string> temp = new List<string>();
            foreach(Control control in this)
            {
                var tempp = (NumericUpDown)control;
                temp.Add(tempp.Value.ToString());
            }
            return temp;
        }

        public override void SetValues()
        {
            for(int i=0;i<8;i++)
            { 
                var temp = (NumericUpDown)this[i];
                temp.ValueChanged -= new EventHandler(channelTrack_On_Change);
                temp.Value = decimal.Parse(this.timeStampControls.timestampValues[i]);
                temp.ValueChanged += new EventHandler(channelTrack_On_Change);
            }
        }

        
    }
}
