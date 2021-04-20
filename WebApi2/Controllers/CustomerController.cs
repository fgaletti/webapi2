using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi2.Domain.Dtos;
using WebApi2.Domain.Services;

namespace WebApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _ICustomerService;


        public CustomerController(ICustomerService iCustomerService)
        {
            _ICustomerService = iCustomerService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //getAllAsync()
            return Ok(await _ICustomerService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Add(CustomerForAdd customerForAdd)
        {

            return Ok(await _ICustomerService.AddCustomerAsync(customerForAdd));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {

            return Ok(await _ICustomerService.GetAsync(id));
        }

        [HttpGet("GetCustomerByName")]
        public async Task<IActionResult> GetCustomerByName(string name)
        {

            return Ok(await _ICustomerService.GetAsyncByName(name));
        }

        [HttpGet("GetCustomerByNameRoute/{name}")]
        public async Task<IActionResult> GetCustomerByNameRoute(string name)
        {

            return Ok(await _ICustomerService.GetAsyncByName(name));
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {

            return Ok(await _ICustomerService.DeleteAsync(id));
        }
    }
}
