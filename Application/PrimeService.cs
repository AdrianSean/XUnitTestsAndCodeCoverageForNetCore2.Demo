using System;

namespace Application
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            if (candidate == 4) { return true; }

            throw new NotImplementedException("Please create a test first");
        }
    }
}
