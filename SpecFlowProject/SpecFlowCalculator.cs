using System;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int result { get; set; }
        
        public List<int> ListNumber { get; set; } = null!;

        public int Add()
        {
            result = 0;
            foreach(int number in ListNumber)
            {
                result += number;
            }
            return result;
        }

        public int Multiply()
        {
            return FirstNumber * SecondNumber;
        }
        
        public int Divide()
        {
            return FirstNumber / SecondNumber;
        }
        
        public int AddN()
        {
            result = 0;
            foreach(int number in ListNumber)
            {
               result += number;
            }
            return result;
        }
        
        public int MultiplyN()
        {
            result = 1;
            foreach(int number in ListNumber)
            {
                result *= number;
            }
            return result;
        }
        
        public int DiviteN()
        {
            result = ListNumber[0];
            ListNumber.RemoveAt(0);
            foreach(int number in ListNumber)
            {
                result /= number;
            }
            return result;
        }
    }
}