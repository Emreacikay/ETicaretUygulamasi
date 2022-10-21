﻿using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistance.Repostories
{
    public class ProductReadRepository : ReadRepostory<Product>, IProductReadRepository
    {
        public ProductReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
