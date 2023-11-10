using HotChocolate.Execution;
using HotChocolate.Subscriptions;
using static GraphQLDemo.Order;

namespace GraphQLDemo
{
    public class SupplierSubscription
    {
        [SubscribeAndResolve]
        public async ValueTask
        <ISourceStream
        <List<Supplier>>>
        OnSuppliersGet([Service]
        ITopicEventReceiver eventReceiver,
           CancellationToken
        cancellationToken)
        {
            return await
            eventReceiver.SubscribeAsync
            <List<Supplier>>
            ("Returned Suppliers",
            cancellationToken);
        }
    }
}
