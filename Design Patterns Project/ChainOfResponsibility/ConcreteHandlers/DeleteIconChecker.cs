using Design_Patterns_Project.ChainOfResponsibility.HandlerBase;
using System.IO;

namespace Design_Patterns_Project.ChainOfResponsibility.ConcreteHandlers
{
    public class DeleteIconChecker : ResourcesCheckerBase
    {
        public override bool Check(string basePath)
        {
            if (!File.Exists(basePath + "\\Icons\\Delete.png"))
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
