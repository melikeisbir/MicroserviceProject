using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceProject.Order.Application.Features.CQRS.Results.AddressResults
{
    public class GetAddressQueryResult //address sınıfındaki propertyleri tutacak onları listelememizi sağlayacak
    {
        public int AddressId { get; set; }
        public string UserId { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Detail { get; set; }
    }
}
