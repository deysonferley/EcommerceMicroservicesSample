﻿using Ecommerce.Api.Search.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Api.Search.Interfaces
{
    public interface ICustomersService
    {
        Task<(bool IsSuccess, IEnumerable<CustomerModel> Customers)> GetAllCustomersAsync();
        Task<(bool IsSuccess, CustomerModel Customer)> GetCustomerAsync(int id);
    }
}
