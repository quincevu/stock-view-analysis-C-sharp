using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace COP_4635_Project_1
{
    public partial class Form1 : Form
    {
        candleStickReader candleStickReader = null;///this just makes sure that the candleStickReader always starts with empty information
        
        List<candleStick> candleStickBois = null;///this just makes sure that the candleStickBOis always starts with empty information

        List<string> selectedcandleSticks = new List<string>();// this is for storing multiple file names for opening at the button click event

        FileInfo[] Files = null;

        public static Form1 instance;

        public Form1()
        {
            InitializeComponent();
            candleStickReader= new candleStickReader();///this just insures that the candleStickReader is beginning with the empty candleStickReader that was just created
            instance = this;
            string fileName = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            string filePath = fileName + "/Stock Data/";
            DirectoryInfo d = new DirectoryInfo(filePath);
            Files = d.GetFiles("*.csv");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)///this creates the events for when the radiobuttons are clicked which can be referenced to later
        {
            foreach (string item in selectedcandleSticks)
            {
                dojiChart chart = new dojiChart();/// creates a new chart variable called dojiChart that can be referneced in the dojiChart.cs so the data can be manipulated
                candleStickBois = candleStickReader.readStock(item, dateTimePickerStart.Value, dateTimePickerEnd.Value);


                chart.chartDoji.DataSource = candleStickBois;///establishes where exactly the doji chart is getitng its data from so that it can be bound in the dojiChart.cs
                chart.Show();
                //form.dataGridView1.DataSource = candleStickBois;// because you said you don't need it to be shown in project 2
                //form.Show();
            }
            selectedcandleSticks.Clear();
        }
      
        private void radioButtonChart_CheckedChanged(object sender, EventArgs e)
        {
                
        }

        private void radioButtonDaily_CheckedChanged(object sender, EventArgs e)///this fills in the combo box with the correct file names when the day time period is chosen
        {
            string period = String.Empty;
            period = "Day";
            comboBoxTicker.Items.Clear();
            foreach (FileInfo file in Files)
            {
                if ((file.Name).Contains(period))
                {
                    comboBoxTicker.Items.Add(file.Name);
                }
            }
            comboBoxTicker.Items.Add(comboBoxTicker);
        }

        private void radioButtonWeekly_CheckedChanged(object sender, EventArgs e)///this fills in the combo box with the correct file names when the weekly time period is chosen
        {
            string period = String.Empty;
            period = "Week";
            comboBoxTicker.Items.Clear();
            foreach (FileInfo file in Files)
            {
                if ((file.Name).Contains(period))
                {
                    comboBoxTicker.Items.Add(file.Name);
                }
            }
            comboBoxTicker.Items.Add(comboBoxTicker);
        }

        private void radioButtonMonthly_CheckedChanged(object sender, EventArgs e)/// this fills in the combo box with the correct file names when the monthly time period is chosen
        {
            string period = String.Empty;
            period = "Month";
            comboBoxTicker.Items.Clear();
            foreach (FileInfo file in Files)
            {
                if((file.Name).Contains(period))
                {
                    comboBoxTicker.Items.Add(file.Name);
                }
            }
            comboBoxTicker.Items.Add(comboBoxTicker);
        }

        private void comboBoxTicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedcandleSticks.Add(comboBoxTicker.Text); // add the selected ticker to the list
            comboBoxTicker.SelectedIndex = -1; // reset the selected item
            comboBoxTicker.Text = string.Empty; // reset the textbox
        }
    }
}
