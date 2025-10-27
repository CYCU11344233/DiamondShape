using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 獲取變數
            Console.Write("請輸入菱形大小（建議奇數）:");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("請輸入正整數。");
                return;
            }

            // 計算菱形
            int midIndex = (n + 1) / 2;

            for (int i = 1; i <= n; i++) 
            {
                int spaceCount = Math.Abs(i-midIndex);
                int starCount = n - Math.Abs(i - midIndex) * 2;
                Console.WriteLine(new string(' ', spaceCount) + new string('*', starCount));
            }
        }
    }
}
