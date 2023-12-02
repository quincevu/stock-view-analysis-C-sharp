using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COP_4635_Project_1///this creates a list of single dojis that will be refernced when the dojiChart is loaded
{
    internal class Recognizer_Bullish : aRecognizor 
    {
        public Recognizer_Bullish() : base("Bullish", 1) { }///This class is a subclass of aRecognizor, specifically designed to recognize Bullish patterns
        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlesticks)///This method checks if a subset of candlesticks matches the Bullish pattern
        {
            MessageBox.Show("Here!");
            return subsetOfCandlesticks[0].bullish;///If the first candlestick in the subset is Bullish, return true which sets up for the annotations to be put at the specific doji
        }
    }

    ///each of the internal classes function essentially the same way just adjusted for each doji or pattern



    internal class Recognizer_Bearish : aRecognizor
    {
        public Recognizer_Bearish() : base("Bearish", 1) { }
        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].bearish;
        }
    }
    internal class Recognizer_Neutral : aRecognizor
    {
        public Recognizer_Neutral() : base("Neutral", 1) { }
        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].neutral;
        }
    }
    internal class Recognizer_Doji : aRecognizor
    {
        public Recognizer_Doji() : base("Doji", 1) { }
        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].commonDoji;
        }
    }
    internal class Recognizer_DragonFly : aRecognizor
    {
        public Recognizer_DragonFly() : base("Dragonfly", 1) { }
        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].dragonflyDoji;
        }
    }
    internal class Recognizer_NeutralDoji : aRecognizor
    {
        public Recognizer_NeutralDoji() : base("Neutral Doji", 1) { }
        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].neutralDoji;
        }
    }
    internal class Recognizer_GravestoneDoji : aRecognizor
    {
        public Recognizer_GravestoneDoji() : base("Gravestone Doji", 1) { }
        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].gravestoneDoji;
        }
    }
    internal class Recognizer_longLeggedDoji : aRecognizor
    {
        public Recognizer_longLeggedDoji() : base("LongLegged Doji", 1) { }
        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].longLeggedDoji;
        }
    }
    internal class Recognizer_Hammer : aRecognizor
    {
        public Recognizer_Hammer() : base("Hammer", 1) { }
        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].hammer;
        }
    }
    internal class Recognizer_BullishHammer : aRecognizor
    {
        public Recognizer_BullishHammer() : base("Bullish Hammer", 1) { }
        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].bullishHammer;
        }
    }
    internal class Recognizer_BearishHammer : aRecognizor
    {
        public Recognizer_BearishHammer() : base("Bearish Hammer", 1) { }
        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].bearishHammer;
        }
    }
    internal class Recognizer_invertedHammer : aRecognizor
    {
        public Recognizer_invertedHammer() : base("Inverted Hammer", 1) { }
        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].invertedHammer;
        }
    }
    internal class Recognizer_bullishInvertedHammer : aRecognizor
    {
        public Recognizer_bullishInvertedHammer() : base("Bullish Inverted Hammer", 1) { }
        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].bullishInvertedHammer;
        }
    }
    internal class Recognizer_bearishInvertedHammer : aRecognizor
    {
        public Recognizer_bearishInvertedHammer() : base("Bearish Inverted Hammer", 1) { }
        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].bearishInvertedHammer;
        }
    }
    internal class Recognizer_Marubozu : aRecognizor
    {
        public Recognizer_Marubozu() : base("Marubozu", 1) { }
        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].marubozu;
        }
    }
    internal class Recognizer_whiteMarubozu : aRecognizor
    {
        public Recognizer_whiteMarubozu() : base("White Marubozu", 1) { }
        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].whiteMarubozu;
        }
    }
    internal class Recognizer_blackMarubozu : aRecognizor
    {
        public Recognizer_blackMarubozu() : base("Black Marubozu", 1) { }
        protected override bool patternMatchedSubset(List<candleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].blackMarubozu;
        }
    }
}
