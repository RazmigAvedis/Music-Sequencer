using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using Design_Patterns_Project.Channel_Abstract_Factory.Concrete_Factory;
using Design_Patterns_Project.Singleton;
using Design_Patterns_Project.Builder.Builder;
using Design_Patterns_Project.Builder.Director;
using Design_Patterns_Project.Builder.ConcreteBuilder;

namespace Design_Patterns_Project
{

    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Music_Sequencer());
        }
    }
}
