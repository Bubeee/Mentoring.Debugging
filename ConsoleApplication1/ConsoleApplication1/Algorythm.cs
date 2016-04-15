using System;
using System.Linq;
using System.Net.NetworkInformation;

namespace ConsoleApplication1
{
    class Algorythm
    {
        static void Main(string[] args)
        {
            var str = new string[] {"4", "15", "2016"};
            Console.WriteLine(method_0(str));
        }


        public static bool method_0(string[] string_2)
        {
            Class0 class2;
            NetworkInterface interface2;
            int num2;
            goto Label_009B;
        Label_0006:
            num2 = 3;
            int num = num2;
        Label_0085:
            switch (num)
            {
                case 0:
                    num2 = 1;
                    if (num2 == 0)
                    {
                    }
                    num2 = 0;
                    if (num2 == 0)
                    {
                    }
                    if (interface2 == null)
                    {
                        num2 = 2;
                        num = num2;
                    }
                    else
                    {
                        num2 = 1;
                        num = num2;
                    }
                    goto Label_0085;

                case 1:
                    num2 = 0;
                    class2.byte_0 = BitConverter.GetBytes(DateTime.Now.Date.ToBinary());
                    class2.int_0 = Enumerable.Select<string, int>(string_2, new Func<string, int>(int.Parse)).ToArray<int>();
                    return interface2 != null
                           && interface2.GetPhysicalAddress()
                                  .GetAddressBytes()
                                  .Select(class2.method_0)
                                  .Select(c.nine__3_1 ?? (c.nine__3_1 = c.nine.method_0))
                                  .ToArray()
                                  .Select(class2.method_1)
                                  .All(c.nine__3_3 ?? (c.nine__3_3 = c.nine.method_1));

                case 2:
                    goto Label_0006;

                case 3:
                    return false;
            }
        Label_009B:
            class2 = new Class0();
            interface2 = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault<NetworkInterface>();
            num2 = 0;
            num = num2;
            goto Label_0085;
        }

        private sealed class c
        {
            // Fields
            public static readonly c nine;
            public static Func<int, int> nine__3_1;
            public static Func<int, bool> nine__3_3;
            /* private scope */

            // Methods
            static c()
            {
                int num = 0x791c;
                num = 0x791c;
                switch ((num == num))
                {
                }
                num = 1;
                if (num == 0)
                {
                }
                num = 0;
                if (num == 0)
                {
                }
                num = 0;
                nine = new c();
            }

            internal int method_0(int int_0)
            {
                if (int_0 > 0x3e7)
                {
                    return int_0;
                }
                int num = 0x43d1;
                num = 0x43d1;

                num = 0;
                if (num == 0)
                {
                }
                num = 0;
                num = 1;
                if (num == 0)
                {
                }
                return (int_0 * 10);
            }

            internal bool method_1(int int_0)
            {
                int num = 0x35e;
                num = 0x35e;
                switch ((num == num))
                {
                }
                num = 1;
                if (num == 0)
                {
                }
                num = 0;
                if (num == 0)
                {
                }
                num = 0;
                return (int_0 == 0);
            }
        }


        private sealed class Class0
        {
            // Fields
            public byte[] byte_0;
            public int[] int_0;
            [NonSerialized]
            /* private scope */
            string string_0;

            // Methods
            internal int method_0(byte byte_1, int int_1)
            {
                int num = 0x1e8f;
                num = 0x1e8f;
                switch ((num == num))
                {
                }
                num = 1;
                if (num == 0)
                {
                }
                num = 0;
                if (num == 0)
                {
                }
                num = 0;
                return (byte_1 ^ this.byte_0[int_1]);
            }

            internal int method_1(int int_1, int int_2)
            {
                int num = -18476;
                num = -18476;
                switch ((num == num))
                {
                }
                num = 1;
                if (num == 0)
                {
                }
                num = 0;
                if (num == 0)
                {
                }
                num = 0;
                return (int_1 - this.int_0[int_2]);
            }
        }
    }
}
