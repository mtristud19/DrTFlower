using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DrTFlower.Authorization;

namespace DrTFlower
{
    [DependsOn(
        typeof(DrTFlowerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DrTFlowerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DrTFlowerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DrTFlowerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
