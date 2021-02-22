using System;
using System.Collections.Generic;
using Entities.Concrete;
using System.Text;
using Entities.DTOs;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IResult Add(Car car);
        IDataResult<Car> GetById(int id);
        IDataResult<List<CarDetailDto>> GetProductDetails();
    }
}
