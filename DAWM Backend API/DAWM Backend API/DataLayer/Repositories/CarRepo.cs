using DAWM_Backend_API.DataLayer.Models;

namespace DAWM_Backend_API.DataLayer.Repositories
{
    public class CarRepo
    {
        public List<Car> GetAll()
        {
            var returned = DbContext.Cars;
            return returned;
        }

        public Car GetById(int carId)
        {
            var returned = DbContext.Cars
                .Where(q => q.Id == carId)
                .FirstOrDefault();

            return returned;
        }

        public bool Add(Car car)
        {
            DbContext.Cars.Add(car);
            return true;
        }

        public bool DeleteById(int carId)
        {
            return DbContext.Cars.Remove(GetById(carId));
        }
    }
}
