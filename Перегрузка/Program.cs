using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузка
{
    using System;

    namespace Перегрузки
    {
        class UserInfo
        {
            public void Sum()
            {
                Console.WriteLine("Пустой метод");
            }

            public void Sum(int a, int b)
            {
                Console.WriteLine($"Первое значение:{a + b}");
            }

            public void Sum(int a, int b, int c)
            {
                Console.WriteLine($"Второе значение:{a + b + c}");
            }

            public void Sum(int a, int b, int c, int d)
            {
                Console.WriteLine($"Третье значение:{a + b + c + d}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // 1
                UserInfo us1 = new UserInfo();
                us1.Sum(5, 4);
                us1.Sum(5, 4, 7);
                us1.Sum(5, 4, 7, 10);
                Console.ReadLine();

                // 2
                UserInfo2 obj1 = new UserInfo2();
                UserInfo2 obj2 = new UserInfo2(hight: 50, ves: 10.85);
                Console.WriteLine($"obj1: ", obj2.hight, obj2.ves);
                UserInfo2 obj3 = new UserInfo2(hight: 50, ves: 10.85, width: 28);
                Console.ReadLine();
                UserInfo3 arr = new UserInfo3();
                arr[0] = 1;
                arr[1.123] = 2;
                arr[1.89] = 3;
                arr[3.01] = 4;
                arr[4.222] = 5;
                Console.WriteLine("Массив:");
                for (int i = 0; i < arr.Length; i++)
                    Console.Write("{0}\t", arr[i]);
                Console.ReadLine();
            }
        }

        class UserInfo2
        {
            public int hight, width;
            public double ves;

            public UserInfo2()
            {

            }
            public UserInfo2(int hight, double ves)
            {
                this.hight = hight;
                this.ves = ves;
                Console.WriteLine($"Рост: {hight}, Вес: {ves}");
            }
            public UserInfo2(int hight, double ves, int width)
            {
                this.hight = hight;
                this.ves = ves;
                this.width = width;
                Console.WriteLine($"Рост: {hight}, Вес: {ves}, Ширина: {width}");
            }
        }

        class UserInfo3
        {
            int[] arr;
            public int Length;
            public void Sums(int Size)
            {
                arr = new int[Size];
                Length = Size;
            }
            public int this[double index = 5]
            {
                get
                {
                    return arr[(int)Math.Round(index)];
                }
                set
                {
                    arr[(int)Math.Round(index)] = value + 5;
                }
            }
        }
    }
}
