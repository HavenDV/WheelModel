using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WheelModelLibrary.Tests
{
    [TestClass]
    public class WheelModelTests
    {
        [TestMethod]
        public void WheelModelTest()
        {
            var model = new WheelModel();
            var datas = model.Process(0.0, 10.0, 0.5);

            Assert.IsNotNull(datas);
            Assert.AreEqual(21, datas.Count);
        }
    }
}
