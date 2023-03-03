namespace ClassLibrary
{
    public class Calculator
    {
        public int Add(string input)
        {
            if(String.IsNullOrEmpty(input))
                return 0;
            if(int.TryParse(input, out int result)) 
                return result;
            return 0;
        }
    }
}