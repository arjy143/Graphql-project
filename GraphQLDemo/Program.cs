using GraphQLDemo;
using HotChocolate.AspNetCore;
using HotChocolate.
AspNetCore.Playground;

namespace GraphQLDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddScoped
            <ISupplierRepository,
            SupplierRepository>();
            builder.Services.AddGraphQLServer()
                .AddType<SupplierType>()
                .AddQueryType<SupplierGraphQLQuery>()
                .AddSubscriptionType<SupplierSubscription>()

                .AddInMemorySubscriptions();
            builder.Services.AddControllers();
            var app = builder.Build();
            // Configure the HTTP request pipeline.
            app.UseAuthorization();
            app.MapControllers();
            app.UsePlayground(new PlaygroundOptions
            {
                QueryPath = "/graphql",
                Path = "/playground"
            });
            app.MapGraphQL();
            app.Run();
        }
    }
}