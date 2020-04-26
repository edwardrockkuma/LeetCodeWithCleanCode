using System.Collections.Generic;

namespace CommonUtils.Helper
{
    public class PermutationsHelper
    {
        /// <summary>
        /// Get All Permutations of target string
        /// </summary>
        /// <param name="permutations">Collection of result</param>
        /// <param name="targetString"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        public static void Permute(HashSet<string> permutations,string targetString , int startIndex, int endIndex)
        {
            if(permutations == null )
            {
                permutations = new HashSet<string>();

            }
            

            if(startIndex == endIndex)
            {
                permutations.Add(targetString);      
            }
            else
            {
                for(int i = startIndex; i <= endIndex; i++)
                {
                    targetString = Swap(targetString , startIndex , i);
                    Permute(permutations , targetString , startIndex+1 , endIndex);
                    targetString = Swap(targetString , startIndex , i);
                }
            }
           
           
        }

        private static string Swap(string targetString, int activeIndex ,int passiveIndex)
        {
            char tempChar;
            char[] charArray = targetString.ToCharArray();
            tempChar = charArray[activeIndex];
            charArray[activeIndex] = charArray[passiveIndex];
            charArray[passiveIndex] = tempChar;
            string swappedString = new string(charArray);

            return swappedString;
        }
    }
}