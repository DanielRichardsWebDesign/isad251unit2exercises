using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace ISAD251.Models
{
    public class ProductDB : DbContext
    {
        public DbSet<Products> products { get; set; }
        public DbSet<Orders> orders { get; set; }
        public DbSet<Order_Lines> order_lines { get; set; }
    }
}