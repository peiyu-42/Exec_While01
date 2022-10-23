using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		/* 1+ 2 + 3 + 4 + .... + N <105
		 * 請問 N 是多少 ?*/
		static void Main(string[] args)
		{
			WhileSum result = new WhileSum();
			int n = result.SumToN(105);
			Console.WriteLine($"N= {n}");
		}
		
	}
	class WhileSum
	{
		public int SumToN(int number)
		{
			// 若1加到最大值n小於number，則傳回n
			int sum = 1;
			int n = 1;
			while (sum < number)
			{
				n++;
				sum += n;
			}
			if (sum >= number)
			{ n--; }
			return n;
		}
	}
}
