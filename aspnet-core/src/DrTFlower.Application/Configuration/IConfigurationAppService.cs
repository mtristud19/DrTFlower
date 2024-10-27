using System.Threading.Tasks;
using DrTFlower.Configuration.Dto;

namespace DrTFlower.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
