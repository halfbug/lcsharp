using System;
using NUnit.Framework;

namespace Dependency_Injection.Constructor_Injection
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidFileName_NameSupportedExtension_ReturnsTrue()
        {
            FakeExtensionManager myFakeManager =
                new FakeExtensionManager();
            myFakeManager.WillBeValid = false;
            LogAnalyzer log =
                new LogAnalyzer(myFakeManager);
            bool result = log.IsValidLogFileName("short.ext");
            Assert.False(result);
        }

        [Test]
        public void
        IsValidFileName_ExtManagerThrowsException_ReturnsFalse()
        {
            FakeExtensionManager myFakeManager =
                        new FakeExtensionManager();
            myFakeManager.WillThrow = new Exception("this is fake");
            LogAnalyzer log =
                new LogAnalyzer(myFakeManager);
            bool result = log.IsValidLogFileName("anything.anyextension");
            Assert.False(result);
        }
    }


}
