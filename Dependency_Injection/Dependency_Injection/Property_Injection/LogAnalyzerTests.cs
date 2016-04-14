using System;
using Dependency_Injection.Constructor_Injection;
using NUnit.Framework;

namespace Dependency_Injection.Property_Injection
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidFileName_NameSupportedExtension_ReturnsTrue()
        {

            //set up the stub to use, make sure it returns true

            FakeExtensionManager myFakeManager =
                new FakeExtensionManager();
            myFakeManager.WillBeValid = false;

            //create analyzer and inject stub

            LogAnalyzer log = new LogAnalyzer();
            log.ExtensionManager = myFakeManager;

            //Assert logic assuming extension is supported

            bool result = log.IsValidLogFileName("short.ext");
            Assert.False(result);
        }

        
    }


}
