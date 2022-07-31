using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Project.ChainOfResponsibility.HandlerBase
{
    public abstract class ResourcesCheckerBase
    {
        protected ResourcesCheckerBase _successor;

        public void SetSuccessor(ResourcesCheckerBase successor)
        {
            _successor = successor;
        }

        public abstract bool Check(string basePath);

    }
}
