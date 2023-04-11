﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week06_K158DZ.Abstractions;

namespace Week06_K158DZ.Entities
{
    public class BallFactory : IToyFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }

        //public Ball CreateNew()
        //{
        //    return new Ball();
        //}
    }
}
