using _6.gyak_K158DZ.Entities;
using _6.gyak_K158DZ.MnbServiceReference;
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
using System.Xml;

namespace _6.gyak_K158DZ
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();


        public Form1()
        {
            InitializeComponent();

            dgv1.DataSource = Rates;

            //var r = GetRates();

            GetXmlData(GetRates());
            PrintChart();
        }

        private void PrintChart()
        {
            chartRateData.DataSource = Rates;

            var series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            //eddig as lényeg, a lentebbiek már csak formáznak
            series.BorderWidth = 2;

            var legend = chartRateData.Legends[0];
            legend.Enabled = false;

            var chartArea = chartRateData.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }

        private void GetXmlData(string result)
        {
            var xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement item in xml.DocumentElement)
            {
                var date = item.GetAttribute("date");

                var rate = (XmlElement)item.ChildNodes[0];

                var currency = rate.GetAttribute("curr");

                var value = decimal.Parse(rate.InnerText);

                var unit = int.Parse(rate.GetAttribute("unit"));

                Rates.Add(new RateData()
                {
                    Date = DateTime.Parse(date),
                    Currency = currency,
                    Value = unit !=0 
                            ? value/unit 
                            : 0 //ez a 3 sor az if gyosabb módja!!!
                }); 
            }
        }

        private string GetRates()
        {
            var mnbService = new MNBArfolyamServiceSoapClient(); //de lehetne MNBArfolyamServiceSoapClient mnbService = new MNBArfolyamServiceSoapClient() is

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;
            //richTextBox1.Text = result;

            return result;
        }
    }
}
