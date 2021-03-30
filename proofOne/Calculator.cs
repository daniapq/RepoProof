using System;
using System.Collections.Generic;
using System.Text;

namespace proofOne
{
    public class Calculator
    {
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }

        public Calculator(int nOne, int nTwo)
        {
            NumberOne = nOne;
            NumberTwo = nTwo;
        }
        public int Add() 
        {
            return NumberOne + NumberTwo;
        }

        public int Substract()
        {
            return NumberOne - NumberTwo;
        }

        public int Multiply()
        {
            return NumberOne * NumberTwo;
        }

        public int Divide()
        {
            return NumberOne / NumberTwo;
        }

    }
}
