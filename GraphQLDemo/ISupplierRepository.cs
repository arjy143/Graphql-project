using static GraphQLDemo.Order;

namespace GraphQLDemo
{
    public interface ISupplierRepository
    {
        public Task<List<Supplier>> GetSuppliers();
        public Task<Supplier> GetSupplier(int Id);
    }
}
