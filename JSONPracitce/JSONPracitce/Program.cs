using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Text;  

namespace JSONPracitce
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer { Id = 1, Brand = "MSI", Ram = "16GB", GraphicCard = "ETX3090", Price = 8500.99 };

            Computer computer1 = new Computer { Id = 2, Brand = "ACER", Ram = "8GB", GraphicCard = "GTX1050", Price = 4500.70 };
            Computer computer2 = new Computer { Id = 3, Brand = "McBook", Ram = "32GB", GraphicCard = "MRX", Price = 5000 };
            Computer computer3 = new Computer { Id = 4, Brand = "Lenovo", Ram = "4B", GraphicCard = "AMD Ryzen", Price = 900.49 };

            OrderItem orderItem1 = new OrderItem { Id = 1, Computer = computer1, Price = computer1.Price, };
            OrderItem orderItem2 = new OrderItem { Id = 2, Computer = computer2, Price = computer2.Price, };
            OrderItem orderItem3 = new OrderItem { Id = 3, Computer = computer3, Price = computer3.Price, };

            Order order = new Order
            {
                Id = 1,
                orderItems = new List<OrderItem>()
                {
                    orderItem1,
                    orderItem2,
                    orderItem3
                },
                GeneralPrice = 18902.18
            };


            var orderStr = JsonConvert.SerializeObject(order);


           
        } 

            
        
    }
    
}
