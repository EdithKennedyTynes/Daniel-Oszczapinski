﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonModels
{
    internal class Ability
    {
        public string Name { get; set; }
        private int _PP;
        public int PP
        {
            get { return _PP; }

            set
            {
                if (value > 0)
                    _PP = value;
                else
                    throw new Exception("You cannot set PP lower than 0!");
            }
        }
            public int Power { get; set; }
            public int Accuracy { get; set; }

 
        
    }
}
