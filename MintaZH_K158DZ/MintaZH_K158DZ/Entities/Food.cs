using MintaZH_K158DZ.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MintaZH_K158DZ.Entities
{
    public class Food : Product
    {
        public string Descriptipon { }

        public Food()
        {
            Click += Food_Click;
        }

        private void Food_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("{0}\n{1}", Title, Description));
            //MessageBox.Show(Title + "\n" + Description)
        }

        public override void Display()
        {
            if (Calories < 750)
            {
                BackColor = Color.LightGreen;
            }
            else if (/*Calories >= 751 && */ Calories <= 1000)
            {
                BackColor = Color.LightYellow;
            }
            else
            {
                BackColor = Color.Salmon;
            }
        }
    }
}
