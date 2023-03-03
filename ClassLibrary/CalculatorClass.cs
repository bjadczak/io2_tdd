using System;

namespace ClassLibrary
{
    public class Calculator
    {
        public int Add(string input)
        {
            if(String.IsNullOrEmpty(input))
                return 0;
            if(int.TryParse(input, out int result) && result >= 0) 
                return result <= 1000 ? result : 0;
            else if(result < 0) throw new ArgumentOutOfRangeException("NEG");
            if(input.Contains(",") || input.Contains("\n"))
            {
                var numbers = input.Split(',', '\n');

                if(numbers.Length >=2 && numbers.Length <= 3)
                {
                    int sum = 0;
                    foreach(var number in numbers)
                    {
                        if (int.TryParse(number, out int num))
                            sum += num <= 1000 ? num : 0;
                        else
                            return 0;
                    }
                    return sum;
                }

            }
            return 0;
        }
    }
}