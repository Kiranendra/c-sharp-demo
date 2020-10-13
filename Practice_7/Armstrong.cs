using System;

namespace Practice_7
{
    class Armstrong
    {
        private int Number = 0;

        public void SetNumber(int Number)
        {
            this.Number = Math.Abs(Number);
        }

        public bool CheckArmstrong()
        {
            int a = Number;
            int b = 0;
            int sum = 0;
            if (a < 10)
            {
                return true;
            }
            while (a > 0)
            {
                b = a % 10;
                b = b * b * b;
                sum += b;
                a = a / 10;
            }
            if (sum == Number)
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