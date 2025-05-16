namespace testAppConsol
{
    internal partial class Program
    {
        ////
        public interface IPaymentProcessor
        {
            void ProcessPayment(Order order);

        }
    }

}