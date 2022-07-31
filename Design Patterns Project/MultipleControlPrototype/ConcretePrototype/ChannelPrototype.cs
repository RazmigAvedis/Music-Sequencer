using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.MultipleControlPrototype.ConcretePrototype
{
    public class ChannelPrototype : Prototype.MultipleControlsPrototype
    {
        public ChannelPrototype()
        {
           
            this.On = new CheckBox()
            {
                Checked = true,
                Size = new Size(20, 20)
            };

            this.Icon = new PictureBox()
            {
                Size = new Size(20, 20),
                BackgroundImageLayout = ImageLayout.Zoom
            };

            this.Volume = new NAudio.Gui.VolumeSlider()
            {
                Size = new Size(60, 20)
            };


            this.selectSamplesButton = new Button()
            {
                Size = new Size(100, 20)
            };

            this.channelDeleteButton = new Button()
            {
                Size = new Size(20, 20),
                BackgroundImageLayout = ImageLayout.Zoom,
                BackgroundImage = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\Icons\Delete.png")),
            };
        }

    }
}