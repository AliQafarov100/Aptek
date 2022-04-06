
using System;
using System.Collections.Generic;
using System.Text;

namespace JSONPracitce
{
    class Order
    {
        public int Id { get; set; }
        public List<OrderItem> orderItems { get; set; }
        public double GeneralPrice { get; set; }
    }
}
