namespace Practice_7
{
    class Factorial
    {
        private int fact = 0;

        public void SetFactorial(int fact)
        {
            this.fact = fact;
        }

        public int FactorialWithoutRecursion()
        {
            int total = 1;
            if (fact == 0 || fact == 1)
            {
                return 1;
            }
            for (int i = fact; i > 1; i--)
            {
                total *= i;
            }
            return total;
        }
        
        public int FactorialWithRecursion(int fact)
        {
            if (fact == 0 || fact == 1)
            {
                return 1;                
            }
            else
            {
                return fact * FactorialWithRecursion(fact-1);   
            }
        }
    }
}