namespace Orders.Interfaces
{
    public interface IOrder
    {
        int Id { get; set; }

        int ProductId { get; set; }

        int Quantity { get; set; }

        decimal Discount { get; set; }
    }
}
