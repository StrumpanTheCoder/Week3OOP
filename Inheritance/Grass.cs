﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Grass : IEdible
    {
        public Grass(double weight)
        {
            Weight = weight;
        }
        public double Weight { get; set; }
    }
}
