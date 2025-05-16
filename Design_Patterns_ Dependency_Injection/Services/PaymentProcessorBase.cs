namespace testAppConsol
{
    internal partial class Program
    {
        public abstract class PaymentProcessorBase : IPaymentProcessor
        {
            public void ProcessPayment(Order order)
            {
                Validate(order);
                Console.WriteLine($"Proces Was Successfully");
            }

            protected virtual void Validate(Order order)
            {
                if (order == null)
                    throw new ArgumentNullException(nameof(order));
                if (order.Amount < 0)

                    throw new ArgumentException("Order must have amount > zero");

            }
        }
    }

}