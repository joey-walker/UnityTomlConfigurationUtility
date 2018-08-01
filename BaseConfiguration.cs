using Nett;

namespace ZCorp.ConfigurationUtilities
{
    public class BaseConfiguration
    {
        public BaseConfiguration()
        {
            Graphics = new Graphics();
            Audio = new Audio();
        }


        public BaseConfiguration(TomlTable tomlTable)
        {
            Graphics = tomlTable.TryGetValue("Graphics").Get<Graphics>();
            Audio = tomlTable.TryGetValue("Graphics").Get<Audio>();
        }

        public Graphics Graphics { set; get; }
        public Audio Audio { set; get; }
    }
}