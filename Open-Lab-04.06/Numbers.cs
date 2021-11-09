using System;
using System.Collections.Generic;
namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            var done = new List<int> { };
            foreach(int n in numbers)
            {
                if(n % 2 == 0)
                {
                    done.Add(n);
                }
            }
            return done.ToArray();
        }
    }
}
