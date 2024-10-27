using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DrTFlower.Configuration;

namespace DrTFlower.Web.Host.Startup
{
    [DependsOn(
       typeof(DrTFlowerWebCoreModule))]
    public class DrTFlowerWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DrTFlowerWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DrTFlowerWebHostModule).GetAssembly());
        }
    }
}
