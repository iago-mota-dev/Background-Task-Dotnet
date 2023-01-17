
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyWorker;

namespace SimpleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new HostBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                services.AddHostedService<Worker>();
            })
            .Build();
            host.Run();
        }
    }
}