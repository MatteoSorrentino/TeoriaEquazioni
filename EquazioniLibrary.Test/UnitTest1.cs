using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        //test per equazioni determinate
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
            double a = -50;

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

        //test per equazioni impossibili
        [TestMethod]
        public void TestIncosisted1()
        {
            double a = 0, b = 0;

            bool respAspettata = true;

            bool resp = Equazioni.IsIncosisted(a,b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIncosisted2()
        {
            double a = 5, b = 0;

            bool respAspettata = false;

            bool resp = Equazioni.IsIncosisted(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIncosisted3()
        {
            double a = 0, b = 5;

            bool respAspettata = false;

            bool resp = Equazioni.IsIncosisted(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIncosisted4()
        {
            double a = 5, b = 5;

            bool respAspettata = false;

            bool resp = Equazioni.IsIncosisted(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIncosisted5()
        {
            double a = -5, b = 0;

            bool respAspettata = false;

            bool resp = Equazioni.IsIncosisted(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIncosisted6()
        {
            double a = 0, b = -5;

            bool respAspettata = false;

            bool resp = Equazioni.IsIncosisted(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIncosisted7()
        {
            double a = -5, b = -5;

            bool respAspettata = false;

            bool resp = Equazioni.IsIncosisted(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIncosisted8()
        {
            double a = -5, b = 5;

            bool respAspettata = false;

            bool resp = Equazioni.IsIncosisted(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIncosisted9()
        {
            double a = 5, b = -5;

            bool respAspettata = false;

            bool resp = Equazioni.IsIncosisted(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

    }
}
