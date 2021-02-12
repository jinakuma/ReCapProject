using System;
using System.Collections.Generic;
using Entities.Concrete;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
    }
}
