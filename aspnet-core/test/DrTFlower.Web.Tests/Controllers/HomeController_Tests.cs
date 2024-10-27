using System.Threading.Tasks;
using DrTFlower.Models.TokenAuth;
using DrTFlower.Web.Controllers;
using Shouldly;
using Xunit;

namespace DrTFlower.Web.Tests.Controllers
{
    public class HomeController_Tests: DrTFlowerWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}