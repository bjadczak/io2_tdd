namespace ClassLibrary
{
    public class Calculator
    {
        public int Add(string input)
        {
            return 0;
        }
        public int Substract(int x, int y)
        {
            return x - y;
        }
        public int Divide(int x, int y)
        {
            if (y == 0) return 0;
            return x / y;
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}