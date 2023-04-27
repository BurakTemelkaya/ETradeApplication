﻿using ETradeAPI.Application.Repositories;
using ETradeAPI.Domain.Entites;
using ETradeAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeAPI.Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ETradeAPIDbContext context) : base(context)
        {
        }
    }
}
