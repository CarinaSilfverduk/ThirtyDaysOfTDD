using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDaysofTDD.ClassLibrary
{
    class StringUtils
    {
        public int FindNumberOfOccurences(string sentenceToScan, string characterToScanFor)
        {
            if (characterToScanFor.Length != 1)
            {
             throw new ArgumentException();   
            }

            var stringToCheckAsCharacterArray = sentenceToScan.ToCharArray();
            var characterToCheckFor = Char.Parse(characterToScanFor);

            var numberOfOccurences = 0;

            for (var charIdx = 0; charIdx < stringToCheckAsCharacterArray.GetUpperBound(0); charIdx++)
            {
                if (stringToCheckAsCharacterArray[charIdx] == characterToCheckFor)
                {
                    numberOfOccurences++;
                }
            }

            return numberOfOccurences; 

        }
    }
}
