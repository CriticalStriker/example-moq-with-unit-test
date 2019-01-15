using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqExample
{
	public class HandleString
	{
		public string Concat(string name, string surname)
		{
			return name + " " + surname;
		}
	}

	public class HandleMath
	{
		public int Devide(int a, int b)
		{
			return a / b;
		}
	}
}
