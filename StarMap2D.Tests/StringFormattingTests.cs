using Microsoft.VisualStudio.TestTools.UnitTesting;
using VPKSoft.StarCatalogs.HelperClasses;

namespace StarMap2D.Tests
{
    [TestClass]
    public class StringFormattingTests
    {
        [TestMethod]
        public void TestStarNamePrettify()
        {
            var name = "12Alp2CVn";
            var expected = "12 Alp 2 CVn";
            Assert.AreEqual(name.PrettifyStarName(), expected);

            name = "48Iot Cnc";
            expected = "48 Iot Cnc";
            Assert.AreEqual(name.PrettifyStarName(), expected);
        }
    }
}
