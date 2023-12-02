using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COP_4635_Project_1
{

    internal abstract class aRecognizor
    {

        
        public string patternName { get; set; }///This is a public string property that represents the name of the pattern being recognized.

        public int patternSize { get; set; }///This is a public integer property that represents the size of the pattern being recognized.

        ///This is an abstract method that takes a list of candleStick objects as input
        ///and returns a boolean value indicating whether the pattern is matched within that subset.
        protected abstract bool patternMatchedSubset(List<candleStick> subsetOfCandlestick);

        ///This is a public method that takes a list of candleStick objects as input
        ///and returns a list of integers indicating the indices at which the pattern is recognized within the input list of candleStick objects.
        public List<int> recongize(List<candleStick> candleSticks)
        {
                        
            List<int> result = new List<int>(candleSticks.Count / 8);///Create a new list to store the indices where the pattern is recognized.

            int offset = patternSize - 1;/// Calculate the offset based on the pattern size.
            MessageBox.Show(offset.ToString());
            for (int i = offset; i < candleSticks.Count; i++)/// Iterate over the candleSticks list, creating subsets of size patternSize.
            {
                List<candleStick> subset = candleSticks.GetRange(i - offset, patternSize);/// Get a subset of candleSticks of size patternSize starting from index i - offset.

                if (patternMatchedSubset(subset))/// Call the patternMatchedSubset method on the subset of candleSticks to check if it matches the pattern.
                {
                    //MessageBox.Show("Matched");
                    result.Add(i);/// If the pattern is matched, add the index of the last candleStick in the subset to the result list
                }
            }
            return result;/// Return the list of indices where the pattern is recognized
        }

        public aRecognizor(string pName, int pSize) => (patternName, patternSize) = (pName, pSize);/// This is a constructor that sets the patternName and patternSize properties to the values of pName and pSize, respectively.
    }
}


