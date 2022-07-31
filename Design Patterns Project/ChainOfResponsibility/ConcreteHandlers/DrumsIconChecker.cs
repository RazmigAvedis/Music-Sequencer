using Design_Patterns_Project.ChainOfResponsibility.HandlerBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Project.ChainOfResponsibility.ConcreteHandlers
{
    public class DrumsIconChecker : ResourcesCheckerBase
    {
        public override bool Check(string basePath)
        {
            if (!File.Exists(basePath + "\\Icons\\Drums.png"))
            {
                return false;
            }

            if (_successor != null)
            {
                return _successor.Check(basePath);
            }

            return true;
        }
    }
}
