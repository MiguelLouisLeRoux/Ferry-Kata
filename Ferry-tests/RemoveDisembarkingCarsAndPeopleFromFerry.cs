using Xunit;
namespace Ferry_tests;

public partial class TotalCarAndPeopleCountTests
{
    public class RemoveDisembarkingCarsAndPeopleFromFerry
    {
        [Fact]
        public void ShouldDecrementTotalCarsCountOnFerryWhenACarIsRemoved()
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

            ferry.leavingFerry(car1);

            Assert.Equal(4, ferry.car_count);
        }

        [Fact]
        public void ShouldDecrementTotalPeopleCountOnFerryWhenACarIsRemoved()
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

            ferry.leavingFerry(car3);

            Assert.Equal(8, ferry.people_count);
        }
    }   
}