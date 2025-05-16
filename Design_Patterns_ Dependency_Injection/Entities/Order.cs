namespace testAppConsol
{
    internal partial class Program
    {
        public class Order
        {
            private static int _orderCounter = 0;
            public int Id { get; set; }
            public decimal Amount { get; set; }
            public string? Description { get; set; }

            public Customer Customer = new();
            public List<Product> Products = new();

            public Order()
            {
                _orderCounter++;
                Id = _orderCounter;

            }
            private void Total()
            {
                foreach (var item in Products)
                {
                    if (item != null)
                        Amount += item.Price;

                }
            }
            private string? ProductNames()
            {
                var names = new List<string>();
                foreach (var item in Products)
                {
                    names.Add(item.Name!);


                }
                return string.Join(", ", names);
            }

            public override string ToString()
            {
                Total();
                return $"***********************************************************\n" +
                       $"Order Id = {Id} ,Customer Name {Customer.FirstName}\n" +
                       $"---------------------------------------------------\n" +
                       $"Has a {Products.Count} Products: {ProductNames()}\n" +
                       $"With total amout = {Amount}" +
                       $"\n=> Payment by {Description}" +
                       $"\n***********************************************************";
            }
        }
    }

}