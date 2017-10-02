using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGeneratorLib
{
    public class NumberGenerator
    {
        public event Action<bool, int> Even;

        static Random random = new Random();

        public void GetRandomNumbers()
        {
            int number = 10;

            for (int i = 0; i <= number; i++)
            {
                int temp = random.Next(0, 101);
                Even?.Invoke(temp % 2 == 0, temp);      // Uses modulus to get the even numbers
            }
        }

        public NumberGenerator()
        {

        }
    }
}
    

