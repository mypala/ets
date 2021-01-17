using Business.Abstract;
using DataLayer.Dals.Abstract;
using Entities.Concrete;
using Entities.Models;
using ResponseStates.Enums;
using ResponseStates.Exceptions;
using ResponseStates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonService : IPersonService
    {
        private readonly IPersonDal _personDal;
        //private readonly IMapper _mapper;

        public PersonService(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public ResponseState<Person> Detail(int id)
        {
            var process = _personDal.Find(x => x.ID == id);

            if (process == null)
                throw new StateException { StateCode = StateCode.PersonNotFound };

            return new ResponseState<Person>()
            {
                Content = new Person()
                {
                    ID = process.ID,
                    Name = process.NAME,
                    Surname = process.SURNAME,
                    Blood = process.BLOOD,
                    PhoneNumber = process.PHONENUMBER,
                    Address = process.ADDRESS
                }
            };
        }

        public ResponseState<List<Person>> List()
        {
            var process = _personDal.GetList();

            if (process == null || process.Count == 0)
                throw new StateException { StateCode = StateCode.PersonNotFound };

            return new ResponseState<List<Person>>()
            {
                Content = process.Select(x => new Person()
                {
                    ID = x.ID,
                    Name = x.NAME,
                    Surname = x.SURNAME,
                    Blood = x.BLOOD,
                    PhoneNumber = x.PHONENUMBER,
                    Address = x.ADDRESS
                }).ToList()
            };
        }

        public ResponseState Add(Person person)
        {
            var process = _personDal.Add(new PERSON()
            {
                NAME = person.Name,
                SURNAME = person.Surname,
                BLOOD = person.Blood,
                PHONENUMBER = person.PhoneNumber,
                ADDRESS = person.Address
            });

            if (process == null)
                throw new StateException { StateCode = StateCode.PersonNotAdd };

            return new ResponseState(StateCode.PersonAdd);
        }
    }
}
