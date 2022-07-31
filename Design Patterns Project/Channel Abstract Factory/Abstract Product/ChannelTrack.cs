using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns_Project.ChannelListMemento.Caretaker;
using Design_Patterns_Project.ChannelListMemento.Memento;
using Design_Patterns_Project.ChannelListMemento.Originator;
using System.Drawing;
using Design_Patterns_Project.Singleton;

namespace Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product
{
    public abstract class ChannelTrack:List<Control>
    {
        public TimeStamp timeStampControls { set; get; }
        public List<string> lastItem { set; get; }
        public bool undoWasClicked { set; get; }
        public TimeStampCaretaker trackCaretaker { set; get; }
        public Button undoButton { set; get; }

        public virtual void ChannelTrackInitialize(int channelId)
        {
            undoButton = new Button()
            {
                Size = new Size(20, 20),
                BackgroundImageLayout = ImageLayout.Zoom,
                BackgroundImage = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\Icons\Undo.png")),
                Enabled = true,
                Location = new Point(270, ChannelList.GetListCount() == 0 ? 10 : ChannelList.GetListCount() * 50 + 10),
                Name = "Automation Track Undo Button " + channelId.ToString(),
                Text = " ",
            };

            undoButton.Enabled = false;

            undoButton.Click += new EventHandler(undoButton_On_Click);

        }

        public void channelTrack_On_Change(object sender, EventArgs e)
        {
            if (undoWasClicked)
            {
                trackCaretaker.GetStack().Clear();
                undoWasClicked = false;
            }

            try
            {
                this.timeStampControls.timestampValues = lastItem;// get the last recorded value of the controls inside the track
                trackCaretaker.Add(timeStampControls.CreateUnDo());//create an undo of the last state
                lastItem = this.GetStringValues();//set a new previous state for a future call
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            this.undoButton.Enabled = true;
        }
        public void undoButton_On_Click(object sender, EventArgs e)
        {
            undoWasClicked = true;
            
            if (this.trackCaretaker.GetStack().Count != 0)
            {
                this.timeStampControls.UnDo(trackCaretaker.GetMemento());
                this.lastItem = timeStampControls.timestampValues;
                this.SetValues();
            }
            if(this.trackCaretaker.GetStack().Count == 0)
            {
               ((Button)sender).Enabled = false;
            }

            
        }

        public abstract List<string> GetStringValues();
        public abstract void SetValues();
    }
}
