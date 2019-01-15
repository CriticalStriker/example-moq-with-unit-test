using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace MoqExample
{
	class Program
	{
		static void Main(string[] args)
		{
			var employee = new Mock<Employee>();
			employee.Setup(x => x.GetDateOfJoining(It.IsAny<int>())).Returns((int x) => DateTime.Now);
			employee.SetupGet(m => m.Name).Returns("donald trump");

			Console.WriteLine(employee.Object.GetDateOfJoining(1));
			Console.WriteLine(employee.Object.Name);

			try
			{
				employee.Verify((m => m.GetDateOfJoining(1)), Times.Once);
				employee.Verify((m => m.Name), Times.Never);
			}
			catch (Exception e)
			{
				Console.WriteLine("verify exception");
				Console.WriteLine(e.Message);
			}
		}
	}
}
