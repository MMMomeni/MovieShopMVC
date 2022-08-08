﻿using MovieShopMVC.Core.Contracts.Repository;
using MovieShopMVC.Core.Entities;
using MovieShopMVC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopMVC.Infrastructure.Repository
{
    public class CastRepositoryAsync : BaseRepositoryAsync<Cast>, ICastRepositoryAsync
    {
        public CastRepositoryAsync(MovieShopDbContext DbContext) : base(DbContext)
        {
        }
    }
}
