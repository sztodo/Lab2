using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Lab2

{
    public delegate void PizzaCompleteDelegate();
    public event PizzaCompleteDelegate PizzaComplete;
    class PizzaMachine: Component
    {
        private PizzaType mIngredients;
        public PizzaType Ingredients
        {
            get { return mIngredients; }
            set { mIngredients = value; }
        }
        private System.Collections.ArrayList mPizzas = new System.Collections.ArrayList();
        public Pizza this[int Index]
        {
            get
            {
                return (Pizza)mPizzas[Index];
            }
            set
            {
                mPizzas[Index] = value;
            }
        }
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
        public DateTime TimeOfCreation
        {
            get { return mTimeofCreation; }
        }
        public Pizza(PizzaType aIngredients)
        { mTimeofCreation = DateTime.Now;
            mIngredients = aIngredients;
        }
    }
}
