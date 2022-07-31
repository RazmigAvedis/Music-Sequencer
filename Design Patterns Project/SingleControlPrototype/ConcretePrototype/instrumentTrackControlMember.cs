using Design_Patterns_Project.Prototype.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.Prototype.ConcretePrototype
{
    public class instrumentTrackControlMember:TrackControlMember
    {
        public instrumentTrackControlMember()
        {
            control =
                 new ComboBox()
                 {
                     Size = new System.Drawing.Size(100, 20),
                 };

            
            
        }
    }
}
