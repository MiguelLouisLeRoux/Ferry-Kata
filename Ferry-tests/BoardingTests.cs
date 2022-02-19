using Xunit;
namespace Ferry_tests;

public class BoardingTests
{
    [Fact]
    public void ShouldReturnAcceptedWhenBoaringACarUnderMaximumCapacity()
    {
        Ferry ferry = new Ferry(5, 10);
        Car car1 = new Car("white", 2);

        Assert.Equal("Accepted", ferry.board(car1));
    }

    [Fact]
    public void ShouldReturnRejectedWhenMaximumFerryCapacityHasBeenReached()
    {
        Ferry ferry = new Ferry(5, 10);
        Car car1 = new Car("white", 2);
        Car car2 = new Car("black", 2);
        Car car3 = new Car("blue", 2);
        Car car4 = new Car("orange", 2);
        Car car5 = new Car("silver", 2);
        Car car6 = new Car("red", 2);

        ferry.board(car1);
        ferry.board(car2);
        ferry.board(car3);
        ferry.board(car4);
        ferry.board(car5);

        Assert.Equal("Rejected", ferry.board(car6));
    }
}
