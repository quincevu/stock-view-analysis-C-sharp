using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace COP_4635_Project_1
{
    public class candleStick///this class ensures that the variables all get set to the variables that change based off what document and line is being read from the candelStickReader
    {
        public DateTime Date { get; set; }///the get and set just mean that the variables for each of these are not just a simple var or int, so they can not be created as such
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public long Volume { get; set; }
        public static DataTable Datasource { get; internal set; }
        public double body { get; private set; }
        public double range { get; private set; }

        public double topPrice { get; private set; }///this set of four variables sets up refernces that the math behind the doji recognition can use
        public double bottomPrice { get; private set; }
        public double upperTail { get; private set; }
        public double lowerTail { get; private set; }

        public Boolean bullish { get; private set; }///this sets up the types of doji tha will be seen from normal bearish and bullish to the hammer versions
        public Boolean bearish { get; private set; }
        public Boolean neutral { get; private set; }///this sets up the basis for most of the standard doji patters like dragonfly and gravestone


        public Boolean commonDoji { get; private set; }///this sets up references for all of the other doji so that they can be references in the combobox in the dojiChart window
        public Boolean gravestoneDoji { get; private set; }
        public Boolean neutralDoji { get; private set; }
        public Boolean dragonflyDoji { get; private set; }
        public Boolean longLeggedDoji { get; private set; }

        public Boolean hammer { get; private set; }
        public Boolean bullishHammer { get; private set; }
        public Boolean bearishHammer { get; private set; }
        public Boolean invertedHammer { get; private set; }
        public Boolean bullishInvertedHammer { get; private set; }
        public Boolean bearishInvertedHammer { get; private set; }
        public Boolean marubozu { get; private set; }
        public Boolean whiteMarubozu { get; private set; }
        public Boolean blackMarubozu { get; private set; }

        public Boolean dojiTest(double bodyTolerance = 0.1)///this sets up the basic doji test so that it can be called whenever math is run for some more complicated doji
        {
            return body <= bodyTolerance * range;
        }

        public Boolean dragonflyDojiTest(double bodyTolerance = 0.10, double upperTailTolerance = .15)///this is the math behind the dragongfly doji
        {
            return dojiTest(bodyTolerance) && (upperTail <= range * upperTailTolerance);
        }
        public Boolean neutralDojiTest(double bodyTolerance = 0.03)///this is the math behind the neutral doji
        {
            return dojiTest(bodyTolerance);
        }
        public Boolean gravestoneDojiTest(double bodyTolerance = 0.03, double lowerTailTolerance = 0.05)///this is hte math behind the gravestone doji pattern
        {
            return dojiTest(bodyTolerance) && (lowerTail <= range * lowerTailTolerance);
        }
        public Boolean longLeggedDojiTest(double bodyTolerance = 0.05)///this is the math behind the long lgegged doji
        {
            return dojiTest(bodyTolerance);
        }
        public Boolean hammerTest(double minBodyTolerance = 0.25, double maxBodyTolerance = 0.25, double upperTailTolerance = 0.05)///this is the math behind the hammer doji
        {
            return (minBodyTolerance * range <= body) && (body >= maxBodyTolerance * range) && (upperTail <= upperTailTolerance * range);
        }
        public Boolean bullishHammerTest(double minBodyTolerance = 0.25, double maxBodyTolerance = 0.25, double upperTailTolerance = 0.05)///this is hte math behind the bullish hamemr doji
        {
            return hammerTest(minBodyTolerance,maxBodyTolerance,upperTailTolerance) && (Close>Open);
        }
        public Boolean bearishHammerTest(double minBodyTolerance = 0.25, double maxBodyTolerance = 0.25, double upperTailTolerance = 0.05)///this is the math behind the bearish hammer doji
        {
            return hammerTest(minBodyTolerance,maxBodyTolerance,upperTailTolerance) && (Close<Open);
        }
        public Boolean invertedHammerTest(double minBodyTolerance = 0.25, double maxBodyTolerance = 0.25, double lowerTailTolerance = 0.05)///this is the math behind the inverted doji hammer, it also sets a base for hte bearish and bullish version so that it can be refernced
        {
            return (minBodyTolerance * range <= body) && (body >= maxBodyTolerance * range) && (lowerTail <= lowerTailTolerance * range);
        }
        public Boolean bullishInvertedHammerTest(double minBodyTolerance = 0.25, double maxBodyTolerance = 0.25, double lowerTailTolerance = 0.05)///this is the math behind the bullish inverted hammer doji
        {
            return invertedHammerTest(minBodyTolerance,maxBodyTolerance,lowerTailTolerance) && bullish == true;
        }
        public Boolean bearishInvertedHammerTest(double minBodyTolerance = 0.25, double maxBodyTolerance = 0.25, double lowerTailTolerance = 0.05)///this is the math behind the bearish inverted hammer doji
        {
            return invertedHammerTest(minBodyTolerance, maxBodyTolerance, lowerTailTolerance) && bearish == true;
        }
        public Boolean marubozuTest(double bodyTolerance = 0.03)///this sets up the basic math neccessary for the marubozu doji, it also creates a refernce for the white and black marubozu
        {
            return body > range * (1 - bodyTolerance);
        }
        public Boolean whiteMarubozuTest(double bodyTolerance = 0.03)///this is the math behind the white marubozu doji
        {
            return marubozuTest(bodyTolerance) && bullish == true;
        }
        public Boolean blackMarubozuTest(double bodyTolerance = 0.03)///this is the math behind the black marubozu doji
        {
            return marubozuTest(bodyTolerance) && bearish == true;
        }
        
        public Boolean engulfingBearishTest()
        {
            return body == 1;
        }

        public Boolean engulfingBullishTest()
        {
            return body == 1;
        }
        

        public candleStick()///this sets the date to the current date, and all the variables empty so that nothing can get messed up
        {
            Date = DateTime.Now;
            Open = 0; Close = 0; High = 0; Low = 0; Volume= 0;
        }
    public candleStick(DateTime date, double open, double high, double low, double close, long volume)///this sets up the type of variables and then makes sure that the corresponding names are correct(this is mainly for redundancy)
        {
            Date= date;
            Open= open;
            Close= close;
            High= high; 
            Low= low;
            Volume = volume;

            computeProperties();
        }
        private void computePatterns()///this calls the different doji patterns and references and esablishes a link between the names and the math
        {
            bullish = Close > Open;
            bearish = Open > Close;
            neutral = Open == Close;

            commonDoji = dojiTest();
            dragonflyDoji = dragonflyDojiTest();
            neutralDoji = neutralDojiTest();
            gravestoneDoji = gravestoneDojiTest();
            longLeggedDoji = longLeggedDojiTest();

            hammer = hammerTest();
            bullishHammer = bullishHammerTest();
            bearishHammer = bearishHammerTest();
            invertedHammer = invertedHammerTest();
            bullishInvertedHammer = bullishInvertedHammerTest();
            bearishInvertedHammer = bearishInvertedHammerTest();

            marubozu = marubozuTest();
            whiteMarubozu = whiteMarubozuTest();
            blackMarubozu = blackMarubozuTest();





        }
        private void computeProperties()///this sets all the varialbes that need to be referenced in math behind all the doji patterns so it an be refeerence quicker
        {
            range = High - Low;
            body = Math.Max(Open, Close) - Math.Min(Close, Open);
            topPrice = Math.Max(Open, Close);
            bottomPrice = Math.Min(Open, Close);
            upperTail = High - topPrice;
            lowerTail = bottomPrice - Low;

            computePatterns();
        }
    }
}
