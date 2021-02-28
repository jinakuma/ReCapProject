﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IDataResult<Rental> GetById(int id);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
    }
}