using System;
using System.Collections.Generic;
using Entities.Concrete;
using System.Text;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        void Add(Car car);

        List<CarDetailDto> GetProductDetails();
    }
}
