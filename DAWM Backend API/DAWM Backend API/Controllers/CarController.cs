using Microsoft.AspNetCore.Mvc;
using DAWM_Backend_API.Core.Services;
using DAWM_Backend_API.DataLayer.Models;

namespace DAWM_Backend_API.Controllers
{
    [ApiController]
    [Route("api/cars")]
    public class CarController : Controller
    {
        private CarService carService { get; set; }

        public CarController(CarService _carService)
        {
            carService = _carService;
        }

        [HttpGet("/car/get-all")]
        public ActionResult<List<Car>> GetAll()
        {
            var returned = carService.GetAll();
            return Ok(returned);
        }

        [HttpGet("/car/get/{carId}")]
        public ActionResult<Car> GetById(int carId)
        {
            var returned = carService.GetById(carId);

            if (returned == null)
                return BadRequest("Car does not exist!");

            return Ok(returned);
        }

        [HttpPost("/car/add")]
        public ActionResult<Car> AddUser([FromBody] Car car)
        {
            if (car == null) return BadRequest("Car can't be null!");

            if (!carService.Add(car))
                return BadRequest("Something went wrong adding new car.");

            return Ok("Car added!");
        }
    }
}
