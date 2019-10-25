using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ex06_3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreated()
        {
            Queue q1 = new Queue();
            q1.En(1);
            q1.En(2);
            q1.En(3);
            q1.En(4);
            Assert.AreEqual(4, q1.CheckCount());
        }
        [TestMethod]
        public void TestDe()
        {
            Queue q2 = new Queue();
            q2.En(1);
            q2.En(2);
            q2.En(3);
            q2.En(4);
            Assert.AreEqual(1, q2.De());
            Assert.AreEqual(2, q2.De());
            Assert.AreEqual(3, q2.De());
        }
        [TestMethod]
        public void TestPeek()
        {
            Queue q3 = new Queue();
            q3.En(1);
            q3.En(2);
            q3.En(3);
            q3.En(4);
            Assert.AreEqual(1, q3.peek());
        }
    }
}
