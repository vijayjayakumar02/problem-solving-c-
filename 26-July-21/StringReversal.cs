using System;

namespace _26_July_21
{
    class StringReversal
    {
        public void main()
        {
            System.Console.WriteLine("Enter the string: ");
            string sentence = Console.ReadLine();
            string rev = "";
            if (sentence.Length == 0)
                System.Console.WriteLine("String is empty");
            //creating method and passing the arguments
            else
                rev = Reverse(sentence);
            System.Console.WriteLine(rev);
        }

        public string Reverse(string str)
        {
            if (str.Length == 0)
            {
                return str;
            }
            return Reverse(str.Substring(1)) + str[0]; //calling function recursively
            //str.substring(1) everything else after 1st position
        }
    }
}