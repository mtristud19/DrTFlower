using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DrTFlower.EntityFrameworkCore;
using DrTFlower.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace DrTFlower.Web.Tests
{
    [DependsOn(
        typeof(DrTFlowerWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class DrTFlowerWebTestModule : AbpModule
    {
        public DrTFlowerWebTestModule(DrTFlowerEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DrTFlowerWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(DrTFlowerWebMvcModule).Assembly);
        }
    }
}