﻿using System;
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

        //test per equazioni indeterminate
        [TestMethod]
        public void TestIndetermined1()
        {
            double a = 0, b = 0;

            bool respAspettata = true;

            bool resp = Equazioni.IsIndetermined(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIndetermined2()
        {
            double a = 5, b = 0;

            bool respAspettata = false;

            bool resp = Equazioni.IsIndetermined(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIndetermined3()
        {
            double a = 0, b = 5;

            bool respAspettata = false;

            bool resp = Equazioni.IsIndetermined(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIndetermined4()
        {
            double a = 5, b = 5;

            bool respAspettata = false;

            bool resp = Equazioni.IsIndetermined(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIndetermined5()
        {
            double a = -5, b = 0;

            bool respAspettata = false;

            bool resp = Equazioni.IsIndetermined(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIndetermined6()
        {
            double a = 0, b = -5;

            bool respAspettata = false;

            bool resp = Equazioni.IsIndetermined(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIndetermined7()
        {
            double a = -5, b = -5;

            bool respAspettata = false;

            bool resp = Equazioni.IsIndetermined(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIndetermined8()
        {
            double a = -5, b = 5;

            bool respAspettata = false;

            bool resp = Equazioni.IsIndetermined(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIndetermined9()
        {
            double a = 5, b = -5;

            bool respAspettata = false;

            bool resp = Equazioni.IsIndetermined(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        //test per equazioni impossibile
        [TestMethod]
        public void TestIncosisted1()
        {
            double a = 0, b = 0;

            bool respAspettata = false;

            bool resp = Equazioni.IsIncostisted(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIncosisted2()
        {
            double a = 5, b = 0;

            bool respAspettata = false;

            bool resp = Equazioni.IsIncostisted(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIncosisted3()
        {
            double a = 0, b = 5;

            bool respAspettata = true;

            bool resp = Equazioni.IsIncostisted(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIncosisted4()
        {
            double a = 5, b = 5;

            bool respAspettata = false;

            bool resp = Equazioni.IsIncostisted(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIncosisted5()
        {
            double a = -5, b = 0;

            bool respAspettata = false;

            bool resp = Equazioni.IsIncostisted(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIncosisted6()
        {
            double a = 0, b = -5;

            bool respAspettata = true;

            bool resp = Equazioni.IsIncostisted(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIncosisted7()
        {
            double a = -5, b = -5;

            bool respAspettata = false;

            bool resp = Equazioni.IsIncostisted(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIncosisted8()
        {
            double a = -5, b = 5;

            bool respAspettata = false;

            bool resp = Equazioni.IsIncostisted(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestIncosisted9()
        {
            double a = 5, b = -5;

            bool respAspettata = false;

            bool resp = Equazioni.IsIncostisted(a, b);

            Assert.AreEqual(respAspettata, resp);

        }

        //test per equazioni di secondo grado
        [TestMethod]
        public void TestDegree2()
        {
            double a = 0;

            bool respAspettata = false;

            bool resp = Equazioni.IsDegree2(a);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestDegree2_1()
        {
            double a = 5;

            bool respAspettata = true;

            bool resp = Equazioni.IsDegree2(a);

            Assert.AreEqual(respAspettata, resp);

        }

        [TestMethod]
        public void TestDegree2_2()
        {
            double a = -5;

            bool respAspettata = true;

            bool resp = Equazioni.IsDegree2(a);

            Assert.AreEqual(respAspettata, resp);

        }



    }
}
