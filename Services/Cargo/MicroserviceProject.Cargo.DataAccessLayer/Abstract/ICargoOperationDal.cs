﻿using MicroserviceProject.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceProject.Cargo.DataAccessLayer.Abstract
{
    public interface ICargoOperationDal : IGenericDal<CargoOperation>
    {
    }
}
