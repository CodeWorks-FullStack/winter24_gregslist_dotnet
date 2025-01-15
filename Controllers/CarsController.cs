namespace gregslist_dotnet.Controllers;

[ApiController]
[Route("api/cars")] // TODO show off fancy thing
public class CarsController : ControllerBase
{
  public CarsController(CarsService carsService)
  {
    _carsService = carsService;
  }

  private readonly CarsService _carsService;


  [HttpGet]
  public ActionResult<List<Car>> GetAllCars()
  {
    try
    {
      List<Car> cars = _carsService.GetAllCars();
      return Ok(cars);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpGet("{carId}")]
  public ActionResult<Car> GetCarById(int carId)
  {
    try
    {
      Car car = _carsService.GetCarById(carId);
      return Ok(car);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }
}