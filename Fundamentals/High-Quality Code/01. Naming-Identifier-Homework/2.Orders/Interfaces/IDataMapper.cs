namespace Orders.Interfaces
{
    public interface IDataMapper
    {
        string CategoriesFileName { get; set; }
        string ProductsFileName { get; set; }
        string OrdersFileName { get; set; }
    }
}
