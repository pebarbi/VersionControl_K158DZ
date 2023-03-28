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

namespace _6.gyak_K158DZ
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();


        public Form1()
        {
            InitializeComponent();

            dgv1.DataSource = Rates.ToList();

            GetRates();

        }

        private void GetRates()
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
        }
    }
}
