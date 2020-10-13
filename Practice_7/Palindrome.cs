namespace Practice_7
{
    class Palindrome
    {
        private int Number = 0;
        private string String = "";
        private static Reverse reverse = new Reverse();

        public void SetInteger(int Number)
        {
            this.Number = Number;
        }

        public void SetString(string String)
        {
            this.String = String;
        }

        public bool PalindromeCheckInteger()
        {
            reverse.SetInteger(Number);
            if (Number.Equals(reverse.ReverseIntegerWithoutRecursion()))
            {
                return true;
            } 
            else 
            {
                return false;
            }
        }

        public bool PalindromeCheckString()
        {
            reverse.SetString(String);
            if (String.Equals(reverse.ReverseStringWithoutRecursion()))
            {
                return true;
            } 
            else 
            {
                return false;
            }
        }
    }
}