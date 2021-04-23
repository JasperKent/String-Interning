using System;

namespace StringInterning
{
    class Program
    {
        static void Main()
        {
            //string s1 = "Hello";
            //string s2 = "World";
            //string s3 = string.IsInterned(s1 + s2);

            //Console.WriteLine(s3 ?? "Not found");

            //Console.WriteLine(s3 == "HelloWorld");
            //Console.WriteLine(ReferenceEquals(s3, "HelloWorld"));

            //Point p1 = new(3, 4);
            //Point p2 = new(3, 4);

            //Console.WriteLine(p1 == p2);

            //Console.WriteLine(ReferenceEquals(p1,p2));

            Performance p1 = new Performance(false);
            Performance p2 = new Performance(true);

            p1.Test();
            p2.Test();
          
        }
    }
}
