using Design_Patterns_Project.Prototype.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.Prototype.ConcretePrototype
{
    public class automationTrackControlMember:TrackControlMember
    {
        public automationTrackControlMember()
        {
            control =
                new NumericUpDown()
                {
                    Increment = (decimal)0.01,
                    Maximum = 1,
                    Minimum = 0,
                    DecimalPlaces = 2,
                    Size = new System.Drawing.Size(100, 50),
                };
        }
    }
}
