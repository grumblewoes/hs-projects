using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Calculator
    {
        //solution explorer, right click, add class



        //FIELDS

        //private = can't say "firstNum equals in form1"/ get or recieve
        private double firstNumber;
        private double secondNumber;
        private int operation;
        private bool result;

        //PROPERTIES
        #region PROPERTIES
        public double FirstNumber //must spell differently than field
        {
            get { return firstNumber; } //fetch a stored variable
            set { firstNumber = value; } //set value
        }

        public double SecondNumber
        {
            get { return secondNumber; }
            set { firstNumber = value; }
        }

        public int Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        public bool Result
        {
            get { return result; }
            set { result = value; }
        }

        #endregion

        //CONSTRUCTORS; sets values for fields, tells pc how much memory needed
        #region CONSTRUCTORS
        public Calculator() //default constructor  
            /*
             * public Calulator (double first, double second)
             * {
             * first = first;
             * second = second;
             * operation = 0;
             * result = false;
             */
        {
            firstNumber = 0;
            secondNumber = 0;
            operation = 0;
            result = false;
        }
        #endregion

        //METHODS; functionality of the class
        #region METHODS
        //addition
        public double Addition()
        {
            return firstNumber + secondNumber;
        }

        //subtraction
        public double Subtraction()
        {
            return firstNumber - secondNumber;
        }
        
        //multiplication
        public double Multiplication()
        {
            return firstNumber * secondNumber;
        }

        //division
        public double Division()
        {
            return firstNumber / secondNumber;
        }

        //power
        public double Exponent()
        {
            return Math.Pow(firstNumber, secondNumber);
        }

#endregion
        //allows us to use any of these operations when "Calculator.()" is called in the form
    }
}
