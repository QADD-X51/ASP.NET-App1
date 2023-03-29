using DAWM_Backend_API.DataLayer.Dtos;
using DAWM_Backend_API.DataLayer.Models;
using DAWM_Backend_API.DataLayer.Repositories;

namespace DAWM_Backend_API.Core.Services
{
    public class CarService
    {
        private CarRepo carRepo { get; set; }

        public CarService(CarRepo _carRepo)
        {
            carRepo = _carRepo;
        }

        public List<Car> GetAll()
        {
            var returned = carRepo.GetAll();
            return returned;
        }

        public Car GetById(int carId)
        {
            var cars = carRepo.GetById(carId);

            return cars;
        }

        public bool Add(Car car)
        {
            return carRepo.Add(car);
        }

        public bool Delete(int carId)
        {
            return carRepo.DeleteById(carId);
        }

    }
}
