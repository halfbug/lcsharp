using System;

namespace Dependency_Injection.Constructor_Injection
{
    internal class FakeExtensionManager : IExtensionManager
    {
        public bool WillBeValid = false;

     /*   public bool IsValid(string fileName)
        {
            return WillBeValid;
        }
        */
       
        public Exception WillThrow = null;
        public bool IsValid(string fileName)
        {
            if (WillThrow != null)
            { throw WillThrow; }
            return WillBeValid;
        }

    }
}