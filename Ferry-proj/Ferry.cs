public class Ferry
{
    public int maxCars { get; }
    public int maxPeople { get; }
    public Ferry (int _maxCars, int _maxPeople)
    {
        maxCars = _maxCars;
        maxPeople = _maxPeople;
    }

    public List<Car> carList = new List<Car>();

    public int car_count { get; set; }

    public int people_count { get; set; }

    public string board(Car _car)
    {
        
        if (carList.Count < maxCars)
        {
            if (carList.Contains(_car))
            {
                if(_car.ferryTripsCount + 1 == 3)
                {
                    _car.ferryTripsCount += 1;
                    car_count = carList.Count;
                    people_count = carList.Sum(val => val.PassangerCount);
                    return "Half price!";
                } else if(_car.ferryTripsCount + 1 == 7)
                {
                    _car.ferryTripsCount += 1;
                    car_count = carList.Count;
                    people_count = carList.Sum(val => val.PassangerCount);
                    return "You go free!";
                } else
                {
                    _car.ferryTripsCount += 1;
                    car_count = carList.Count;
                    people_count = carList.Sum(val => val.PassangerCount);
                    return "Accepted";
                }

            } else
            {
                Random rnd = new Random();
                _car.car_id = rnd.Next(10000000);
                _car.ferryTripsCount = 1;
                carList.Add(_car);
                car_count = carList.Count;
                people_count = carList.Sum(val => val.PassangerCount);
                return "Accepted";
            }
        } else
        {

            car_count = carList.Count;
            people_count = carList.Sum(val => val.PassangerCount);
            return "Rejected";
        }
    }

    public int carColourCount(string colour)
    {
        var colourCount = carList.FindAll(val => val.Colour == colour);
        return colourCount.ToList().Count;
    }

    public void leavingFerry(Car leavingCar)
    {
        if (carList.Contains(leavingCar))
        {
            int index = carList.FindIndex(val => val.car_id == leavingCar.car_id);
            carList.RemoveAt(index);
            car_count = carList.Count;
            people_count = carList.Sum(val => val.PassangerCount);
        }
    }
}