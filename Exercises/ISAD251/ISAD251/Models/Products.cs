using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISAD251.Models
{
    public class Products
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string Product_Code { get; set; }
        public string Product_Name { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }

        public Products()
        {

        }
    }
}