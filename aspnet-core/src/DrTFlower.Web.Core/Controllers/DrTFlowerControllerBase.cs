using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DrTFlower.Controllers
{
    public abstract class DrTFlowerControllerBase: AbpController
    {
        protected DrTFlowerControllerBase()
        {
            LocalizationSourceName = DrTFlowerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
