﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDlib
{
    public struct Point
    {
        public int x {  get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x; 
            this.y = y;
        }

        public override string ToString() { 
          return this.x + "," + this.y;
        
        }



    }
}
