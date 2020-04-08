using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ElectronicDataInterchange.Api
{
    public class Program
    {
        public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();
        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(OnWebHostBuild);
        private static void OnWebHostBuild(IWebHostBuilder webHostBuilder) => webHostBuilder.UseStartup<Startup>();
    }
}
