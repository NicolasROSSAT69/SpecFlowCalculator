using System;

namespace SpecFlowCalculator
{
    public class Calculator
    {
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
            result = 1;
            foreach(int number in ListNumber)
            {
                result *= number;
            }
            return result;
        }
        
        public int Divide()
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