using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace CG.Logging.QuickStart
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>(); // < -- call our startup class ...
                })
                .Build();

            host.Start();
        }
    }
}
