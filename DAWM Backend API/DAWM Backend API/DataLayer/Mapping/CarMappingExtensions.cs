using DAWM_Backend_API.DataLayer.Models;
using DAWM_Backend_API.DataLayer.Dtos;

namespace DAWM_Backend_API.DataLayer.Mapping
{
    public static class CarMappingExtensions
    {
        public static List<CarDto> ToCarDtoList(this List<Car> cars)
        {
            var returned = cars.Select(c=>c.ToCarDto()).ToList();

            return returned;
        }

        public static CarDto ToCarDto(this Car car)
        {
            if (car == null)
                return null;

            CarDto returned = new CarDto();
            returned.Drivetrain = car.Drivetrain;
            returned.Price = car.Price;
            returned.EngineCapacity = car.EngineCapacity;
            returned.EngineType = car.EngineType;
            returned.FuelType = car.FuelType;
            returned.Power = car.Power;
            returned.Description = car.Description;
            returned.Id = car.Id;
            returned.Mileage = returned.Mileage;
            returned.MakerId = car.MakerId;
            returned.ModelName = car.ModelName;
            returned.ModelYear = car.ModelYear;
            returned.Sold = car.Sold;
            returned.Weight = car.Weight;
            returned.UserId = car.UserId;
            returned.Negotiable = car.Negotiable;

            returned.User = car.User.ToUserDto();
            returned.Maker = car.Maker.ToMakerDto();

            return returned;
        }
    }
}
