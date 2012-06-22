using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace MyCalc
{
    public class Calc
    {
        public float FirstArg { get; set; }

        public float SecondArg { get; set; }

        public string Result { get; set; }

        public IOut Out { get; set; }

        public void Add(int firstOperator, int secondOperator )
        {
            FirstArg = firstOperator;
            SecondArg = secondOperator;
            Result = (FirstArg + SecondArg).ToString();
           
        }

        public void Substract(int firstOperator, int secondOperator)
        {
            FirstArg = firstOperator;
            SecondArg = secondOperator;
            Result = (FirstArg - SecondArg).ToString();
            
            
        }

        public void Multiply(int firstOperator, int secondOperator)
        {
            FirstArg = firstOperator;
            SecondArg = secondOperator;
            Result = (FirstArg * SecondArg).ToString();
           

        }

        public void Divide(int firstOperator, int secondOperator)
        {
            FirstArg = firstOperator;
            SecondArg = secondOperator;
            Result = (FirstArg/SecondArg).ToString();
            
              
        }

        public void Print()
        {
            Out.Out(Result);
        }

       


    }
}
