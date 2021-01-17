using DataLayer.Context.Concrete;
using DataLayer.Dals.Abstract;
using DataLayer.Repositories;
using Entities.Concrete;

namespace DataLayer.Dals.Concrete
{
    public class PersonDal : EfRepository<PERSON>, IPersonDal
    {
        public PersonDal(ETSContext context) : base(context)
        {

        }
    }
}
