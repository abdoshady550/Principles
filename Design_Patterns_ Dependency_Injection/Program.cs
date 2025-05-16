
using static testAppConsol.Program;

internal partial class Program
{
    private static void Main(string[] args)
    {
        var products = new List<Product> {
                new Product { Id = 1, Name = "T-Shirt", Price = 19.99M },
                new Product { Id = 2, Name = "Sneakers", Price = 49.99M },
                new Product { Id = 3, Name = "Jeans", Price = 39.99M }
};
        var customers = new List<Customer>
        {
            new Customer { Id = 1, FirstName = "Abdo" },
             new Customer { Id = 2, FirstName = "Ahmed" },
              new Customer { Id = 3, FirstName = "Ali" }
        };


        var productRepo = new InMemoryRepository<Product>(products);
        var customerRepo = new InMemoryRepository<Customer>(customers);
        var creditProcessor = new CreditCardProcessor();
        var payPalProcessor = new PayPalProcessor();
        var paymentProcessors = new List<IPaymentProcessor> { creditProcessor, payPalProcessor };

        var orderService = new OrderService(productRepo, customerRepo, paymentProcessors);

        var order = orderService.CreateOrder(customerID: 1, productIds: new List<int> { 1, 2 },
            paymentMethod: "CreditCard"
        );

        var order2 = orderService.CreateOrder(customerID: 2, productIds: new List<int> { 3 },
            paymentMethod: "Paypal"
        );


        Console.WriteLine("\n");
        Console.WriteLine(order);
        Console.WriteLine("\n");
        Console.WriteLine(order2);
        Console.WriteLine("\n");

        //var order3 = orderService.CreateOrder(customerID: 3, productIds: new List<int> { 2, 3 },
        //             paymentMethod: "Instapay"
        //);
        //Console.WriteLine(order3);

        #region singlton

        //var objOfProducts = InMemoryRepository<Product>.Instance;
        //foreach (var item in products)
        //{
        //    objOfProducts.Add(item);
        //}
        //Console.WriteLine("\n--- All Products ---");

        //foreach (var item in objOfProducts.GetAll())
        //    Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Price: {item.Price}");
        #endregion
    }
}