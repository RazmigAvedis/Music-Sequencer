using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using Design_Patterns_Project.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Product
{
    public class automationChannelRackUI:ChannelRackUI
    {
        public automationChannelRackUI()
        {
            ChannelRackUIInitialize();
        }

        public override void ChannelRackUIInitialize()
        {
            for (int i = 0; i < 8; i++)
            {
                this.Add
                (0 + (float)0.5 * i
                 ,
                 new NumericUpDown()
                 {
                     Location = new System.Drawing.Point(260 + 60 * i, ChannelList.GetListCount()==0? 100 : ChannelList.GetListCount() *50 + 100),
                     Increment = (decimal)0.1,
                     Maximum = 100,
                     Minimum = 0,
                     Size = new System.Drawing.Size(40, 50)
                 }
                );

            }
            
        }
    }
}
