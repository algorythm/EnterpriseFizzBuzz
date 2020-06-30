namespace FizzBuzz.Library.Parser
{
    public class IntegerParser : IIntegerParser
    {
        public bool IsInteger(string str)
        {
            int.TryParse(str.Trim(), out var result);

            if (result == 0 && str != "0")
            {
                return false;
            }

            return true;
        }
    }
}
