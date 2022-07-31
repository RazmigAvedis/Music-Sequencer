using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.Prototype.Prototype
{
    public abstract class TrackControlMember:ICloneable
    {
        public Control control;

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
