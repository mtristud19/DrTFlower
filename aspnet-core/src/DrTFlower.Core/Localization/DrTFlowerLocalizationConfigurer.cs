using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace DrTFlower.Localization
{
    public static class DrTFlowerLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(DrTFlowerConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(DrTFlowerLocalizationConfigurer).GetAssembly(),
                        "DrTFlower.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
