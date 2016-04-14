using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dependency_Injection.Constructor_Injection;

namespace Dependency_Injection.Property_Injection
{
    public class LogAnalyzer
    {
        private IExtensionManager manager;
        public LogAnalyzer()
        {
            manager = new FileExtensionManager();
        }
        public IExtensionManager ExtensionManager
        {
            get { return manager; }
            set { manager = value; }
        }
        public bool IsValidLogFileName(string fileName)
        {
            return manager.IsValid(fileName);
        }
    }
}
