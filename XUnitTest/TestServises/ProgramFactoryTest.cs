using Xunit;
using DesignPatterns.Services;
using DesignPatterns.Modules;

namespace XUnitTest.TestServises
{
	public class ProgramFactoryTest
	{
		ProgramFactory _programFactory;
		public ProgramFactoryTest()
		{
			_programFactory = new ProgramFactory(new LoggerService());
		}

		[Fact]
		public void CreateNotNullProgramTest()
		{

			var program = _programFactory.Create(nameof(AdapterProgram));

			Assert.Equal(typeof(AdapterProgram), program.GetType());
			Assert.NotEqual(typeof(NullProgram), program.GetType());
		}

		[Fact]
		public void CreateNullProgramTest()
		{
			var program = _programFactory.Create("");

			Assert.Equal(typeof(NullProgram), program.GetType());
			Assert.NotEqual(typeof(AdapterProgram), program.GetType());
		}
	}
}
