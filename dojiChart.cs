using COP_4365_Project_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace COP_4635_Project_1
{
    public partial class dojiChart : Form
    {
        List<candleStick> candleStick = new List<candleStick>();
        public dojiChart()
        {
            InitializeComponent();
            initializeRecognizer();
            chartDoji.Series["OHLC"].XValueMember = "Date";///sets the values on the x-axis to the date type
            chartDoji.Series["OHLC"].YValuesPerPoint = 4;///sets the amount of variables on the y-axis from its inital 1 to 4
            chartDoji.Series["OHLC"].YValueMembers = "High, Low, Open, Close";///defines what the name of the variables the y-axis should be looking for
            chartDoji.ChartAreas["OHLC"].AxisX.MajorGrid.LineWidth = 0;///determines the line width for the x-axis on the chart
            chartDoji.ChartAreas["OHLC"].AxisY.MajorGrid.LineWidth = 0;///determines the line width for the y-axis on the chart

            chartDoji.Series["OHLC"].CustomProperties = "PriceUpColor=Green,PriceDownColor=Red";///this sets the color for the up and down candlesticks to green and red respectively


            chartDoji.DataBind();///this binds the candlestick reader to the doji chart so that the data can be displayed properly

            chartDoji.ChartAreas["OHLC"].AxisX.ScaleView.Zoomable = true;///this enables the zoom for the x-axis
            chartDoji.ChartAreas["OHLC"].AxisY.ScaleView.Zoomable = true;///this enables the zoom for the y-axis
            chartDoji.ChartAreas["OHLC"].CursorX.AutoScroll = true;///this allows the chart to scroll if there is enough data present
            chartDoji.ChartAreas["OHLC"].CursorX.IsUserSelectionEnabled = true;/// allows the user to have control over what area on the x-axis they will zoom

        }
        List<aRecognizor> recognizors = new List<aRecognizor>(32);
          private List<aRecognizor> initializeRecognizer()
          {
              aRecognizor recognizor = null;

              recognizor = new Recognizer_Bullish();
              recognizors.Add(recognizor);

              recognizor = new Recognizer_Bearish();
              recognizors.Add(recognizor);

              recognizor = new Recognizer_Neutral();
              recognizors.Add(recognizor);

              recognizor = new Recognizer_NeutralDoji();
              recognizors.Add(recognizor);

              recognizor = new Recognizer_Doji();
              recognizors.Add(recognizor);

              recognizor = new Recognizer_DragonFly();
              recognizors.Add(recognizor);

              recognizor =  new Recognizer_GravestoneDoji();
              recognizors.Add(recognizor);

              recognizor = new Recognizer_longLeggedDoji();
              recognizors.Add(recognizor);

              recognizor = new Recognizer_Hammer();
              recognizors.Add(recognizor);

              recognizor =  new Recognizer_BullishHammer();
              recognizors.Add(recognizor);

              recognizor = new Recognizer_BearishHammer();
              recognizors.Add(recognizor);

              recognizor = new Recognizer_invertedHammer();
              recognizors.Add(recognizor);

              recognizor = new Recognizer_bullishInvertedHammer();
              recognizors.Add(recognizor);

              recognizor = new Recognizer_bearishInvertedHammer();
              recognizors.Add(recognizor);

              recognizor = new Recognizer_Marubozu();
              recognizors.Add(recognizor);

              recognizor = new Recognizer_blackMarubozu();
              recognizors.Add(recognizor);

              recognizor = new Recognizer_whiteMarubozu();
              recognizors.Add(recognizor);

              recognizor = new EngulfingBullishCandlestick_Recognizer();
              recognizors.Add(recognizor);

              recognizor = new EngulfingBearishCandlestick_Recognizer();
              recognizors.Add(recognizor);

            recognizor = new BullishHaramiCandlestick_Recognizer();
            recognizors.Add(recognizor);

            recognizor = new BearishHaramiCandlestick_Recognizer();
            recognizors.Add(recognizor);

            recognizor = new PeakCandlestick_Recognizer();
            recognizors.Add(recognizor);

            recognizor = new ValleyCandlestick_Recognizer();
            recognizors.Add(recognizor);


              comboBoxDoji.Items.Clear();///this double checks to ensure that the combo box is clear before adding the doji types and patterns
              foreach (aRecognizor r in recognizors)
              {
                  comboBoxDoji.Items.Add(r.patternName);///this is the line that actually adds the patterns or doji types
              }
              comboBoxDoji.Enabled = true;

              return recognizors;

      }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();///this closes the form when the button is clicked
        }
           private void buttonLoadPattern_Click(object sender, EventArgs e)
           {




        
            }

        private void dojiChart_Load(object sender, EventArgs e)
        {

        }

        private void dojiChart_MouseEnter(object sender, EventArgs e)///tihs will just add all the doji types that the chart needs to discern and then annotate
        {

        }

        private void comboBoxDoji_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateChart();///this calls the updateChart so that when another index is selected in the combo box the chart is updated with the new data and padding is added
            chartDoji.Annotations.Clear();///this clears the previous annotations from the chart when a new index is selected

            aRecognizor recognizor = recognizors[comboBoxDoji.SelectedIndex];///Get the selected doji recognizor from the comboBox

            List<int> retcon = recognizor.recongize(candleStick);///Recognize the patterns in the candlestick data


            foreach (int i in retcon)///this is the loop that adds the actual retangle next to the doji in the chart
            {
                RectangleAnnotation ra = new RectangleAnnotation();///this sets the shape
                ra.Text = recognizor.patternName;///this sets the correct name inside the rectangle
                ra.AnchorDataPoint = chartDoji.Series["OHLC"].Points[i];///this sets the position for the rectangle to be
                chartDoji.Annotations.Add(ra);///this is the line that actually adds the rectangle
                MessageBox.Show("called!!!!!");
            }
        }

        private void updateChart()
        {
                var dataSource = chartDoji.DataSource as List<candleStick>;///this sets the datasource at the chart

                /// Update the chart area based on the data source
                {
                    candleStick = dataSource;///this assigns the datasource to a local variable

                    double maxY = candleStick.Max(cs => cs.High);///this finds the max value for the y-axis based off the stock file
                    double minY = candleStick.Min(cs => cs.Low);///this finds the min valuse for the y-axis based off the stock file

                    double padding = 0.10 * (maxY - minY);///this adds padding to the chart to make it easier to see if there is a larger amount of data

                    chartDoji.ChartAreas["OHLC"].AxisY.Maximum = maxY + padding;///this sets the new max for the padding to ensure no data gets cut when the padding gets added
                    chartDoji.ChartAreas["OHLC"].AxisY.Minimum = minY - padding;///this sets the new min for the padding to ensure no data gets cut when the padding gets added
                }
        }

        private void ChartView_Load(object sender, EventArgs e)
        {

        }

        private void ComboBoxPattern_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }
    }
}
