using Entities.Enums;

namespace Entities.Concrete
{
    public class PERSON
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public BloodGroup BLOOD { get; set; }
        public string PHONENUMBER { get; set; }
        public string ADDRESS { get; set; }
    }
}
