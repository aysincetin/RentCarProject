using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // without db - with InMemory
            /*
                CarManager carManager = new CarManager(new InMemoryCarDal());
                foreach (var car in carManager.GetAll())
                {
                    Console.WriteLine(car.ModelYear + " " + car.Description);
                }
            */

            CarManager carManager = new CarManager(new EFCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear + " " + car.Description);
            }
        }
    }
}
