using System;

namespace StringInterning
{
    class Performance
    {
        private bool _intern;

        public Performance(bool intern)
        {
            _intern = intern;
        }

        private string GetString(string s) => _intern ? string.Intern(s) : s;

        public void Test()
        {
            string source = GetString("Twas brillig and the slithy toves".ToUpper());
            string target = GetString("Twas brillig and the slithy toves".ToUpper());

            int count = 0;

            var start = DateTime.UtcNow;

            for (int i = 0; i < 1_000_000_000; i++)
            {
                if (source == target)
                    ++count;
            }

            Console.WriteLine($"{(_intern ? "With" : "Without")} interning gives {count:N0} matches in {(DateTime.UtcNow - start).TotalMilliseconds:N0} milliseconds.");
        }
    }
}
