using CoffeHouseSimulator.Abstract;
using CoffeHouseSimulator.Adapters;
using CoffeHouseSimulator.Concrete;
using CoffeHouseSimulator.Entiities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeHouseSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBird = new DateTime(2001, 2, 12), FirstName = "Berat", LastName = "Sevim", NationalityId = "00000000000" });
            customerManager.Save(new Customer { DateOfBird = new DateTime(2001, 2, 12), FirstName = "Sude", LastName = "Sevim", NationalityId = "00000000000" });

            Console.ReadLine();
        }
    }
}
