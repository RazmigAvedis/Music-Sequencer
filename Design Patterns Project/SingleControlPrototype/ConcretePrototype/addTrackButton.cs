using Design_Patterns_Project.Prototype.Prototype;
using Design_Patterns_Project.Singleton;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.Prototype.ConcretePrototype
{
    public class addTrackButton:TrackControlMember
    {
        
        public addTrackButton()
        {
            control =
                new Button()
                {
                    Name = "Add Track Button",
                    FlatStyle= FlatStyle.Popup,
                    BackColor=Color.PaleGreen,
                    BackgroundImageLayout=ImageLayout.Zoom,
                    BackgroundImage= Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\Icons\Plus.png")),
                    Location=new Point(140, ChannelList.GetListCount() * 50 + 10),
                    Size=new Size(100,30),
                    Cursor=Cursors.Hand
                };
        }
    }
}
