using COP_4635_Project_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COP_4365_Project_1
{
    internal class PeakCandlestick_Recognizer : aRecognizor
    {
        public PeakCandlestick_Recognizer() : base("Peak Pattern", 3) { }

        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlestick)
        {
            candleStick fcs = subsetOfCandlestick[0];
            candleStick scs = subsetOfCandlestick[1];
            candleStick tcs = subsetOfCandlestick[2];
            return scs.High > fcs.High && scs.High > tcs.High;
        }
    }

    internal class ValleyCandlestick_Recognizer : aRecognizor
    {
        public ValleyCandlestick_Recognizer() : base("Valley Pattern", 3) { }

        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlestick)
        {
            candleStick fcs = subsetOfCandlestick[0];
            candleStick scs = subsetOfCandlestick[1];
            candleStick tcs = subsetOfCandlestick[2];
            return scs.Low < fcs.Low && scs.Low < tcs.Low;
        }
    }
}
