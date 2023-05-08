using Common.DB.DAO;
using Common.DB.DAO.Impl;
using Common.DB.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using System;
using System.Security.Cryptography;
using Assert = NUnit.Framework.Assert;

namespace CommonTest.DB.DAO.Impl
{
    [TestFixture]
    public class ItemLBTest
    {
        [Test]
        public void BrisanjePodatakaBezRedovaUBazi()
        {
            Mock<IItemLBDAO> mock = new Mock<IItemLBDAO>();

            mock.Setup(p => p.DeleteAll()).Returns(-1);
        }

        [Test]
        public void BrisanjePodatakaJedanRed()
        {
            Mock<IItemLBDAO> mock = new Mock<IItemLBDAO>();

            ItemLB ilb = new ItemLB("CODE_ANALOG", 1);

            mock.Setup(p => p.Save(ilb)).Returns(1);
            mock.Setup(p => p.DeleteAll()).Returns(1);
        }

        [Test]
        [TestCase("CODE_ANALOG", 1)]
        [TestCase("CODE_DIGITAL", 17)]
        public void Remove(string code, int value)
        {
            Mock<IItemLBDAO> mock = new Mock<IItemLBDAO>();

            ItemLB ilb1 = new ItemLB("CODE_ANALOG", 1);
            ItemLB ilb2 = new ItemLB("CODE_ANALOG", 1);

            mock.Setup(p => p.Save(ilb1)).Returns(1);
            mock.Setup(p => p.Save(ilb2)).Returns(1);
            mock.Setup(p => p.Remove(code, value)).Returns(1);
        }

        [Test]
        public void GetOne()
        {
            ItemLBDAOImpl i = new ItemLBDAOImpl();

            ItemLB ilb1 = new ItemLB("CODE_ANALOG", 1);

            ItemLB ilb2 = i.GetOne();

            Assert.IsNotNull(ilb2);
        }
    }
}
