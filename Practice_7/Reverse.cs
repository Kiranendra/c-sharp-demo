using System;

namespace Practice_7
{
    class Reverse
    {
        private int integer = 0;
        private int recursiveResult = 0;
        private int i = 1;
        private int index = 0;
        private string String = "";
        private string recursiveString = "";

        public void SetInteger(int integer)
        {
            this.integer = Math.Abs(integer);
        }

        public void SetString(string String)
        {
            this.String = String;
            this.index = String.Length;
        }

        public int ReverseIntegerWithoutRecursion()
        {
            int a = integer;
            int result = 0;
            if (integer < 10)
            {
                return integer;                
            } 
            else
            {
                while (a > 0)
                {
                    result = (result * 10) + (a % 10);
                    a = a / 10;
                }
                return result;
            }
        }

        public int ReverseIntegerWithRecursion(int number)
        {
            if (number > 0)
            {
                ReverseIntegerWithRecursion(number / 10);
                recursiveResult += (number % 10) * i;
                i *= 10;
            }
            return recursiveResult;
        }

        public string ReverseStringWithoutRecursion()
        {
            string reverse = "";
            for (int i = String.Length-1; i >= 0; i--)
            {
                reverse += String[i].ToString();
            }
            return reverse;
        }

        public string ReverseStringWithRecursion(string String)
        {
            if (index > 0)
            {
                index--;
                recursiveString += String.Substring(index);
                ReverseStringWithRecursion(String.Remove(index));
            }
            return recursiveString;
        }
    }
}