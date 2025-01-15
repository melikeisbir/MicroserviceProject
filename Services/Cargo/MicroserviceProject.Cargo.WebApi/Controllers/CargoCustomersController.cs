using MicroserviceProject.Cargo.BusinessLayer.Abstract;
using MicroserviceProject.Cargo.DtoLayer.Dtos.CargoCustomerDtos;
using MicroserviceProject.Cargo.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviceProject.Cargo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoCustomersController : ControllerBase
    {
        private readonly ICargoCustomerService _cargoCustomerService;

        public CargoCustomersController(ICargoCustomerService cargoCustomerService)
        {
            _cargoCustomerService = cargoCustomerService;
        }
        [HttpGet]
        public IActionResult CargoCustomerList()
        {
            var values = _cargoCustomerService.TGetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetCargoCustomerById(int id)
        {
            var value = _cargoCustomerService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateCargoCustomer(CreateCargoCustomerDto createCargoCustomerDto)
        {
            CargoCustomer cargoCustomer = new CargoCustomer()
            {
                Address = createCargoCustomerDto.Address,
                City = createCargoCustomerDto.City,
                Name = createCargoCustomerDto.Name,
                District = createCargoCustomerDto.District,
                Email = createCargoCustomerDto.Email,
                Phone = createCargoCustomerDto.Phone,
                Surname = createCargoCustomerDto.Surname
            };
            _cargoCustomerService.TInsert(cargoCustomer);
            return Ok("Kargo müşteri ekleme işlemi başarıyla yapıldı.");
        }
        [HttpDelete]
        public IActionResult RemoveCargoCustomer(int id)
        {
            _cargoCustomerService.TDelete(id);
            return Ok("Kargo müşteri silme işlemi başarıyla yapıldı.");
        }
        [HttpPut]
        public IActionResult UpdateCargoCustomer(UpdateCargoCustomerDto updateCargoCustomerDto)
        {
            CargoCustomer cargoCustomer = new CargoCustomer()
            {
                Address = updateCargoCustomerDto.Address,
                City = updateCargoCustomerDto.City,
                Name = updateCargoCustomerDto.Name,
                Phone = updateCargoCustomerDto.Phone,
                Surname = updateCargoCustomerDto.Surname,
                District = updateCargoCustomerDto.District,
                Email = updateCargoCustomerDto.Email,
                CargoCustomerId = updateCargoCustomerDto.CargoCustomerId
            };
            _cargoCustomerService.TUpdate(cargoCustomer);
            return Ok("Kargo müşteri güncelleme işlemi başarıyla yapıldı.");
        }
    }
}
