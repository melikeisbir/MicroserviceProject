﻿using MicroserviceProject.Order.Application.Features.CQRS.Queries.OrderDetailQueries;
using MicroserviceProject.Order.Application.Features.CQRS.Results.OrderDetailResults;
using MicroserviceProject.Order.Application.Interfaces;
using MicroserviceProject.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceProject.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class GetOrderDetailByIdQueryHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public GetOrderDetailByIdQueryHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public async Task<GetOrderDetailByIdQueryResult> Handle(GetOrderDetailByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetOrderDetailByIdQueryResult
            {
                ProductAmount = values.ProductAmount,
                OrderingId = values.OrderingId,
                ProductId = values.ProductId,
                ProductName = values.ProductName,
                ProductPrice = values.ProductPrice,
                ProductTotalPrice = values.ProductTotalPrice
            };
        }
    }
}
