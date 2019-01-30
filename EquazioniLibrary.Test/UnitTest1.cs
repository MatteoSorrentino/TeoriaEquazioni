using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDetermined1()
        {
            double a = 3;

            bool respAspettata = true;

            bool resp=Equazioni.IsDetermined(a);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestDetermined2()
        {
            double a = -5;

            bool respAspettata = true;

            bool resp = Equazioni.IsDetermined(a);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestDetermined3()
        {
            double a = 0;

            bool respAspettata = false;

            bool resp = Equazioni.IsDetermined(a);

            Assert.AreEqual(respAspettata, resp);

        }


    }
}
