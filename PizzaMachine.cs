﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class PizzaMachine
    {
    }
    enum PizzaType
    {
        Margherita,
        Pepperoni,
        Veggie,
        Quattro_Stagioni,
        Canibale
    }
    class Pizza
    {
        private PizzaType mIngredients;
        public PizzaType Ingredients
        {
            get
            {
                return mIngredients;
            }
            set => mIngredients = value;
        }
            private float mPrice = .50F;
        public float Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        private readonly DateTime mTimeofCreation;


    }
}
