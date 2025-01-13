using MicroserviceProject.Cargo.DataAccessLayer.Abstract;
using MicroserviceProject.Cargo.DataAccessLayer.Concrete;
using MicroserviceProject.Cargo.DataAccessLayer.Repositories;
using MicroserviceProject.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceProject.Cargo.DataAccessLayer.EntityFramework
{
    public class EfCargoCustomerDal : GenericRepository<CargoCustomer>, ICargoCustomerDal
    {
        public EfCargoCustomerDal(CargoContext context) : base(context)
        {

        }
    }
}
