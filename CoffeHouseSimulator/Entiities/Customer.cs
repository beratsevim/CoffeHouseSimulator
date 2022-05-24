using CoffeHouseSimulator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeHouseSimulator.Entiities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime DateOfBird { get; set; }
        public String NationalityId { get; set; }

    }
}
