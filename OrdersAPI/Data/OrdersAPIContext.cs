﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrdersAPI.Models;

namespace OrdersAPI.Data
{
    public class OrdersAPIContext : DbContext
    {
        public OrdersAPIContext (DbContextOptions<OrdersAPIContext> options)
            : base(options)
        {
        }

        public DbSet<OrdersAPI.Models.Order> Order { get; set; } = default!;
        public DbSet<OrdersAPI.Models.Product> Products { get; set; }
    }
}
