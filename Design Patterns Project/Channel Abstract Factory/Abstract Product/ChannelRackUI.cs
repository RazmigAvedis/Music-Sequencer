using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product
{
    public abstract class ChannelRackUI: Dictionary<float,Control>
    {
        public abstract void ChannelRackUIInitialize();
    }
}
