using Business.Abstract;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResponseStates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMW.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _service;

        public PersonController(IPersonService service)
        {
            _service = service;
        }

        [HttpGet]
        public ResponseState<List<Person>> Get()
        {
            return _service.List();
        }

        [HttpGet("{id}")]
        public ResponseState<Person> Get(int id)
        {
            return _service.Detail(id);
        }

        [HttpPost]
        public ResponseState Post(Person person)
        {
            return _service.Add(person);
        }
    }
}
