﻿using System;

namespace FoodDisplayApp.Core
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public Cuisine Cuisine { get; set; }
    }
}
