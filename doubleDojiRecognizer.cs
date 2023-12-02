using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace COP_4635_Project_1
{
    internal class EngulfingBullishCandlestick_Recognizer : aRecognizor///this is the list of mutiple doji patterns that will be referneced when the dojiChart window is loaded;
    {///this can be amended or changed if more patterns are needed
        public EngulfingBullishCandlestick_Recognizer() : base("Bullish Engulfing Pattern", 2) { }///        

        protected override bool patternMatchedSubset(List<candleStick> Lcs)
        ///Constructor for the EngulfingBullishCandlestick_Recognizer class.
        ///Initializes the name of the pattern and the number of candlesticks required to identify the pattern.
        {
            candleStick pcs = Lcs[0];///this gets the previous candlestick in the dataset
            candleStick cs = Lcs[1];///this gets the current candlestick in the dataset
            return pcs.bearish && cs.bullish && pcs.High < cs.topPrice && pcs.Low < cs.bottomPrice;
            ///Check if the previous candlestick is bearish, the current candlestick is bullish, and the previous candlestick's high is less than the current candlestick's high
            ///and the previous candlestick's low is less than the current candlestick's low.
        }

    }
    internal class EngulfingBearishCandlestick_Recognizer : aRecognizor
    {
        public EngulfingBearishCandlestick_Recognizer() : base("Bearish Engulfing Pattern", 2) { }

        protected override bool patternMatchedSubset(List<candleStick> Lcs)
        {
            candleStick pcs = Lcs[0];
            candleStick cs = Lcs[1];
            return pcs.bullish && cs.bullish && pcs.High < cs.topPrice && pcs.Low < cs.bottomPrice;
        }
    }

    internal class BullishHaramiCandlestick_Recognizer : aRecognizor
    {
        public BullishHaramiCandlestick_Recognizer() : base("Bullish Harami Pattern", 2) { }

        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlestick)
        {
            candleStick pcs = subsetOfCandlestick[0];
            candleStick cs = subsetOfCandlestick[1];
            return pcs.bearish && cs.bullish && (cs.Close - cs.Open) < (pcs.Open - pcs.Close)/3 && pcs.Open > cs.Close && pcs.Close < cs.Open;
        }
    }

    internal class BearishHaramiCandlestick_Recognizer : aRecognizor
    {
        public BearishHaramiCandlestick_Recognizer() : base("Bearish Harami Pattern", 2) { }

        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlestick)
        {
            candleStick pcs = subsetOfCandlestick[0];
            candleStick cs = subsetOfCandlestick[1];
            return cs.bearish && pcs.bullish && (pcs.Close - pcs.Open) < (cs.Open - cs.Close) / 3 && cs.Open > pcs.Close && cs.Close < pcs.Open;
        }
    }
}
