using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;

namespace Dependency_Injection.Constructor_Injection
{
    public class LogAnalyzer
    {
        private IExtensionManager _manager;

        public LogAnalyzer(IExtensionManager mgr)
        {
            _manager = mgr;
        }

        public bool IsValidLogFileName(string fileName)
        {
            return _manager.IsValid(fileName);
        }
    }
}
    

    
