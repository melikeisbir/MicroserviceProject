using MediatR;
using MicroserviceProject.Order.Application.Features.Mediator.Results.OrderingResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceProject.Order.Application.Features.Mediator.Queries.OrderingQueries
{
    public class GetOrderingQuery : IRequest<List<GetOrderingQueryResult>>
    {
    }
}
