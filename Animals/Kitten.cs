﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Kitten : Cat
    {
        private const string KitteGander = "Female";
        public Kitten(string name, int age) : base(name, age, KitteGander)
        {
        }
        public override string ProduceSound() => "Meow";
    }
}
