using SampleWeb.Business;

namespace SampleWeb.BusinessTests
{
    [TestClass]
    public class BusinessHelperTests
    {
        [TestMethod]
        public void CanBuildRandomStrings()
        {
            var data = BusinessHelper.BuildRandomStrings();

            Assert.IsTrue(data.Count > 0);
            Assert.IsTrue(data.Count <= 100);

            var list = new List<string>()
            {
                "Zero","One"
            };

            foreach (var item in data)
            {
                Assert.IsNotNull(item);
                Assert.IsTrue(list.Contains(item));
            }
        }
    }
}