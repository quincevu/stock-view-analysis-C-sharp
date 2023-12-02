using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace COP_4635_Project_1
{
    public class candleStickReader///this is gonna setup the claa for the actual reading of the csv files
    {
        const string dataFolder = "Stock Data";

        public List<candleStick> candleStickBois = null;///this creates the list "candleStickBois" that we use when getting the information from the csv files


        public candleStickReader()
        {
            candleStickBois = new List<candleStick>(256);///this sets the list "candleStickBois" to an actual list with a set amount of data (256)
        }
        public List<candleStick>ReadcandleStickBois(string csvFilename, DateTime startDate, DateTime endDate)///this is reads the inut from the user, like the ticker name, and the start and end date
        {
            char[] seperatior = new char[] { '-', '/',',', '"'};///this ensures that it can read and understand anything a comma, dash, or quotation around any of the input
            String[] lines = System.IO.File.ReadAllLines(csvFilename);///this just reads the cvs file name from the folder
            String header = lines[0];///this sets the place holder where the header is set to go
            if (header == "\"Ticker\",\"Period\",\"Date\",\"Open\",\"High\",\"Low\",\"Close\",\"Volume\"")///this sets up the headers so that the data gets read and then displayed in the correct order
            {
                candleStickBois = new List<candleStick>(lines.Length - 1);
                for(int l = 1; l < lines.Length; l++)///this sets up a for loop for which the program is gonna read the csv, then goes to the next line to do the same; it will stop when the count increases over the number of lines
                {
                    String line = lines[l].Trim();///this makes sure that the input doesnt include spaces on either side so the input can't create any error that may crash the program
                    String[] substrings = line.Split(seperatior, StringSplitOptions.RemoveEmptyEntries);///this ensures that the input has some actual input to the textbox
                    string daymonth = substrings[2];///i have to do this because of the format of the data
                    string monthStr = daymonth.Substring(0, 3);///manually parsing data into separate strings
                    string dayStr = daymonth.Substring(4);///same as above
                    int day = int.Parse(dayStr);///same as above
                    int month = 0;///default value to avoid uninitialized variable use
                    switch (monthStr)///guaranteed to assign the right value, so default is just there
                    {
                        case "Jan":
                            month = 1; break;
                        case "Feb":
                            month = 2; break;
                        case "Mar":
                            month = 3; break;
                        case "Apr":
                            month = 4; break;
                        case "May":
                            month = 5; break;
                        case "Jun":
                            month = 6; break;
                        case "Jul":
                            month = 7; break;
                        case "Aug":
                            month = 8; break;
                        case "Sep":
                            month = 9; break;
                        case "Oct":
                            month = 10; break;
                        case "Nov":
                            month = 11; break;
                        case "Dec":
                            month = 12; break;
                        default:
                            break;
                    }
                    int year = int.Parse(substrings[3]);

                    DateTime date = new DateTime(year, month, day);///this sets the order in which the date is shown

                    if (date.CompareTo(startDate) >= 0 && date.CompareTo(endDate) < 0)///this just ensures that the end date is after the start date
                    {
                        Double open = Double.Parse(substrings[4]);///these just set where the individuals variables are set
                        Double high = Double.Parse(substrings[5]);
                        Double low = Double.Parse(substrings[6]);
                        Double close = Double.Parse(substrings[7]);
                        long volume = long.Parse(substrings[8]);


                        open = Math.Round(open, 2);///this just sets the amount of decimals allowed per number, in this case all the variables are allowed two numbers after the decimal
                        high = Math.Round(high, 2);
                        low= Math.Round(low, 2);
                        close= Math.Round(close, 2);

                        candleStick candlestick = new candleStick(date, open, high, low, close, volume);

                        candleStickBois.Add(candlestick);
                    }
                }
            }
            return candleStickBois;///this returns the list candlestick after the for loop has been completed
        }    



        public List<candleStick> readStock(string ticker, DateTime startDate, DateTime endDate)///this is where the user input goes starting with the ticker name, then the time period shown, and finally the start and end dat
        {
            String csvFilename = dataFolder + @"\" + ticker;///this just soft codes a way for the program to find the correct name for the csv file that needs to be read

            candleStickBois = ReadcandleStickBois(csvFilename, startDate, endDate);

            return candleStickBois;
        }
    }

}
