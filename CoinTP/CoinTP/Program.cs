using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinTP
{
    class checkyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("random string");
            int count = 0;
            while (count < 25)
            {
                Console.WriteLine(count);
                count++;
            }

            checkyear obj = new checkyear();
            obj.readdata();
            obj.leap();

            if (obj.isLeap == true)
            {
                Console.WriteLine("leap");
            }
            else
            {
                Console.WriteLine("no leap");
            }

            Console.ReadLine();
        }

        int y;
        bool isLeap;

        public void readdata()
        {
            DateTime dt = new DateTime();
            string s = dt.Year.ToString();
            y = Convert.ToInt32(s);
        }

        public void leap()
        {
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                isLeap = true;
            }
            else
            {
                isLeap = false;
            }
        }
    }
}