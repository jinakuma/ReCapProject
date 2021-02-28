using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IResult Add(Brand brand);
        IDataResult<Brand> GetById(int id);
        IResult Delete(Brand brand);
        IResult Update(Brand brand);
    }
}
