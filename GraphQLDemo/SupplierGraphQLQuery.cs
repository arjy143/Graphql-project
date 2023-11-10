using HotChocolate.Subscriptions;
using static GraphQLDemo.Order;

namespace GraphQLDemo
{
    public class SupplierGraphQLQuery
    {
        public async Task<List<Supplier>>
        GetAllSuppliers([Service]
        ISupplierRepository supplierRepository,
        [Service] ITopicEventSender eventSender)
        {
            List<Supplier> suppliers = await
            supplierRepository.GetSuppliers();
            await eventSender.
            SendAsync("Returned a list of Suppliers", suppliers);
            return suppliers;
        }
    }
}
