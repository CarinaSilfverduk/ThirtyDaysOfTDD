﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ThirtyDaysofTDD.UnitTests
{
    [TestFixture]
    public class StringUtilsTests
    {
        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInSimpleSentence()
        {
            var sentenceToScan = "TDD is awesome!";
            var characterToScanFor = "e";
            var expectedResult = 2;
            var stringUtils = new StringUtils();

            int result = stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);
            
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInAComplexSentance()
        {
            var sentenceToScan = "Once is unique, twice is a coincidence, three times is a pattern.";
            var characterToScanFor = "n";
            var expectedResult = 5;
            var stringUtils = new StringUtils();

            int result = stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);

            Assert.AreEqual(expectedResult, result);
        }
    }

}
