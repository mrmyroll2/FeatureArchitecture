var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Web_API>("web-api");

await builder.Build().RunAsync();
