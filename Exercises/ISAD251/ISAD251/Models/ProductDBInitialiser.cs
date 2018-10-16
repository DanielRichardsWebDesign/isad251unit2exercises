using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace ISAD251.Models
{
    public class ProductDBInitialiser : CreateDatabaseIfNotExists<ProductDB>
    {
        protected override void Seed(ProductDB context)
        {
            context.products.AddOrUpdate(
                p => p.ProductId,
                new Products { Product_Code = "A123", Product_Name = "Ball point pens", Stock = 200, Price = (float)0.20 },
                new Products { Product_Code = "A127", Product_Name = "Fountain pens", Stock = 100, Price = (float)1.20 }
            );

            context.orders.AddOrUpdate(
                o => o.Order_Number,
                new Orders {  Order_Number = 1, Order_Date = DateTime.Now}
            );

            context.SaveChanges();

            //Gather the products into a dictionary, but output from the product code the Product ID
            var Products = context.products.ToDictionary(p => p.Product_Code, p => p.ProductId);

            context.order_lines.AddOrUpdate(
                new Order_Lines { Order_Number = 1, ProductID = Products["A123"], Quantity = 2 },
                new Order_Lines { Order_Number = 1, ProductID = Products["A127"], Quantity = 1}
            );

            context.SaveChanges();

        }
    }
}