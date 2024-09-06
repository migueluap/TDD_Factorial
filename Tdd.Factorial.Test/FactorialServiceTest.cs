namespace Tdd.Factorial.Test;

public class FactorialServiceTest
{
    [Fact]
    public void TestFactorialZero()
    {
        //Arrange
        FactorialService service = new FactorialService();

        //Act
        int result = service.Calculate(0);

        //Asert
        Assert.Equal(1, result);

    }


    [Fact]
    public void TestFactorialFive()
    {
        FactorialService service = new FactorialService();

        int result = service.Calculate(5);

        Assert.Equal(120, result);
    }
}