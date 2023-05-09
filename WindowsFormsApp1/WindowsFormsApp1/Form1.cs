using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Gender g = Gender.Female; //így kell létrehozni egy enumeráció pédányosítást, mert ez nem osztály!!!
            //pl
            if (g == Gender.Female)
            {

            }

            var x = (Gender)2; //így lehet castolni kódszámokkal
        }
    }
}
