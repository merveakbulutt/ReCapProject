using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
            new Car() { Id = 1, BrandId = 1, ColorId = 2, ModelYear = "2003", DailyPrice = 900, Description = "spor" },
            new Car() { Id = 2, BrandId = 2, ColorId = 2, ModelYear = "2010", DailyPrice = 800, Description = "otamatik" },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
              carToUpdate.BrandId = car.BrandId;
              carToUpdate.ColorId = car.ColorId;
              carToUpdate.DailyPrice = car.DailyPrice;
              carToUpdate.ModelYear = car.ModelYear;
              carToUpdate.Description = car.Description;
        }
    }
}
