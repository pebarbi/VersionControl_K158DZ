using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyak4_2_K158DZ
{

    public partial class Form1 : Form
    {
        List<Flat> flats;
        RealEstateEntities context = new RealEstateEntities();


        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            flats = context.Flats.ToList();
        }
    }
}
