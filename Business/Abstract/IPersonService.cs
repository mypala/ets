using Entities.Models;
using ResponseStates.Models;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IPersonService
    {
        ResponseState<Person> Detail(int id);
        ResponseState<List<Person>> List();
        ResponseState Add(Person person);
    }
}
