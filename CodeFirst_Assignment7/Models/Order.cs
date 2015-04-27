using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst_Assignment7.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}