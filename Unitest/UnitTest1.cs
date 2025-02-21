using System;
using NUnit.Framework;

namespace Unittest
{
    public class BitAddiererTests
    {
        [Test]
        public void TestVonHalbAddierer()
        {
            Assert.AreEqual((0, 0), Program.HalbAddierer(0, 0));
            Assert.AreEqual((1, 0), Program.HalbAddierer(0, 1));
            Assert.AreEqual((1, 0), Program.HalbAddierer(1, 0));
            Assert.AreEqual((0, 1), Program.HalbAddierer(1, 1));
        }

        [Test]
        public void TestVonVollAddierer()
        {
            Assert.AreEqual((0, 0), Program.VollAddierer(0, 0, 0));
            Assert.AreEqual((1, 0), Program.VollAddierer(0, 0, 1));
            Assert.AreEqual((1, 0), Program.VollAddierer(0, 1, 0));
            Assert.AreEqual((0, 1), Program.VollAddierer(0, 1, 1));
            Assert.AreEqual((1, 0), Program.VollAddierer(1, 0, 0));
            Assert.AreEqual((0, 1), Program.VollAddierer(1, 0, 1));
            Assert.AreEqual((0, 1), Program.VollAddierer(1, 1, 0));
            Assert.AreEqual((1, 1), Program.VollAddierer(1, 1, 1));
        }

        [Test]
        public void TestVonVierBitAddierer()
        {
            Assert.AreEqual((0b0000, 0), Program.VierBitAddierer(0b0000, 0b0000));
            Assert.AreEqual((0b0001, 0), Program.VierBitAddierer(0b0000, 0b0001));
            Assert.AreEqual((0b0010, 0), Program.VierBitAddierer(0b0001, 0b0001));
            Assert.AreEqual((0b1010, 1), Program.VierBitAddierer(0b1111, 0b1011));
        }
    }
}
