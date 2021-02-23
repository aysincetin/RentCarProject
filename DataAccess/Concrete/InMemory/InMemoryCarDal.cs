using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2000,DailyPrice=60.000,Description="Opel Car"},
                new Car{Id=2,BrandId=2,ColorId=2,ModelYear=2005,DailyPrice=100.000,Description="BMW Car"},
                new Car{Id=3,BrandId=2,ColorId=1,ModelYear=2010,DailyPrice=350.000,Description="BMW Car"},
                new Car{Id=4,BrandId=3,ColorId=1,ModelYear=20020,DailyPrice=500.000,Description="Chevrolet Car"},
                new Car{Id=5,BrandId=3,ColorId=2,ModelYear=2021,DailyPrice=800.000,Description="Chevrolet Car"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById()
        {
            return null;
        }

        
    }
}
