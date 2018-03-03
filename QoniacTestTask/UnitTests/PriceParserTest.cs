using System;
using BusinessCommon;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class PriceParserTest
    {
        private PriceParser _parser;

        [SetUp]
        public void Setup()
        {
            _parser = new PriceParser();
        }

        [TestCase("0", "zero dollars")]
        [TestCase("1", "one dollar")]
        [TestCase("25,1", "twenty-five dollars and ten cents")]
        [TestCase("125,1", "one hundred twenty-five dollars and ten cents")]
        [TestCase("100", "one hundred dollars")]
        [TestCase("0,01", "zero dollars and one cent")]
        [TestCase("45 100", "forty-five thousand one hundred dollars")]
        [TestCase("999 999 999,99", "nine hundred ninety-nine million nine hundred ninety-nine thousand nine hundred ninety-nine dollars and ninety-nine cents")]
        public void ParsesPrices(string price, string expectedResult)
        {
            // arrange

            //act
            var result = _parser.ConvertPriceToWords(price);

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase("asd")]
        [TestCase("123.34")]
        [TestCase("123,345")]
        [TestCase(",34")]
        [TestCase("12,34a")]
        public void ThrowsArgumentOutOfRangeException_WrongStringFormat(string priceString)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _parser.ConvertPriceToWords(priceString));
        }
    }
}
