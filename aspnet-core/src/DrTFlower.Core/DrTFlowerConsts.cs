using DrTFlower.Debugging;

namespace DrTFlower
{
    public class DrTFlowerConsts
    {
        public const string LocalizationSourceName = "DrTFlower";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "bfdd1344060c4d2bb312e81f0b661d04";
    }
}
