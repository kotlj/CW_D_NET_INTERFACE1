using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_D_NET_INTERFACA1
{
    internal class Program
    {
        interface IOutput
        {
            void Show();
            void Show(string info);
        }

        class Array : IOutput
        {
            private int[] arr;
            public Array(int[] _arr)
            {
                this.arr = _arr;
            }
            public new void Show()
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            public new void Show(string info)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine(info);
            }
        }
        static void Main(string[] args)
        {
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Array test = new Array(temp);
            test.Show();
            test.Show("Done?");
        }
    }
}
