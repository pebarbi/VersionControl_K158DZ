using MintaZH_K158DZ.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintaZH_K158DZ.Entities
{
    public class Drink : Product
    {
        public override void Display()
        {
            BackColor = Color.LightBlue;
        }
    }
}
