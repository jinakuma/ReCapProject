using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
            _cars = new List<Car> {
                new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 100000, ModelYear = 2017, Description = "Renault Megan" },
                new Car { Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 110000, ModelYear = 2018, Description = "Renault Megan" },
                new Car { Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 200000, ModelYear = 2017, Description = "Fiat" },
                new Car { Id = 4, BrandId = 2, ColorId = 2, DailyPrice = 200000, ModelYear = 2019, Description = "Fiat" },
                new Car { Id = 5, BrandId = 3, ColorId = 2, DailyPrice = 300000, ModelYear = 2020, Description = "Volkswagen" },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car cartoDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(cartoDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByld(Car car)
        {
            return _cars.Where(c => c.Id == car.Id).ToList();
        }

        public List<Car> GetByld(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            
        }
    }
}
