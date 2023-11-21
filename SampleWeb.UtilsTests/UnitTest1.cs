using Rabbit.ShortGuid;

namespace SampleWeb.UtilsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var guid = new GuidBase62(Guid.NewGuid());
            Assert.IsTrue(guid.ToString().Length < 30);
        }
    }
}