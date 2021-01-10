using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace CG.Logging.QuickStart
{
    class Program
    {
        static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder<Startup>(args)
                .Build()
                .Run();
        }
    }
}
