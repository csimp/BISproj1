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
            obj.avg();

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

        public void avg()
        {
            int m = 23;
            int[] a = new int[m];
            int chk = 0;
            int nxt = 0;
            Random rnd = new Random();
            while (chk < 23)
            {
                nxt = rnd.Next(1,25);
                a[chk] = nxt;
                chk++;
            }
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum += a[i];
            }
            int avg = sum / m;
            Console.WriteLine("Average is {0}", avg);
        }
    }
}