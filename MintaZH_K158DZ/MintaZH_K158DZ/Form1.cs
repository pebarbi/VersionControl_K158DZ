using MintaZH_K158DZ.Abstractions;
using MintaZH_K158DZ.Entities;
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
using System.Xml;

namespace MintaZH_K158DZ
{
    public partial class Form1 : Form
    {
        List<Product> _products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            //var valami = LoadXml("Menu.Xml");
            this.AutoScroll = true;
            ProcessXml();
            DisplayProducts();
        }

        public string LoadXml(string FileName)
        {
            using (StreamReader sr = new StreamReader(FileName, Encoding.Default))
            {
                //var output = sr.ReadLine();
                //while(!sr.EndOfStream)
                //{
                //    output += "\n" + sr.ReadLine();
                //}

                //var outputList = new List<string>();
                //while(!sr.EndOfStream)
                //{
                //    outputList.Add(sr.ReadLine());
                //}
                //var output = string.Join("\n", outputList);

                //var output = sr.ReadToEnd();
                //return output;

                return sr.ReadToEnd();
            }
        }

        public void ProcessXml()
        {
            var xmlText = LoadXml("Menu.Xml");

            var xml = new XmlDocument();
            xml.LoadXml(xmlText);
            //xml.Load("Menu.xlm"); lenne

            foreach (XmlElement item in xml.DocumentElement)
            {
                //var nameNode = (XmlElement)item.SelectSingleNode("name");
                //var name = nameNode.InnerText;

                var name = item.SelectSingleNode("name").InnerText; /*a fenti lenne, de így egyszerűbb*/
                var description = item.SelectSingleNode("description").InnerText; 
                var calories = item.SelectSingleNode("calories").InnerText; 
                var type = item.SelectSingleNode("type").InnerText;

                //if (type == "food")
                //{
                //    var food = new Food()
                //    {
                //        Title = name,
                //        Descriptipon = description,
                //        Calories = int.Parse(calories);
                //    }
                //    _products.Add(food);
                //}
                //if (type.Equals("drink")
                //{
                //    var drink = new Drink()
                //    {
                //        Title = name,
                //        Calories = int.Parse(calories);
                //}
                //_products.Add(drink);

                Product product = null;
                if (type.Equals("food"))
                {
                    (Food)product = new Food();
                }
                if (type.Equals("drink")
                {

                }
            }
        }
        private void DisplayProducts()
        {
            var orderedProducts = from p in _products
                                  orderby p.Title
                                  select p;

            //Product elozo = null;
            //foreach (var product in orderedProducts)
            //{
            //    this.Controls.Add(product);
            //    if (elozo != null)
            //    {
            //        product.Top = elozo.Top.Top + elozo.Height;
            //        elozo = product;
            //    }
            //    else
            //    {
            //    }
            //}

            var előzőTop = 0;
            foreach (var product in orderedProducts)
            {
                this.Controls.Add(product);
                product.Top = előzőTop;
                előzőTop += product.Height;
            }
    }
}