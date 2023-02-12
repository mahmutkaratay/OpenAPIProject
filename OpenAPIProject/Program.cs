using OpenAPIProject;
using OpenAI.GPT3.Extensions;
using OpenAPIProject.Services;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddOpenAIService(settings => settings.ApiKey = "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");
        services.AddHostedService<OpenAICompletionService>();
        //services.AddHostedService<OpenAIImageService>();
    })
    .Build();

host.Run();
