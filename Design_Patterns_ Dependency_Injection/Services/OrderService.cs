using System;
using System.Collections.Generic;
using static testAppConsol.Program;

internal partial class Program
{
    public class OrderService
    {
        private readonly IRepository<Product> _productRepo;
        private readonly IRepository<Customer> _customerRepo;
        private readonly IEnumerable<IPaymentProcessor> _paymentProcessorsproductRepo;

        public OrderService(
            IRepository<Product> productRepo,
            IRepository<Customer> customerRepo,
            IEnumerable<IPaymentProcessor> paymentProcessors)
        {
            _productRepo = productRepo;
            _customerRepo = customerRepo;
            _paymentProcessorsproductRepo = paymentProcessors;
        }

        public Order CreateOrder(int customerID, List<int> productIds, string paymentMethod)
        {
            var customerId = _customerRepo.GetById(customerID);

            var productList = new List<Product>();

            for (int i = 0; i < productIds.Count; i++)
            {

                productList.Add(_productRepo.GetById(productIds[i]));

            }

            Order order = new Order() { Customer = customerId, Products = productList };

            List<IPaymentProcessor> processor = (List<IPaymentProcessor>)_paymentProcessorsproductRepo;

            if (paymentMethod.ToLower() == "creditcard")
            {
                processor[0] = new CreditCardProcessor();
                processor[0].ProcessPayment(order);
                order.Description = "Credit Card";
            }
            else if (paymentMethod.ToLower() == "paypal")
            {
                processor[0] = new PayPalProcessor();
                processor[0].ProcessPayment(order);
                order.Description = "PayPal Account";
            }
            else
            {
                throw new Exception($"Not support that payment method: {paymentMethod}");
            }
            return order;


        }
    }
}



