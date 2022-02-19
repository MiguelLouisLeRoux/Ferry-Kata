using Xunit;
namespace Ferry_tests;

public partial class TotalCarAndPeopleCountTests
{
    [Fact]
    public void ShouldReturnATotalCountOf5CarsOnFerry()
    {
        Ferry ferry = new Ferry(5, 10);
        Car car1 = new Car("white", 2);
        Car car2 = new Car("black", 2);
        Car car3 = new Car("blue", 2);
        Car car4 = new Car("orange", 2);
        Car car5 = new Car("silver", 2);

        ferry.board(car1);
        ferry.board(car2);
        ferry.board(car3);
        ferry.board(car4);
        ferry.board(car5);

        Assert.Equal(5, ferry.car_count);
    }

    [Fact]
    public void ShouldReturnATotalCountOf10PeopleOnFerry()
    {
        Ferry ferry = new Ferry(10, 30);
        Car car1 = new Car("white", 2);
        Car car2 = new Car("black", 2);
        Car car3 = new Car("blue", 2);
        Car car4 = new Car("orange", 2);
        Car car5 = new Car("silver", 2);

        ferry.board(car1);
        ferry.board(car2);
        ferry.board(car3);
        ferry.board(car4);
        ferry.board(car5);

        Assert.Equal(10, ferry.people_count);
    }
    
}
