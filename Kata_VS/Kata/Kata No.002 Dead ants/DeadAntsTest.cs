using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata
{
    [TestClass()]
    public class DeadAntsTest
    {
        private DeadAnts _DeadAnts = new DeadAnts();

        [TestMethod]
        public void NoDeadAnts()
        {
            ShouldBeEqual(0, _DeadAnts.CountDeadAnts("ant.ant.ant.ant"));
        }

        [TestMethod]
        public void NullInput()
        {
            ShouldBeEqual(0, _DeadAnts.CountDeadAnts(null));
        }

        [TestMethod]
        public void TwoDeadAnts()
        {
            ShouldBeEqual(2, _DeadAnts.CountDeadAnts("ant.anantt.aantnt"));
        }

        [TestMethod]
        public void OneDeadAnt()
        {
            ShouldBeEqual(1, _DeadAnts.CountDeadAnts("ant.ant....a.nt"));
        }

        [TestMethod]
        public void ThreeDeadAnts()
        {
            ShouldBeEqual(3, _DeadAnts.CountDeadAnts("...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t"));
        }

        [TestMethod]
        public void A()
        {
            ShouldBeEqual(1, _DeadAnts.CountDeadAnts("a"));
        }

        [TestMethod]
        public void N()
        {
            ShouldBeEqual(1, _DeadAnts.CountDeadAnts("n"));
        }

        [TestMethod]
        public void T()
        {
            ShouldBeEqual(1, _DeadAnts.CountDeadAnts("t"));
        }

        [TestMethod]
        public void NoAnts()
        {
            ShouldBeEqual(0, _DeadAnts.CountDeadAnts("...."));
        }

        [TestMethod]
        public void EmptyInput()
        {
            ShouldBeEqual(0, _DeadAnts.CountDeadAnts(""));
        }

        private void ShouldBeEqual(int expected, int output)
        {
            Assert.AreEqual(expected, output);
        }
    }
}