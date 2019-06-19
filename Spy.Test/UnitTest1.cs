using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spy.Assemblies.Services.BAL;

namespace Spy.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestJamesBond()
        {
            SpyBAL objSpyBAL = new SpyBAL();
            bool isJamesBond=objSpyBAL.CheckIsSpy("1,2,4,0,0,7,5","0,0,7");
            Assert.AreEqual(isJamesBond, true);
        }

        [TestMethod]
        public void TestNotJamesBond()
        {
            SpyBAL objSpyBAL = new SpyBAL();
            bool isJamesBond = objSpyBAL.CheckIsSpy("1,2,0,7,4,4,0", "0,0,7");
            Assert.AreEqual(isJamesBond, false);
        }

        [TestMethod]
        public void TestEthanHunt()
        {
            SpyBAL objSpyBAL = new SpyBAL();
            bool isJamesBond = objSpyBAL.CheckIsSpy("3,6,0,1,2,6,4", "3,1,4");
            Assert.AreEqual(isJamesBond, true);
        }

        [TestMethod]
        public void TestNotEthanHunt()
        {
            SpyBAL objSpyBAL = new SpyBAL();
            bool isEthan = objSpyBAL.CheckIsSpy("4,1,3,8,4,3,1", "0,0,7");
            Assert.AreEqual(isEthan, false);
        }

      
    }
}
