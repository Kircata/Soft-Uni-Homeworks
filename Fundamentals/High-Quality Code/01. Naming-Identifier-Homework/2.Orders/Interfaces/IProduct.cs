namespace Orders.Interfaces
{
    public interface IProduct
    {
        int Id { get; set; }

        string Name { get; set; }

        int CategoryId { get; set; }

        decimal UnitPrice { get; set; }

        int UnitsInStock { get; set; }
    }
}
