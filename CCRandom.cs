using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CCRandom
{
    public static class Random
    {
        // GENERATION METHODS

        public static int GenerateNext(bool negative)
        {
            int return_value = 0;
            if (negative == false)
            {
                int tick_rev = Environment.TickCount;
                int tick_revv = (int)System.Math.Sqrt(Environment.TickCount);

                tick_rev = (int)((((tick_rev) * (int)(tick_revv / 3.14)) % 8192) * 11915.1);

                System.Random r = new System.Random();
                int choice = r.Next(1, 1000);

                tick_rev = (tick_rev * choice);


                if (tick_rev < 0)
                {
                    int difference = 0 - tick_rev;
                    tick_rev = difference;
                }

                return_value = tick_rev;
                return return_value;
            }
            else
            {
                int tick_rev = Environment.TickCount;
                int tick_revv = (int)System.Math.Sqrt(Environment.TickCount);

                tick_rev = (int)((((tick_rev) * (int)(tick_revv / 3.14)) % 8192) * 11915.1);

                System.Random r = new System.Random();
                int choice = r.Next(1, 1000);

                tick_rev = (tick_rev * choice);

                return_value = tick_rev;
                return return_value;
            }

        }

        public static int GenerateNext(int min, int max)
        {
            int num = GenerateNext(false);

            return 0;
        }

        // SELECTION (CHOICE) METHODS

        public static int SelectInt(int[] collection)
        {
            int return_int = 0;

            System.Random r = new System.Random();
            int choice = r.Next(0, collection.Count());

            return_int = collection[choice];

            return return_int;
        }

        public static object Select(Array collection)
        {
            System.Random r = new System.Random();
            return collection.GetValue(r.Next(0, collection.Length - 1));
        }

        public static string SelectString(string[] collection)
        {
            string return_text = "";

            System.Random r = new System.Random();
            int choice = r.Next(0, collection.Count());

            return_text = collection[choice];

            return return_text;
        }
    }
}
