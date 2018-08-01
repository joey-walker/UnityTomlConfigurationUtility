namespace ZCorp.ConfigurationUtilities
{
    public class BaseConfiguration
    {
        public BaseConfiguration()
        {
            Graphics = new Graphics();
            Audio = new Audio();
        }

        public Graphics Graphics { set; get; }
        public Audio Audio { set; get; }
    }
}