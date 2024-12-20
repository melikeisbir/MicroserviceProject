using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceProject.Order.Application.Features.CQRS.Queries.AddressQueries
{
    public class GetAddressByIdQuery
    {
        public int Id { get; set; } //controllerda constructor üzerinden çağrılacak

        public GetAddressByIdQuery(int id)
        {
            Id = id;
        }
    }
}
