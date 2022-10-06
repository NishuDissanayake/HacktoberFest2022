using CalLibrary;

using FluentAssertions;

using Xunit;

namespace Tests
{
	public class CalculationsTests
	{
		[Fact]
		public void Given_Num1_And_Num2_When_Addition_Then_ReturnExpetedResult()
		{
			//Arrange
			int num1 = 2;
			int num2 = 3;
			int expectedResult = 5;

			//Act
			double result = Calculations.Addition(num1, num2);

			//Assert
			result.Should().Be(expectedResult);
		}
	}
}
