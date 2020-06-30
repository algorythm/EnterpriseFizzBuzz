using System.Text;

namespace FizzBuzz.Library.Model
{
    public class FizzBuzzModel
    {
        private const string FIZZ = "Fizz";
        private const string BUZZ = "Buzz";
        public int Value { get; set; }
        private StringBuilder StringBuilder { get; }

        public FizzBuzzModel()
        {
            Value = 0;
            StringBuilder = new StringBuilder(4);
        }

        public FizzBuzzModel(int value) : this()
        {
            Value = value;
        }

        public string Result
        {
            get
            {
                string fizzBuzzValue = Value.ToString();
                
                if (Value % 15 == 0)
                {
                    var fizzes = new char[FIZZ.Length];
                    var buzzes = new char[BUZZ.Length];

                    for (var i = 0; i < FIZZ.Length; i++)
                    {
                        fizzes[i] = FIZZ[i];
                    }

                    StringBuilder.Append(fizzes);

                    for (var i = 0; i < BUZZ.Length; i++)
                    {
                        buzzes[i] = BUZZ[i];
                    }

                    StringBuilder.Append(buzzes);

                    fizzBuzzValue = StringBuilder.ToString();
                }
                else if (Value % 3 == 0)
                {
                    fizzBuzzValue = FIZZ;
                }
                else if (Value % 5 == 0)
                {
                    fizzBuzzValue = BUZZ;
                }
                
                return fizzBuzzValue;
            }
        }
    }
}
