using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirtyDaysofTDD.ClassLibrary;
using NUnit.Framework;

namespace ThirtyDaysofTDD.UnitTests
{
    [TestFixture]
    public class StringUtilsTests
    {
        private StringUtils _stringUtils;

        [TestFixtureSetUp]
        public void SetupStringUtilTests()
        {
            _stringUtils = new StringUtils();
        }

        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInSimpleSentence()
        {
            var sentenceToScan = "TDD is awesome!";
            var characterToScanFor = "e";
            var expectedResult = 2;

            int result = _stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);
            
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInAComplexSentance()
        {
            var sentenceToScan = "Once is unique, twice is a coincidence, three times is a pattern.";
            var characterToScanFor = "n";
            var expectedResult = 5;

            int result = _stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldGetAnArgumentExceptionWhenCharacterToScanForIsLargerThanOneCharacter()
        {
            var sentenceToScan = "This test should throw an exception";
            var characterToScanFor = "xx";

            _stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);
        }
    }

}
