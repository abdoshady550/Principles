namespace testAppConsol
{
    internal partial class Program
    {
        public abstract class BaseEntity
        {
            public int Id { get; set; }
            public DateTime CreatedAt { get; private set; }
            public DateTime? UpdatedAt { get; set; }

            public BaseEntity()
            {
                CreatedAt = DateTime.Now;
            }


        }
    }

}