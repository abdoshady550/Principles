namespace testAppConsol
{
    internal partial class Program
    {
        public class PayPalProcessor : PaymentProcessorBase
        {
            protected override void Validate(Order order)
            {
                base.Validate(order);
                Console.WriteLine("Valid Payment Method");
            }


        }
    }

}