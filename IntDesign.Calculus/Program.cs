using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace Calculus
{
    public static class Program
    {
        public static async Task Main(string[] args) =>
            await Task.Factory.StartNew(() => CreateWebHostBuilder(args).Build().Run());

        private static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureLogging((hostingContext, logging) =>
                {
                    logging.ClearProviders();
                    const string logConfig = "NLog.Development.config";
                    hostingContext.HostingEnvironment.ConfigureNLog(logConfig);
                })
                .UseWebRoot("")
                .UseNLog()
                .UseStartup<Startup>();
    }
}