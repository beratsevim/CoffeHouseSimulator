using CoffeHouseSimulator.Abstract;
using CoffeHouseSimulator.Entiities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeHouseSimulator.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private IPersonCheckService _checkService;

        public StarbucksCustomerManager(IPersonCheckService checkService)
        {
            _checkService = checkService;
        }

        public override void Save(Customer customer)
        {
            if (_checkService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid Person ");
            }

        }

    }
}
