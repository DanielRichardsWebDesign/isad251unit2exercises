using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISAD251.Models
{
    public class Orders
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Order_Number { get; set; }
        DateTime Order_Date { get; set; }
        public virtual ICollection<Order_Lines>Order_Lines { get; set; }

        public Orders()
        {

        }
    }
}