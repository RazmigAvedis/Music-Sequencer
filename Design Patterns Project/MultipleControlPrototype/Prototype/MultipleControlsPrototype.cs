using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.MultipleControlPrototype.Prototype
{
    public class MultipleControlsPrototype:ICloneable
    {
        public CheckBox On;
        public PictureBox Icon;
        public NAudio.Gui.VolumeSlider Volume;
        public Button selectSamplesButton;
        public Button channelDeleteButton;

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
