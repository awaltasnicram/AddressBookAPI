using AddressBook;
using Microsoft.AspNetCore.Mvc;


namespace AddressBookAPI.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class AddressesController : ControllerBase
    {
        private readonly IAddressServices _addressServices;
        public AddressesController(IAddressServices addressServices)
        {
            _addressServices = addressServices;
        }

        [HttpGet]
        public IActionResult GetAddresses()
        {
            return Ok(_addressServices.GetAddresses());
        }

        [HttpGet("{id}", Name = "GetAddress")]
        public IActionResult GetAddress(string id)
        {
            return Ok(_addressServices.GetAddress(id));
        }

        [HttpPost]
        public IActionResult AddAddress(Address address)
        {
            _addressServices.AddAddress(address);
            return CreatedAtRoute("GetAddress", new { id = address.Adres}, address);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAddress(string id)
        {
            _addressServices.DeleteAddress(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateAddress(Address address)
        {
            return Ok(_addressServices.UpdateAddress(address));
        }
    }
}
