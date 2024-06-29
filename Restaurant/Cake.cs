﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double DefaultGrams = 250;
        private const double DefaultCalories = 1000;
        private const decimal DefaultCakePrice = 5;
        public Cake(string name) : base(name, DefaultCakePrice, DefaultGrams, DefaultCalories)
        {
        }
        
    }
}
