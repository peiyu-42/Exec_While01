using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	/* 使用 while , 在畫面顯示所有可以整除 300 的整數
	 * 例如: 1, 2, 3, 4, 5, 6, 10, ...., 300
	 */
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = 300;
			WhileForDivision result = new WhileForDivision();
			Console.WriteLine($"所有可以整除 {number} 的整數");
			result.DivisorNumber(number);
		}
	}
	class WhileForDivision
	{
		public void DivisorNumber(int number) 
		{
			int divisor = 1; // 除數
			while (divisor <= number)
			{
				if (number % divisor == 0)
				{
					Console.WriteLine(divisor);
				}
				divisor++;
			}
		}
	}

}
