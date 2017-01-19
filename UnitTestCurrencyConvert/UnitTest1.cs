using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyConvert;
namespace UnitTestCurrencyConvert
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void USDtoJPYComputesCorrectly()
        {
            var sut = new ConvertedMoney(1, currencyType.USD, currencyType.JPY);
            Assert.AreEqual(sut.valueToConvert, 1);
            Assert.AreEqual(sut.convertFromType, currencyType.USD);
            Assert.AreEqual(sut.convertToType, currencyType.JPY);
            Assert.AreEqual(sut.Calculate(), 114.5, 1);              
        }

        [TestMethod]
        public void USDtoEURCorrectly()
        {
            var sut = new ConvertedMoney(1, currencyType.USD, currencyType.EUR);
            Assert.AreEqual(sut.Calculate(), 0.941, 0.01);
        }

        [TestMethod]
        public void USDtoBTCCorrectly()
        {
            var sut = new ConvertedMoney(1, currencyType.USD, currencyType.BTC);
            Assert.AreEqual(sut.Calculate(), 0.00113, 0.0001);
        }

        [TestMethod]
        public void JPYtoUSDCorrectly()
        {
            var sut = new ConvertedMoney(1, currencyType.JPY, currencyType.USD);
            Assert.AreEqual(sut.Calculate(), 0.009, 0.01);
        }

        [TestMethod]
        public void JPYtoEURCorrectly()
        {
            var sut = new ConvertedMoney(1, currencyType.JPY, currencyType.EUR);
            Assert.AreEqual(sut.Calculate(), 0.008, 0.01);
        }

        [TestMethod]
        public void JPYtoBTCCorrectly()
        {
            var sut = new ConvertedMoney(1, currencyType.JPY, currencyType.BTC);
            Assert.AreEqual(sut.Calculate(), 0.0000099, 0.00001);
        }

        [TestMethod]
        public void EURtoUSDCorrectly()
        {
            var sut = new ConvertedMoney(1, currencyType.EUR, currencyType.USD);
            Assert.AreEqual(sut.Calculate(), 1.063, 0.1);
        }

        [TestMethod]
        public void EURtoJPYCorrectly()
        {
            var sut = new ConvertedMoney(1, currencyType.EUR, currencyType.JPY);
            Assert.AreEqual(sut.Calculate(), 121.9, 1);
        }

        [TestMethod]
        public void EURtoBTCCorrectly()
        {
            var sut = new ConvertedMoney(1, currencyType.EUR, currencyType.BTC);
            Assert.AreEqual(sut.Calculate(), 0.0012, 0.001);
        }

        [TestMethod]
        public void BTCtoUSDCorrectly()
        {
            var sut = new ConvertedMoney(1, currencyType.BTC, currencyType.USD);
            Assert.AreEqual(sut.Calculate(), 885.0, 100);
        }

        [TestMethod]
        public void BTCtoJPYCorrectly()
        {
            var sut = new ConvertedMoney(1, currencyType.BTC, currencyType.JPY);
            Assert.AreEqual(sut.Calculate(), 101997, 10000);
        }

        [TestMethod]
        public void BTCtoEURCorrectly()
        {
            var sut = new ConvertedMoney(1, currencyType.BTC, currencyType.EUR);
            Assert.AreEqual(sut.Calculate(), 832.5, 100);
        }
    }
}
