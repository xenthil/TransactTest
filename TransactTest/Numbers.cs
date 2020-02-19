using System.Collections.Generic;

namespace TransactTest
{
    public class Numbers
    {
        int _low;
        int _high;
        int _a;
        int _b;

        public Numbers(int low, int high, int a, int b)
        {
            _low = low;
            _high = high;
            _a = a;
            _b = b;
        }        

        public List<string> GetOutput()
        {
            string result;
            var output = new List<string>();

            for (int number = _low; number <= _high; number++)
            {
                result = string.Empty;

                if (number % _a == 0)
                {
                    result = "Fancy";
                }
                if (number % _b == 0)
                {
                    result += "Pants";
                }

                output.Add(string.IsNullOrEmpty(result) ? number.ToString() : result);
            }

            return output;
        }
    }
}
