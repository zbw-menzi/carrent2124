// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zbw.Carrent.Customer.Api
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<CustomerResponse> Get()
        {
            return new CustomerResponse[] { new CustomerResponse {  Id = Guid.NewGuid(), Name = "Cédric", CustomerNr ="R001", Address = "Musterweg 7" } };
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public string Get(Guid id)
        {
            return "";
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] CustomerRequest value)
        {
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] CustomerRequest value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
