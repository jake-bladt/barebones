using System;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Hosting;

namespace barebones
{
    class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return new WebHostBuilder()
                .UseKestrel(options => options.Listen(IPAddress.Loopback, 8888))
                .UseStartup<Startup>()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .Build();
        }

    }
}
