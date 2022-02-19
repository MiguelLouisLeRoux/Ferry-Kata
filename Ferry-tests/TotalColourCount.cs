using Xunit;
namespace Ferry_tests;

public class TotalColourCount
{
    [Fact]
    public void ShouldReturnATotalOf4ForSilverColouredCarsOnFerry()
    {
        Ferry ferry = new Ferry(10, 30);
        Car car1 = new Car("white", 2);
        Car car2 = new Car("black", 2);
        Car car3 = new Car("blue", 2);
        Car car4 = new Car("orange", 2);
        Car car5 = new Car("silver", 2);
        Car car6 = new Car("silver", 2);
        Car car7 = new Car("silver", 2);
        Car car8 = new Car("silver", 2);


        ferry.board(car1);
        ferry.board(car2);
        ferry.board(car3);
        ferry.board(car4);
        ferry.board(car5);
        ferry.board(car6);
        ferry.board(car7);
        ferry.board(car8);

        Assert.Equal(4, ferry.carColourCount("silver"));
    }

    [Fact]
    public void ShouldReturnATotalOf0ForAColourThatIsNotAddedToFerry()
    {
        Ferry ferry = new Ferry(10, 30);
        Car car1 = new Car("white", 2);
        Car car2 = new Car("black", 2);
        Car car3 = new Car("blue", 2);
        Car car4 = new Car("orange", 2);
        Car car5 = new Car("silver", 2);
        Car car6 = new Car("silver", 2);
        Car car7 = new Car("silver", 2);
        Car car8 = new Car("silver", 2);


        ferry.board(car1);
        ferry.board(car2);
        ferry.board(car3);
        ferry.board(car4);
        ferry.board(car5);
        ferry.board(car6);
        ferry.board(car7);
        ferry.board(car8);

        Assert.Equal(0, ferry.carColourCount("green"));
    }
}
