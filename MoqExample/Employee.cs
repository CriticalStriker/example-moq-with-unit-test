using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqExample
{
	public interface Employee
	{
		string Name
		{
			get;
		}

		DateTime GetDateOfJoining(int id);
	}
}
