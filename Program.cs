
using HotChocolate.Execution.Configuration;
using SortInputObjectIssue.Models;

namespace SortInputObjectIssue;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        IRequestExecutorBuilder executorBuilder = builder.Services.AddGraphQLServer();

        executorBuilder.AddQueryType<Query>();

        executorBuilder.BindRuntimeType<IEncodedString, StringType>();
        executorBuilder.AddTypeConverter<EncodedString, string>(x => x.GetValue());
        executorBuilder.AddTypeConverter<string, EncodedString>(x => new(x));

        executorBuilder.AddSorting();
        executorBuilder.InitializeOnStartup();

        builder.Services.AddControllers();

        var app = builder.Build();

        app.UseAuthorization();
        app.MapControllers();
        app.MapGraphQL();

        app.Run();
    }
}
