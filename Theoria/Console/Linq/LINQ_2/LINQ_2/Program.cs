using LINQ_2;

internal class Program
{
    static public List<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "John Doe" },
            new Customer { Id = 2, Name = "Jane Smith" },
            new Customer { Id = 3, Name = "Emily Johnson" },
            new Customer { Id = 4, Name = "Michael Brown" }
        };
    static public List<Order> orders = new List<Order>
        {
            new Order { Id = 1,  CustomerId = 1, Price = 100.50 },
            new Order { Id = 2,  CustomerId = 1, Price = 200.75 },
            new Order { Id = 3,  CustomerId = 1, Price =  50.25 },
            new Order { Id = 4,  CustomerId = 1, Price = 300.40 },
            new Order { Id = 5,  CustomerId = 1, Price = 150.00 },
            new Order { Id = 6,  CustomerId = 1, Price = 250.80 },
            new Order { Id = 7,  CustomerId = 2, Price =  80.00 },
            new Order { Id = 8,  CustomerId = 2, Price = 120.00 },
            new Order { Id = 9,  CustomerId = 3, Price =  90.00 },
            new Order { Id = 10, CustomerId = 3, Price = 210.00 },
            new Order { Id = 11, CustomerId = 4, Price = 500.00 },
            new Order { Id = 12, CustomerId = 4, Price =  60.00 },
            new Order { Id = 13, CustomerId = 4, Price = 140.00 },
            new Order { Id = 14, CustomerId = 4, Price =  80.00 }
        };
    private static void Main(string[] args)
    {
        ////Получить имя человека, который сделал самый дорогой заказ
        //string Expensive = customers.Join(orders, c => c.Id, o => o.CustomerId,
        //        (c, o) => new { customerId = c.Id, orderId = o.Id, price = o.Price, name = c.Name })
        //        .OrderByDescending(item => item.price).First().name;

        ////Получить имена покупателей которые сделали больше чем 3 заказа
        //var customersMore3Orders = customers.Where(c => orders.Where(o => o.CustomerId == c.Id).Count() > 3);

        //foreach (var item in customersMore3Orders)
        //{
        //    Console.WriteLine(item.Name);
        //}

        ////Получить общую стоимость заказа каждого из покупателей

        ////1-ый способ
        //var orderJoinCustomer = customers.Join(orders,
        //        c => c.Id,
        //        o => o.CustomerId,
        //        (c, o) => new { name = c.Name, o.Price, CustomerId = c.Id });

        //var sumOrdersPerCustomer = orderJoinCustomer.GroupBy(o => o.CustomerId)
        //    .Select(g => new {
        //        customerId = g.Key,
        //        sumOfOrdersPrices = g.Sum(order => order.Price),
        //        name = g.Select(order => order.name).First()
        //    });

        ////2-ой способ
        //var customerTotalPrices = customers.Select(customer => new
        //{
        //    customer.Name,
        //    TotalPrice = orders.Where(order => order.CustomerId == customer.Id).Sum(order => order.Price)
        //});

        //foreach (var item in sumOrdersPerCustomer)
        //{
        //    Console.WriteLine(item.name + " : " + item.sumOfOrdersPrices);
        //}

        
    }
}