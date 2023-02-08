using System;
using System.Collections.Generic;
using System.Text;


namespace Assignment2_Group4
{
    public class Circle
    {
        private int pvtradius { get; set; }
        public int InputRadius;
        public Circle() //default constructor
        {
            pvtradius = 1;
        }

        // Parameterised Constructor
        public Circle(int InputRadius)
        {
            pvtradius = InputRadius;
        }
        public int GetRadius()
        {
            return pvtradius;
        }

        public void SetRadius(int inputRadius)
        {
            pvtradius = inputRadius;
        }

        public double GetCircumference()
        {


            return 2 * Math.PI * this.pvtradius;

        }

        public double GetArea()
        {
            return Math.PI * pvtradius * pvtradius;
        }

    }
}
